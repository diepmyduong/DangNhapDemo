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
    public partial class QuanLyNguoiDung : Form
    {
        public QuanLyNguoiDung(Form frmParrent)
        {
            InitializeComponent();
            this.frmParrent = frmParrent;
            listViewColumnReSize(lvUsers);
        }

        private void listViewColumnReSize(ListView lv) 
        {
            int width = lv.Width / 20;
            lv.Columns[0].Width= width * 8;
            lv.Columns[1].Width = width * 8;
            lv.Columns[2].Width = width * 4;
        }

        private void updateListUser()
        {
            users = UserContext.getAll();
            lvUsers.Items.Clear();
            foreach (User user in users)
            {
                lvUsers.Items.Add(new ListViewItem(new[] { user.Username, user.Password,user.CreateAt }));
            }
        }

        private void QuanLyNguoiDung_SizeChanged(object sender, EventArgs e)
        {
            listViewColumnReSize(lvUsers);
        }

        private void menuSignUp_Click(object sender, EventArgs e)
        {
            DangKy frmDangKy = new DangKy(this);
            frmDangKy.StartPosition = FormStartPosition.CenterParent;
            frmDangKy.ShowDialog(this);
            updateListUser();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chứ?", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void QuanLyNguoiDung_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmParrent.Visible = true;
        }
        
        private void QuanLyNguoiDung_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                updateListUser();
            }
        }

        private Form frmParrent;
        private List<User> users;
    }
}
