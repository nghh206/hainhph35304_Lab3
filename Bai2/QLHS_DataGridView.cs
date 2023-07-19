using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bai2
{
    public partial class QLHS_DataGridView : Form
    {
        static string connectionString = "Data Source=Nghh;Initial Catalog=QLHOCSINH;Persist Security Info=True;User ID=sa;Password=nghh206983";
        public QLHS_DataGridView()
        {
            InitializeComponent();
        }
        private void QLHS_DataGridView_Load(object sender, EventArgs e)
        {
            dataGridHocSInh.DataSource = GetDataFromDatabase();

            cbLop.DisplayMember = "MaLop";
            cbLop.ValueMember = "MaLop";
            cbLop.SelectedIndex = 0;
        }
        public DataSet FillDataSet(string sqlCommand)
        {
            DataSet ds = new DataSet();
            if (string.IsNullOrEmpty(sqlCommand))
            {
                return ds;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, conn);
                    adapter.Fill(ds);
                    return ds;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public DataTable GetDSLop()
        {
            string query = "SELECT MaLop FROM LOP";
            DataSet ds = FillDataSet(query);
            return ds.Tables[0];
        }
        private DataTable GetDataFromDatabase()
        {
            string query = "SELECT * FROM HOCSINH";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset về ban đầu 
            txtMaHS.Text = "";
            txtTenHS.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtDiaChi.Text = "";
            cbLop.Text = "";
            txtDTB.Text = "";
            txtMaHS.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy giá trị trong ô văn bản txtMaHS
            string maHS = txtMaHS.Text;

            // Kiểm tra xem người dùng đã nhập mã sinh viên hay chưa
            if (maHS != "")
            {
                // Tạo kết nối tới database
                SqlConnection conn = new SqlConnection(connectionString);

                // Tạo câu lệnh SQL để xóa thông tin sinh viên khỏi cơ sở dữ liệu
                string sql = "DELETE FROM HOCSINH WHERE MaHS = @MaHS";

                // Tạo đối tượng SqlCommand để thực thi câu lệnh SQL
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Thêm tham số vào câu lệnh SQL
                cmd.Parameters.AddWithValue("@MaHS", maHS);

                // Mở kết nối đến cơ sở dữ liệu
                conn.Open();

                // Thực thi câu lệnh SQL
                int rowsAffected = cmd.ExecuteNonQuery();

                // Đóng kết nối đến cơ sở dữ liệu
                conn.Close();

                // Kiểm tra xem có thông tin sinh viên nào bị xóa khỏi cơ sở dữ liệu hay không
                if (rowsAffected > 0)
                {
                    // Hiển thị thông báo xóa thành công
                    MessageBox.Show("Đã xóa thông tin sinh viên có mã " + maHS);
                }
                else
                {
                    // Hiển thị thông báo không tìm thấy sinh viên
                    MessageBox.Show("Không tìm thấy sinh viên có mã " + maHS);
                }
            }
            else
            {
                // Hiển thị thông báo yêu cầu nhập mã sinh viên
                MessageBox.Show("Bạn phải chọn sinh viên để xóa thông tin.");
            }
            dataGridHocSInh.DataSource = GetDataFromDatabase();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng xác nhận muốn thoát
            if (result == DialogResult.Yes)
            {
                // Đóng form hiện tại
                this.Close();
            }
        }

        private void txtMaHS_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu phím được nhấn không phải là chữ, số
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Không cho phép nhập ký tự đó vào ô văn bản
                e.Handled = true;
            }
        }

        private void txtTenHS_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu phím được nhấn không phải là chữ hoặc khoảng trắng
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Không cho phép nhập ký tự đó vào ô văn bản
                e.Handled = true;
            }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu phím được nhấn không phải là số, chữ, khoảng trắng hoặc dấu -
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                // Không cho phép nhập ký tự đó vào ô văn bản
                e.Handled = true;
            }
        }

        private void txtDTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu phím được nhấn không phải là số hoặc kí tự .
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                // Không cho phép nhập ký tự đó vào ô văn bản
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && txtDTB.Text.IndexOf('.') > -1)
            {
                // Không cho phép nhập kí tự . nếu đã có một kí tự . được nhập vào trước đó
                e.Handled = true;
            }
        }

        private void txtDTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            double dtb;
            if (!double.TryParse(txtDTB.Text, out dtb) || dtb < 0 || dtb > 10)
            {
                MessageBox.Show("Thang điểm là từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDTB.Focus();
                e.Cancel = true; // Hủy xác nhận giá trị của TextBox
            }
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem giá trị trong ô ComboBox có được chọn hay không
            if (cbLop.SelectedIndex == -1)
            {
                // Hiển thị thông báo yêu cầu người dùng phải chọn lớp
                MessageBox.Show("Bạn phải chọn một lớp.");
            }
        }

        private void dataGridHocSInh_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trên DataGridView hay không
            if (dataGridHocSInh.CurrentRow != null)
            {
                // Lấy dữ liệu từ dòng được chọn trên DataGridView
                DataGridViewRow row = dataGridHocSInh.CurrentRow;
                txtMaHS.Text = row.Cells["MaHS"].Value.ToString();
                txtTenHS.Text = row.Cells["TenHS"].Value.ToString();
                dtpNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
                cbLop.SelectedValue = row.Cells["MaLop"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtDTB.Text = row.Cells["DTB"].Value.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(txtMaHS.Text) ||
                string.IsNullOrEmpty(txtTenHS.Text) ||
                string.IsNullOrEmpty(dtpNgaySinh.Text) ||
                string.IsNullOrEmpty(txtDiaChi.Text) ||
                string.IsNullOrEmpty(cbLop.Text) ||
                string.IsNullOrEmpty(txtDTB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin học sinh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if ((DateTime.Now.Year - dtpNgaySinh.Value.Year) < 5)
            {
                MessageBox.Show("Vui lòng nhập học sinh trên 5 tuổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string query = "UPDATE HOCSINH SET MaHS = @MaHS, TenHS= @TenHS, NgaySinh = @NgaySinh, DiaChi = @DiaChi, MaLop = @MaLop, DTB = @DTB WHERE MaHS = @MaHS";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM LOP WHERE MaLop = @MaLop", connection);
                checkCommand.Parameters.AddWithValue("@MaLop", cbLop.Text);

                connection.Open();
                int count = (int)checkCommand.ExecuteScalar();
                if (count == 0)
                {
                    throw new Exception("Giá trị của cột MaLop không hợp lệ.");
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHS", txtMaHS.Text);
                command.Parameters.AddWithValue("@TenHS", txtTenHS.Text);
                command.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Text);
                command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                command.Parameters.AddWithValue("@DTB", txtDTB.Text);
                command.Parameters.AddWithValue("@MaLop", cbLop.SelectedValue);
                connection.Open();
                command.ExecuteNonQuery();
            }
            dataGridHocSInh.DataSource = GetDataFromDatabase();
        }


    }
}