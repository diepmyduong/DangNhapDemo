using Core.Biz;
using Core.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhapDemo
{
    public partial class DangKy : Form
    {
        public DangKy(Form frmParrent)
        {
            InitializeComponent();
            this.frmParrent = frmParrent;
            txbUsername.Focus();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txbUsername.Text) && !String.IsNullOrEmpty(txbPassword.Text) && !String.IsNullOrEmpty(txbVerifyPass.Text))
            {
                //Nếu các giá trị không rỗng
                //Kiểm tra lại mật khẩu
                if(!txbPassword.Text.Equals(txbVerifyPass.Text))
                {
                    MessageBox.Show("Mật khẩu chưa khớp");
                    return;
                }
                //Tìm kiếm user 
                user = UserContext.find(txbUsername.Text);
                //Nếu người dùng tốn tại
                if(user != null)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                    return;
                }
                //Tạo user
                user = new User() { Username = txbUsername.Text, Password = txbPassword.Text };
                if (UserContext.save(user)!=0)
                {
                    MessageBox.Show("Đăng ký thành công");
                    this.Hide();
                    return;
                }
                MessageBox.Show("Đăng ký thất bại");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbUsername.Text = "";
            txbPassword.Text = "";
            txbVerifyPass.Text = "";
            txbUsername.Focus();
        }
        private void DangKy_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmParrent.Visible = true;
        }
        private Form frmParrent;
        private User user;
    }
}
