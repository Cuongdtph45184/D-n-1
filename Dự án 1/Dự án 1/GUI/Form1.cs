using Dự_án_1.BLL;
using Dự_án_1.DAL;
using Dự_án_1.GUI;

namespace Dự_án_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tb_mk.PasswordChar = '\0';
            }
            else tb_mk.PasswordChar = '*';
        }
        private void dangnhapClick(object sender, EventArgs e)
        {

        }

        private void bt_dn_Click(object sender, EventArgs e)
        {
            string ussername = tb_tk.Text; string password = tb_mk.Text;
            accountService account = AccountService.CheckLogin(ussername, password);
            if (ussername.Length > 3 && password.ToLower() != password && account != null)
            {
                MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK);
                GiaoDIen giaodien = new GiaoDIen();
                giaodien.Show();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại");
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Đăng_Ký dk = new Đăng_Ký();
            dk.ShowDialog();
        }
    }
}