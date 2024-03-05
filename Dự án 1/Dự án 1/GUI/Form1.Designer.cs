namespace Dự_án_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tb_tk = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tb_mk = new TextBox();
            bt_dn = new Button();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // tb_tk
            // 
            tb_tk.Location = new Point(169, 41);
            tb_tk.Name = "tb_tk";
            tb_tk.Size = new Size(372, 23);
            tb_tk.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(17, 41);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 1;
            label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(17, 91);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 3;
            label2.Text = "Mật Khẩu";
            // 
            // tb_mk
            // 
            tb_mk.Location = new Point(169, 93);
            tb_mk.Name = "tb_mk";
            tb_mk.PasswordChar = '●';
            tb_mk.Size = new Size(372, 23);
            tb_mk.TabIndex = 2;
            // 
            // bt_dn
            // 
            bt_dn.Location = new Point(169, 170);
            bt_dn.Name = "bt_dn";
            bt_dn.Size = new Size(100, 40);
            bt_dn.TabIndex = 4;
            bt_dn.Text = "Đăng Nhập";
            bt_dn.UseVisualStyleBackColor = true;
            bt_dn.Click += bt_dn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(169, 134);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Hiện mật khẩu";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = SystemColors.HotTrack;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.DisabledLinkColor = SystemColors.ButtonHighlight;
            linkLabel1.ForeColor = SystemColors.ButtonHighlight;
            linkLabel1.LinkColor = SystemColors.ButtonHighlight;
            linkLabel1.Location = new Point(169, 217);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(292, 15);
            linkLabel1.TabIndex = 29;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Bạn chưa có tài khoản ? Nhấn vào đây để đăng ký nhé";
            linkLabel1.Click += linkLabel1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(565, 353);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(bt_dn);
            Controls.Add(label2);
            Controls.Add(tb_mk);
            Controls.Add(label1);
            Controls.Add(tb_tk);
            Name = "Form1";
            Text = "Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_tk;
        private Label label1;
        private Label label2;
        private TextBox tb_mk;
        private Button bt_dn;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
    }
}