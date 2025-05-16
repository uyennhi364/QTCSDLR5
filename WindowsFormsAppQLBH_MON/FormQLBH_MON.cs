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

namespace WindowsFormsAppQLBH_MON
{
    public partial class FormQLBH_MON : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=QLBH;Integrated Security=True";

        public FormQLBH_MON()
        {
            InitializeComponent();
            DataGridView_MON.CellClick += DataGridView_MON_CellClick;
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM MON";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGridView_MON.DataSource = dt;
            }
        }


        private void ClearInputs()
        {
            text_MAMON.Clear();
            text_TENMON.Clear();
            text_GIABAN.Clear();
            text_DONVI.Text = "Ly";
            text_MAMON.Focus();
        }
        private bool IsValidMaMon(string maMon)
        {
            // Kiểm tra độ dài: phải là "MON" + 7 số => tổng cộng 10 ký tự
            if (maMon.Length != 10 || !maMon.StartsWith("MON"))
                return false;

            // Lấy phần sau "MON" và kiểm tra có phải 7 số không
            string soPhan = maMon.Substring(3);
            return soPhan.All(char.IsDigit);
        }
        private bool IsValidInput()
        {

            // Kiểm tra MAMON
            if (!IsValidMaMon(text_MAMON.Text))
            {
                MessageBox.Show("Mã món phải có dạng 'MON' + 7 chữ số. Ví dụ: MON0000123", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_MAMON.Focus();
                return false;
            }

            // Kiểm tra TENMON
            if (string.IsNullOrWhiteSpace(text_TENMON.Text) || text_TENMON.Text.Length > 100)
            {
                MessageBox.Show("Tên món không được để trống và tối đa 100 ký tự.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_TENMON.Focus();
                return false;
            }

            // Kiểm tra GIABAN
            if (!decimal.TryParse(text_GIABAN.Text, out decimal giaBan) || giaBan <= 0)
            {
                MessageBox.Show("Giá bán phải là số hợp lệ lớn hơn 0.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_GIABAN.Focus();
                return false;
            }
            
            // Kiểm tra DONVI
            if (string.IsNullOrWhiteSpace(text_DONVI.Text) || text_DONVI.Text.Length > 10)
            {
                MessageBox.Show("Đơn vị không được để trống và tối đa 10 ký tự.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_DONVI.Focus();
                return false;
            }

            return true;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (!IsValidInput()) // Kiểm tra hợp lệ trước khi cập nhật
                return;
            text_DONVI.Text = "Ly"; // Ép giá trị DONVI là "Ly"
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE MON SET TENMON = @TENMON, GIABAN = @GIABAN, DONVI = @DONVI WHERE MAMON = @MAMON";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAMON", text_MAMON.Text);
                cmd.Parameters.AddWithValue("@TENMON", text_TENMON.Text);
                cmd.Parameters.AddWithValue("@GIABAN", Convert.ToDecimal(text_GIABAN.Text));
                cmd.Parameters.AddWithValue("@DONVI", text_DONVI.Text);

                conn.Open();
                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Cập nhật thành công!");
                    else
                        MessageBox.Show("Không tìm thấy món cần sửa.");
                    LoadData();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa: " + ex.Message);
                }
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
                return;

            text_DONVI.Text = "Ly"; // Ép DONVI là "Ly"

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Kiểm tra trùng mã món
                string checkQuery = "SELECT COUNT(*) FROM MON WHERE MAMON = @MAMON";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MAMON", text_MAMON.Text);

                conn.Open();
                int exists = (int)checkCmd.ExecuteScalar();
                conn.Close();

                if (exists > 0)
                {
                    MessageBox.Show("Mã món đã tồn tại. Vui lòng nhập mã khác.", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Nếu không trùng, tiến hành thêm mới
                string query = "INSERT INTO MON (MAMON, TENMON, GIABAN, DONVI) VALUES (@MAMON, @TENMON, @GIABAN, @DONVI)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAMON", text_MAMON.Text);
                cmd.Parameters.AddWithValue("@TENMON", text_TENMON.Text);
                cmd.Parameters.AddWithValue("@GIABAN", Convert.ToDecimal(text_GIABAN.Text));
                cmd.Parameters.AddWithValue("@DONVI", text_DONVI.Text);

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm món thành công!");
                    LoadData();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm: " + ex.Message);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM MON WHERE MAMON = @MAMON";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAMON", text_MAMON.Text);

                conn.Open();
                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Xóa thành công!");
                    else
                        MessageBox.Show("Không tìm thấy món cần xóa.");
                    LoadData();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }

        }
        private void DataGridView_MON_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridView_MON.Rows[e.RowIndex];
                text_MAMON.Text = row.Cells["MAMON"].Value.ToString();
                text_TENMON.Text = row.Cells["TENMON"].Value.ToString();
                text_GIABAN.Text = row.Cells["GIABAN"].Value.ToString();
                text_DONVI.Text = row.Cells["DONVI"].Value.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Cảm ơn bạn đã sử dụng! Đóng ứng dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
