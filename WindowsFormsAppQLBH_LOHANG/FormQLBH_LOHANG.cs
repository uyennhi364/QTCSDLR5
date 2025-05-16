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
    public partial class FormQLBH_LOHANG : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=QLBH;Integrated Security=True";
         
        public FormQLBH_LOHANG()
        {
            InitializeComponent();
            
            DataGridViewLOHANG.CellClick += DataGridViewLOHANG_CellClick;
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
                string query = "SELECT * FROM LOHANG";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGridViewLOHANG.DataSource = dt;
            }
        }
        private void ClearInputs()
        {
            txt_MALH.Clear();
            txt_GIANHAN.Clear();
            txt_MANL.Clear();
            datetime_HSD.Value = DateTime.Now;
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
            {
                var confirm = MessageBox.Show("Dữ liệu nhập không hợp lệ.\nBạn có muốn tạo dữ liệu mẫu tự động không?",
                                              "Tạo dữ liệu mẫu",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("spTAODLDUMP_LOHANG", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Đã tạo dữ liệu mẫu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Load lại dữ liệu mới vào DataGridView
                            ClearInputs();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi tạo dữ liệu mẫu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Truy vấn để lấy MALH cuối cùng (có dạng 'LH' + 8 chữ số)
                string query = "SELECT TOP 1 MALH FROM LOHANG ORDER BY MALH DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open(); // Đặt conn.Open() ở đây

                string lastMALH = (string)cmd.ExecuteScalar(); // Lấy MALH cuối cùng

                // Tiếp tục xử lý MALH và insert
                string newMALH = GenerateNewMALH(lastMALH);

                string insertQuery = "INSERT INTO LOHANG (MALH, HSD, GIANHAN, MANL) VALUES (@MALH, @HSD, @GIANHAN, @MANL)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@MALH", newMALH);
                insertCmd.Parameters.AddWithValue("@HSD", datetime_HSD.Value);
                insertCmd.Parameters.AddWithValue("@GIANHAN", Convert.ToDecimal(txt_GIANHAN.Text));
                insertCmd.Parameters.AddWithValue("@MANL", txt_MANL.Text);

                try
                {
                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    LoadData(); // Load lại dữ liệu vào DataGridView
                    ClearInputs(); // Dọn dẹp dữ liệu đầu vào
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm: " + ex.Message);
                }
            }

        }

        // Hàm tạo MALH mới từ MALH cuối cùng (Cộng 1 vào phần số)
        private string GenerateNewMALH(string lastMALH)
        {
            // Lấy phần số từ MALH và cộng 1
            string numberPart = lastMALH.Substring(2); // lấy phần sau 'LH'
            int number = int.Parse(numberPart); // chuyển thành số
            number++; // cộng 1

            // Đảm bảo tạo lại mã có dạng 'LH' + 8 chữ số
            return "LH" + number.ToString("D8"); // D8 để luôn có 8 chữ số, ví dụ: LH01000001
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầu vào hợp lệ
            if (!IsValidInput())
                return;

            // Kiểm tra xem MALH có tồn tại trong cơ sở dữ liệu không
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string checkQuery = "SELECT COUNT(*) FROM LOHANG WHERE MALH = @MALH";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MALH", txt_MALH.Text);
                conn.Open();

                int exists = (int)checkCmd.ExecuteScalar(); // Kiểm tra số lượng bản ghi có MALH này
                conn.Close();

                if (exists == 0)
                {
                    // Nếu MALH không tồn tại, thông báo lỗi
                    MessageBox.Show("Không tìm thấy lô hàng với Mã Lô Hàng này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;  // Không thực hiện sửa nếu không tìm thấy lô hàng
                }
            }

            // Nếu MALH tồn tại, thực hiện sửa dữ liệu
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE LOHANG SET HSD = @HSD, GIANHAN = @GIANHAN, MANL = @MANL WHERE MALH = @MALH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MALH", txt_MALH.Text);
                cmd.Parameters.AddWithValue("@HSD", datetime_HSD.Value);
                cmd.Parameters.AddWithValue("@GIANHAN", Convert.ToDecimal(txt_GIANHAN.Text));
                cmd.Parameters.AddWithValue("@MANL", txt_MANL.Text);

                conn.Open();

                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Sửa thành công!");
                    else
                        MessageBox.Show("Không tìm thấy lô hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    LoadData(); // Tải lại dữ liệu mới vào DataGridView
                    ClearInputs(); // Dọn dẹp các trường nhập liệu
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem Mã Lô Hàng (MALH) có tồn tại trong cơ sở dữ liệu không
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string checkQuery = "SELECT COUNT(*) FROM LOHANG WHERE MALH = @MALH";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MALH", txt_MALH.Text);
                conn.Open();

                // Lấy kết quả đếm số bản ghi có mã MALH này
                int exists = (int)checkCmd.ExecuteScalar();
                conn.Close();

                // Nếu không tìm thấy bản ghi nào với MALH này, thông báo lỗi và không thực hiện xóa
                if (exists == 0)
                {
                    MessageBox.Show("Không tìm thấy lô hàng với Mã Lô Hàng này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;  // Không thực hiện xóa
                }

                // Nếu MALH tồn tại, thực hiện xóa
                string deleteQuery = "DELETE FROM LOHANG WHERE MALH = @MALH";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                deleteCmd.Parameters.AddWithValue("@MALH", txt_MALH.Text);
                conn.Open();

                try
                {
                    int rows = deleteCmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadData(); // Load lại dữ liệu sau khi xóa
                        ClearInputs(); // Dọn dẹp dữ liệu đầu vào
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa, lỗi trong quá trình thực hiện.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void DataGridViewLOHANG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridViewLOHANG.Rows[e.RowIndex];
                txt_MALH.Text = row.Cells["MALH"].Value.ToString();
                datetime_HSD.Value = Convert.ToDateTime(row.Cells["HSD"].Value);
                txt_GIANHAN.Text = row.Cells["GIANHAN"].Value.ToString();
                txt_MANL.Text = row.Cells["MANL"].Value.ToString();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Cảm ơn bạn đã sử dụng! Đóng ứng dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormQLBH_LOHANG_Load(object sender, EventArgs e)
        {

        }
    }
}
