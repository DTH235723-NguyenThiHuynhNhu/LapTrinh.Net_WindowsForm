using MySql.Data.MySqlClient; // Thư viện kết nối MySQL
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient; // Có thể bỏ nếu không dùng

namespace Bai_10
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter daChucVu, daNhanVien;
        DataSet ds = new DataSet("dsQLNV");

        public Form1()
        {
            InitializeComponent();
            dgDSNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDSNhanVien.MultiSelect = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // KẾT NỐI MYSQL
            conn = new MySqlConnection("server=localhost;port=3306;database=qlnv;uid=root;password=Nhu15011507@");

            // ============= LOAD CHỨC VỤ ==================
            daChucVu = new MySqlDataAdapter("SELECT * FROM chucvu", conn);
            daChucVu.Fill(ds, "tblChucVu");

            cboChucVu.DataSource = ds.Tables["tblChucVu"];
            cboChucVu.DisplayMember = "tencv";
            cboChucVu.ValueMember = "macv";

            // ============= LOAD NHÂN VIÊN (BẢNG CHÍNH) =========
            daNhanVien = new MySqlDataAdapter("SELECT * FROM nhanvien", conn);
            daNhanVien.Fill(ds, "tblNhanVien");

            // Set khóa chính → bắt buộc để UPDATE, DELETE
            ds.Tables["tblNhanVien"].PrimaryKey =
                new DataColumn[] { ds.Tables["tblNhanVien"].Columns["manv"] };

            // ============= LOAD BẢNG HIỂN THỊ (JOIN) ==========
            LoadGridView();

            // Hiển thị nhân viên đầu tiên
            if (dgDSNhanVien.Rows.Count > 0)
            {
                DataRowView r = (DataRowView)dgDSNhanVien.Rows[0].DataBoundItem;
                HienThi(r.Row);
            }
        }
        private void LoadGridView()
        {
            string sql =
                @"SELECT n.manv, n.holot, n.tennv, n.phai, n.ngaysinh, c.tencv, n.macv 
                  FROM nhanvien n JOIN chucvu c ON n.macv = c.macv";

            if (ds.Tables.Contains("tblViewNV"))
                ds.Tables["tblViewNV"].Clear();

            new MySqlDataAdapter(sql, conn).Fill(ds, "tblViewNV");

            dgDSNhanVien.DataSource = ds.Tables["tblViewNV"];

            dgDSNhanVien.Columns["manv"].HeaderText = "Mã NV";
            dgDSNhanVien.Columns["holot"].HeaderText = "Họ lót";
            dgDSNhanVien.Columns["tennv"].HeaderText = "Tên";
            dgDSNhanVien.Columns["phai"].HeaderText = "Phái";
            dgDSNhanVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgDSNhanVien.Columns["ngaysinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgDSNhanVien.Columns["tencv"].HeaderText = "Chức vụ";
            dgDSNhanVien.Columns["macv"].Visible = false;
        }
        private void HienThi(DataRow r)
        {
            txtMaSo.Text = r["manv"].ToString();
            txtHoLot.Text = r["holot"].ToString();
            txtTen.Text = r["tennv"].ToString();

            if (r["phai"].ToString() == "Nam") radNam.Checked = true;
            else radNu.Checked = true;

            dtpNgaySinh.Value = Convert.ToDateTime(r["ngaysinh"]);
            cboChucVu.SelectedValue = r["macv"];
        }

        // --- SỬ DỤNG SỰ KIỆN CellClick HOẶC Click ĐỂ CHỌN DÒNG ---
        private void dgDSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRowView r = (DataRowView)dgDSNhanVien.Rows[e.RowIndex].DataBoundItem;
                HienThi(r.Row);
            }
        }
        
        // --- NÚT CHỨC NĂNG ---

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["tblDSNhanVien"].NewRow();
            row["manv"] = txtMaSo.Text; 
            row["holot"] = txtHoLot.Text;
            row["tennv"] = txtTen.Text; // CHÚ Ý SỬA LỖI: Dùng 'tennv'

            if (radNu.Checked == true)
            {
                row["phai"] = "Nữ";
            }
            else
            {
                row["phai"] = "Nam";
            }

            row["ngaysinh"] = dtpNgaySinh.Value;
            row["macv"] = cboChucVu.SelectedValue;
            row["tencv"] = cboChucVu.Text;

            ds.Tables["tblDSNhanVien"].Rows.Add(row);

            MessageBox.Show("Đã thêm nhân viên " + txtMaSo.Text + " vào danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgDSNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataRowView drv = (DataRowView)dgDSNhanVien.SelectedRows[0].DataBoundItem;
                DataRow selectedRow = drv.Row;

                selectedRow.BeginEdit();
                selectedRow["holot"] = txtHoLot.Text;
                selectedRow["tennv"] = txtTen.Text; // CHÚ Ý SỬA LỖI: Dùng 'tennv'
                selectedRow["phai"] = radNam.Checked ? "Nam" : "Nữ";
                selectedRow["ngaysinh"] = dtpNgaySinh.Value;
                selectedRow["macv"] = cboChucVu.SelectedValue;
                selectedRow["tencv"] = cboChucVu.Text;
                selectedRow.EndEdit();

                dgDSNhanVien.Refresh();

                MessageBox.Show("Đã sửa thông tin nhân viên " + txtMaSo.Text + " trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["tblNhanVien"].Rows.Find(txtMaSo.Text);

            if (row == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên để xóa!", "Lỗi");
                return;
            }

            if (MessageBox.Show("Xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                row.Delete();
                MessageBox.Show("Đã xóa!", "Thông báo");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // THAY THẾ SqlCommandBuilder BẰNG MySqlCommandBuilder
                MySqlCommandBuilder cb = new MySqlCommandBuilder(daNhanVien); 
                daNhanVien.Update(ds, "tblDSNhanVien");
                ds.Tables["tblDSNhanVien"].AcceptChanges();
                MessageBox.Show("Đã lưu các thay đổi vào cơ sở dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu vào CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
             ds.Tables["tblNhanVien"].RejectChanges();
            MessageBox.Show("Đã hủy các thay đổi!", "Thông báo");
            LoadGridView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (ds.Tables["tblDSNhanVien"].GetChanges() != null)
            {
                DialogResult dr = MessageBox.Show("Có thay đổi chưa lưu. Bạn có muốn lưu trước khi thoát không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    btnLuu_Click(sender, e);
                    this.Close();
                }
                else if (dr == DialogResult.No)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
        
        // Sự kiện này bị lỗi trong code trước, nên dùng CellClick/Click ở trên
        private void dgDSNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
    }
}