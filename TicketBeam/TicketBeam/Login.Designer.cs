namespace TicketBeam
{
    partial class Login
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
            Login_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            UsernameInput = new TextBox();
            PasswordInput = new TextBox();
            CreateAccountLink = new LinkLabel();
            SuspendLayout();
            // 
            // Login_btn
            // 
            Login_btn.BackColor = Color.FromArgb(42, 71, 94);
            Login_btn.BackgroundImageLayout = ImageLayout.None;
            Login_btn.FlatAppearance.BorderSize = 0;
            Login_btn.FlatStyle = FlatStyle.Flat;
            Login_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Login_btn.ForeColor = Color.White;
            Login_btn.Location = new Point(425, 409);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(150, 45);
            Login_btn.TabIndex = 2;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = false;
            Login_btn.Click += Login_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(199, 213, 224);
            label1.Location = new Point(457, 195);
            label1.Name = "label1";
            label1.Size = new Size(100, 41);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(235, 271);
            label2.Name = "label2";
            label2.Size = new Size(152, 36);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(242, 335);
            label3.Name = "label3";
            label3.Size = new Size(147, 36);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // UsernameInput
            // 
            UsernameInput.BackColor = Color.FromArgb(42, 71, 94);
            UsernameInput.BorderStyle = BorderStyle.None;
            UsernameInput.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameInput.ForeColor = Color.FromArgb(199, 213, 224);
            UsernameInput.Location = new Point(425, 275);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(356, 39);
            UsernameInput.TabIndex = 0;
            // 
            // PasswordInput
            // 
            PasswordInput.BackColor = Color.FromArgb(42, 71, 94);
            PasswordInput.BorderStyle = BorderStyle.None;
            PasswordInput.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordInput.ForeColor = Color.FromArgb(199, 213, 224);
            PasswordInput.Location = new Point(425, 336);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.Size = new Size(356, 39);
            PasswordInput.TabIndex = 1;
            // 
            // CreateAccountLink
            // 
            CreateAccountLink.ActiveLinkColor = Color.FromArgb(102, 192, 244);
            CreateAccountLink.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CreateAccountLink.AutoSize = true;
            CreateAccountLink.BackColor = Color.Transparent;
            CreateAccountLink.DisabledLinkColor = Color.FromArgb(102, 192, 244);
            CreateAccountLink.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CreateAccountLink.LinkBehavior = LinkBehavior.NeverUnderline;
            CreateAccountLink.LinkColor = Color.FromArgb(102, 192, 244);
            CreateAccountLink.Location = new Point(631, 437);
            CreateAccountLink.Name = "CreateAccountLink";
            CreateAccountLink.Size = new Size(150, 17);
            CreateAccountLink.TabIndex = 3;
            CreateAccountLink.TabStop = true;
            CreateAccountLink.Text = "don’t have an account?";
            CreateAccountLink.TextAlign = ContentAlignment.MiddleRight;
            CreateAccountLink.VisitedLinkColor = Color.FromArgb(102, 192, 244);
            CreateAccountLink.LinkClicked += CreateAccountLink_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LoginBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1025, 600);
            Controls.Add(CreateAccountLink);
            Controls.Add(PasswordInput);
            Controls.Add(UsernameInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Login_btn);
            DoubleBuffered = true;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login_btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UsernameInput;
        private TextBox PasswordInput;
        private LinkLabel CreateAccountLink;
    }
}