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

namespace WindowsFormsAppQLBH_NGUYENLIEU
{
    public partial class FormQLBH_NGUYENLIEU : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=QLBH;Integrated Security=True";
        public FormQLBH_NGUYENLIEU()
        {
            InitializeComponent();
            this.Load += Form_Load;
            this.FormClosing += Form_Closing;

            DataGridViewNGUYENLIEU.CellClick += DataGridViewNGUYENLIEU_CellClick;
            btn_Them.Click += btn_Them_Click;
            btn_Sua.Click += btn_Sua_Click;
            btn_Xoa.Click += btn_Xoa_Click;
        }
        private void Form_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NGUYENLIEU";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGridViewNGUYENLIEU.DataSource = dt;
            }
        }

        private void ClearInputs()
        {
            txt_MANL.Clear();
            txt_TENNL.Clear();
            txt_DONVI.Clear();
            txt_SLTONKHO.Clear();
            txt_MANL.Focus();
        }

        private bool IsValidMaNL(string ma)
        {
            return ma.Length == 10 && ma.StartsWith("NL") && ma.Substring(2).All(char.IsDigit);
        }

        private bool IsValidInput()
        {
            if (!IsValidMaNL(txt_MANL.Text))
            {
                MessageBox.Show("Mã nguyên liệu phải có dạng 'NL' + 8 chữ số. Ví dụ: NL00000001", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_TENNL.Text))
            {
                MessageBox.Show("Tên nguyên liệu không được để trống.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_DONVI.Text))
            {
                MessageBox.Show("Đơn vị không được để trống.");
                return false;
            }

            if (!int.TryParse(txt_SLTONKHO.Text, out int sl) || sl < 0)
            {
                MessageBox.Show("Số lượng tồn kho phải là số nguyên không âm.");
                return false;
            }

            return true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!IsValidInput()) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string checkQuery = "SELECT COUNT(*) FROM NGUYENLIEU WHERE MANL = @MANL";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MANL", txt_MANL.Text);
                conn.Open();

                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("Mã nguyên liệu đã tồn tại.");
                    conn.Close();
                    return;
                }

                string query = "INSERT INTO NGUYENLIEU (MANL, TENNL, DONVI, SLTONKHO) VALUES (@MANL, @TENNL, @DONVI, @SLTONKHO)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MANL", txt_MANL.Text);
                cmd.Parameters.AddWithValue("@TENNL", txt_TENNL.Text);
                cmd.Parameters.AddWithValue("@DONVI", txt_DONVI.Text);
                cmd.Parameters.AddWithValue("@SLTONKHO", int.Parse(txt_SLTONKHO.Text));

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
            if (!IsValidInput()) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE NGUYENLIEU SET TENNL = @TENNL, DONVI = @DONVI, SLTONKHO = @SLTONKHO WHERE MANL = @MANL";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MANL", txt_MANL.Text);
                cmd.Parameters.AddWithValue("@TENNL", txt_TENNL.Text);
                cmd.Parameters.AddWithValue("@DONVI", txt_DONVI.Text);
                cmd.Parameters.AddWithValue("@SLTONKHO", int.Parse(txt_SLTONKHO.Text));

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Sửa thành công!");
                    else
                        MessageBox.Show("Không tìm thấy nguyên liệu để sửa.");

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
                string query = "DELETE FROM NGUYENLIEU WHERE MANL = @MANL";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MANL", txt_MANL.Text);

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Xóa thành công!");
                    else
                        MessageBox.Show("Không tìm thấy nguyên liệu để xóa.");

                    LoadData();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void DataGridViewNGUYENLIEU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridViewNGUYENLIEU.Rows[e.RowIndex];
                txt_MANL.Text = row.Cells["MANL"].Value.ToString();
                txt_TENNL.Text = row.Cells["TENNL"].Value.ToString();
                txt_DONVI.Text = row.Cells["DONVI"].Value.ToString();
                txt_SLTONKHO.Text = row.Cells["SLTONKHO"].Value.ToString();
            }
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Cảm ơn bạn đã sử dụng! Đóng ứng dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
