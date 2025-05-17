using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppQLBH_LOHANG
{
    public partial class FormLOHANG : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=QLBH;Integrated Security=True";
        public FormLOHANG()
        {
            InitializeComponent();
            DataGridView_LOHANG.CellClick += DataGridView_LOHANG_CellClick;
            this.Load += FormLOHANG_Load;
            this.FormClosing += FormLOHANG_FormClosing;

            btn_Them.Click += btn_Them_Click;
            btn_Sua.Click += btn_Sua_Click;
            btn_Xoa.Click += btn_Xoa_Click;
        }
        private void FormLOHANG_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM LOHANG";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGridView_LOHANG.DataSource = dt;
            }
        }
        private void ClearInputs()
        {
            txt_MALH.Clear();
            txt_GIANHAN.Clear();
            txt_MANL.Clear();
            DateTime_HSD.Value = DateTime.Now;
            txt_MALH.Focus();
        }
        private bool IsValidMaLH(string ma)
        {
            return ma.Length == 10 && ma.StartsWith("LH") && ma.Substring(2).All(char.IsDigit);
        }

        private bool IsValidMaNL(string ma)
        {
            return ma.Length == 10 && ma.StartsWith("NL") && ma.Substring(2).All(char.IsDigit);
        }

        private bool IsValidInput()
        {
            if (!IsValidMaLH(txt_MALH.Text))
            {
                MessageBox.Show("Mã lô hàng phải có dạng 'LH' + 8 chữ số. Ví dụ: LH00000001", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MALH.Focus();
                return false;
            }

            if (!decimal.TryParse(txt_GIANHAN.Text, out decimal gia) || gia <= 0)
            {
                MessageBox.Show("Giá nhận phải là số dương hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_GIANHAN.Focus();
                return false;
            }

            if (!IsValidMaNL(txt_MANL.Text))
            {
                MessageBox.Show("Mã nguyên liệu phải có dạng 'NL' + 8 chữ số. Ví dụ: NL00000001", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MANL.Focus();
                return false;
            }

            return true;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string checkQuery = "SELECT COUNT(*) FROM LOHANG WHERE MALH = @MALH";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MALH", txt_MALH.Text);
                conn.Open();
                int exists = (int)checkCmd.ExecuteScalar();
                conn.Close();

                if (exists > 0)
                {
                    MessageBox.Show("Mã lô hàng đã tồn tại.", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "INSERT INTO LOHANG (MALH, HSD, GIANHAN, MANL) VALUES (@MALH, @HSD, @GIANHAN, @MANL)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MALH", txt_MALH.Text);
                cmd.Parameters.AddWithValue("@HSD", DateTime_HSD.Value);
                cmd.Parameters.AddWithValue("@GIANHAN", Convert.ToDecimal(txt_GIANHAN.Text));
                cmd.Parameters.AddWithValue("@MANL", txt_MANL.Text);
                conn.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    LoadData();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm: " + ex.Message);
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE LOHANG SET HSD = @HSD, GIANHAN = @GIANHAN, MANL = @MANL WHERE MALH = @MALH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MALH", txt_MALH.Text);
                cmd.Parameters.AddWithValue("@HSD", DateTime_HSD.Value);
                cmd.Parameters.AddWithValue("@GIANHAN", Convert.ToDecimal(txt_GIANHAN.Text));
                cmd.Parameters.AddWithValue("@MANL", txt_MANL.Text);
                conn.Open();

                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Sửa thành công!");
                    else
                        MessageBox.Show("Không tìm thấy lô hàng.");
                    LoadData();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa: " + ex.Message);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM LOHANG WHERE MALH = @MALH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MALH", txt_MALH.Text);
                conn.Open();

                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Xóa thành công!");
                    else
                        MessageBox.Show("Không tìm thấy lô hàng cần xóa.");
                    LoadData();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }
        private void DataGridView_LOHANG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridView_LOHANG.Rows[e.RowIndex];
                txt_MALH.Text = row.Cells["MALH"].Value.ToString();
                DateTime_HSD.Value = Convert.ToDateTime(row.Cells["HSD"].Value);
                txt_GIANHAN.Text = row.Cells["GIANHAN"].Value.ToString();
                txt_MANL.Text = row.Cells["MANL"].Value.ToString();
            }
        }

        private void FormLOHANG_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Cảm ơn bạn đã sử dụng! Đóng ứng dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
