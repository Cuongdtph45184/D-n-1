namespace Dự_án_1.GUI
{
    partial class Đăng_Ký
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Đăng_Ký));
            tb_ten = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tb_id = new TextBox();
            label3 = new Label();
            tb_email = new TextBox();
            label4 = new Label();
            tb_username = new TextBox();
            label5 = new Label();
            tb_pass = new TextBox();
            label6 = new Label();
            tb_checkpass = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // tb_ten
            // 
            tb_ten.Location = new Point(219, 33);
            tb_ten.Name = "tb_ten";
            tb_ten.Size = new Size(402, 23);
            tb_ten.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 33);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "Họ Và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 78);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(219, 79);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(402, 23);
            tb_id.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 128);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // tb_email
            // 
            tb_email.Location = new Point(219, 125);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(402, 23);
            tb_email.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 178);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 7;
            label4.Text = "Tên Đăng Nhập";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(219, 175);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(402, 23);
            tb_username.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 225);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 9;
            label5.Text = "Mật Khẩu";
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(219, 222);
            tb_pass.Name = "tb_pass";
            tb_pass.Size = new Size(402, 23);
            tb_pass.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(19, 269);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 11;
            label6.Text = "Xác Nhận Mật Khẩu";
            // 
            // tb_checkpass
            // 
            tb_checkpass.Location = new Point(219, 269);
            tb_checkpass.Name = "tb_checkpass";
            tb_checkpass.Size = new Size(402, 23);
            tb_checkpass.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(301, 328);
            button1.Name = "button1";
            button1.Size = new Size(155, 36);
            button1.TabIndex = 12;
            button1.Text = "Đăng Ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Đăng_Ký
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(tb_checkpass);
            Controls.Add(label5);
            Controls.Add(tb_pass);
            Controls.Add(label4);
            Controls.Add(tb_username);
            Controls.Add(label3);
            Controls.Add(tb_email);
            Controls.Add(label2);
            Controls.Add(tb_id);
            Controls.Add(label1);
            Controls.Add(tb_ten);
            Name = "Đăng_Ký";
            Text = "Đăng_Ký";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_ten;
        private Label label1;
        private Label label2;
        private TextBox tb_id;
        private Label label3;
        private TextBox tb_email;
        private Label label4;
        private TextBox tb_username;
        private Label label5;
        private TextBox tb_pass;
        private Label label6;
        private TextBox tb_checkpass;
        private Button button1;
    }
}