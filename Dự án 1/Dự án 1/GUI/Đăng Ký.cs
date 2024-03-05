using Dự_án_1.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dự_án_1.GUI
{
    public partial class Đăng_Ký : Form
    {
        public Đăng_Ký()
        {
            InitializeComponent();
        }

        private bool Checkemail(string mess)
        {
            return Regex.IsMatch(mess, @"^(?=.*@gmail\.com$|@fpt\.edu\.vn$).*");
        }
        private bool CheckMK(string mess)
        {
            return Regex.IsMatch(mess, @"^(?=.*[A-Z]).+$");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_ten.Text))
            {
                MessageBox.Show("không được để trống tên nhân viên", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(tb_email.Text))
            {
                MessageBox.Show("không được để trống email", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Checkemail(tb_email.Text))
            {
                MessageBox.Show("Email không đúng định dạng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(tb_id.Text))
            {
                MessageBox.Show("không được để trống id", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(tb_username.Text))
            {
                MessageBox.Show("không được để trống tài khoản", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(tb_pass.Text))
            {
                MessageBox.Show("không được để trống mật khẩu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!CheckMK(tb_pass.Text))
            {
                MessageBox.Show("Không đúng định dạng mật khẩu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(tb_checkpass.Text))
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool check = true; // tạo 1 biến check để validate dữ liệu
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox && item.Text == "") // nếu controls là textbox rỗng
                    {

                        MessageBox.Show("Hãy điền đủ thông tin");
                        check = false;
                        break;
                    }
                }
                DialogResult result = MessageBox.Show("Do you want to save ?", "", MessageBoxButtons.YesNoCancel);
                if (check = true && result == DialogResult.Yes)
                {
                    string name = tb_ten.Text;
                    string address = tb_email.Text;
                    string username = tb_username.Text;
                    string password = tb_pass.Text;
                    string id = tb_id.Text;
                    string xnmk = tb_checkpass.Text;

                    accountService ac = new accountService(name, id, address, username, password, xnmk);
                    string accountFile = ac.CreateAccount();
                    File.AppendAllText("account.txt", accountFile);

                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox)
                        { c.Text = ""; }
                    }
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
            }
        }
    }
}
