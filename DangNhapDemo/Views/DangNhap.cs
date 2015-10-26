using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Biz;
using Core.Dal;

namespace DangNhapDemo
{
    public partial class DangNhap : Form
    {

        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Kiểm tra điều kiện nhập
            if (String.IsNullOrEmpty(txbUsername.Text) || String.IsNullOrEmpty(txbPassword.Text))
            {
                MessageBox.Show("Chưa đủ thông tin...");
                return;
            }
            //Tìm kiếm người dùng
            user = UserContext.find(txbUsername.Text);
            //Nếu người dùng không tồn tại
            if(user == null)
            {
                MessageBox.Show("Người dùng không tồn tại");
                return;
            }
            //Đăng nhập
            if (user.login(txbPassword.Text))
            {
                //Nếu đăng nhập thành công
                this.Hide();
                QuanLyNguoiDung frmQuanlyNguoiDung = new QuanLyNguoiDung(this);
                frmQuanlyNguoiDung.StartPosition = FormStartPosition.CenterScreen;
                frmQuanlyNguoiDung.Show();
                
            }
            else
            {
                MessageBox.Show("Mật khẩu không đúng");
                return;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
            DangKy frmDangKy = new DangKy(this);
            frmDangKy.StartPosition = FormStartPosition.CenterParent;
            frmDangKy.ShowDialog(this);
            
        }

       
        private User user;

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
