namespace TicketBeam
{
    partial class Register
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
            haveAccountLink = new LinkLabel();
            PasswordInput = new TextBox();
            UsernameInput = new TextBox();
            Password_Label = new Label();
            Username_Label = new Label();
            Register_Label = new Label();
            Register_btn = new Button();
            PasswordConfirmInput = new TextBox();
            Password2_Label = new Label();
            SuspendLayout();
            // 
            // haveAccountLink
            // 
            haveAccountLink.ActiveLinkColor = Color.FromArgb(102, 192, 244);
            haveAccountLink.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            haveAccountLink.AutoSize = true;
            haveAccountLink.BackColor = Color.Transparent;
            haveAccountLink.DisabledLinkColor = Color.FromArgb(102, 192, 244);
            haveAccountLink.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            haveAccountLink.LinkBehavior = LinkBehavior.NeverUnderline;
            haveAccountLink.LinkColor = Color.FromArgb(102, 192, 244);
            haveAccountLink.Location = new Point(666, 494);
            haveAccountLink.Name = "haveAccountLink";
            haveAccountLink.Size = new Size(113, 17);
            haveAccountLink.TabIndex = 4;
            haveAccountLink.TabStop = true;
            haveAccountLink.Text = "have an account?";
            haveAccountLink.TextAlign = ContentAlignment.MiddleRight;
            haveAccountLink.VisitedLinkColor = Color.FromArgb(102, 192, 244);
            haveAccountLink.LinkClicked += Login_LinkClicked;
            // 
            // PasswordInput
            // 
            PasswordInput.BackColor = Color.FromArgb(42, 71, 94);
            PasswordInput.BorderStyle = BorderStyle.None;
            PasswordInput.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordInput.ForeColor = Color.FromArgb(199, 213, 224);
            PasswordInput.Location = new Point(423, 335);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.Size = new Size(356, 39);
            PasswordInput.TabIndex = 1;
            // 
            // UsernameInput
            // 
            UsernameInput.BackColor = Color.FromArgb(42, 71, 94);
            UsernameInput.BorderStyle = BorderStyle.None;
            UsernameInput.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameInput.ForeColor = Color.FromArgb(199, 213, 224);
            UsernameInput.Location = new Point(423, 267);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(356, 39);
            UsernameInput.TabIndex = 0;
            // 
            // Password_Label
            // 
            Password_Label.AutoSize = true;
            Password_Label.BackColor = Color.Transparent;
            Password_Label.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold, GraphicsUnit.Point);
            Password_Label.ForeColor = Color.White;
            Password_Label.Location = new Point(245, 331);
            Password_Label.Name = "Password_Label";
            Password_Label.Size = new Size(147, 36);
            Password_Label.TabIndex = 10;
            Password_Label.Text = "Password:";
            // 
            // Username_Label
            // 
            Username_Label.AutoSize = true;
            Username_Label.BackColor = Color.Transparent;
            Username_Label.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold, GraphicsUnit.Point);
            Username_Label.ForeColor = Color.White;
            Username_Label.Location = new Point(240, 272);
            Username_Label.Name = "Username_Label";
            Username_Label.Size = new Size(152, 36);
            Username_Label.TabIndex = 9;
            Username_Label.Text = "Username:";
            // 
            // Register_Label
            // 
            Register_Label.AutoSize = true;
            Register_Label.BackColor = Color.Transparent;
            Register_Label.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Register_Label.ForeColor = Color.FromArgb(199, 213, 224);
            Register_Label.Location = new Point(466, 201);
            Register_Label.Name = "Register_Label";
            Register_Label.Size = new Size(136, 40);
            Register_Label.TabIndex = 8;
            Register_Label.Text = "Register";
            // 
            // Register_btn
            // 
            Register_btn.BackColor = Color.FromArgb(42, 71, 94);
            Register_btn.BackgroundImageLayout = ImageLayout.None;
            Register_btn.FlatAppearance.BorderSize = 0;
            Register_btn.FlatStyle = FlatStyle.Flat;
            Register_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Register_btn.ForeColor = Color.White;
            Register_btn.Location = new Point(423, 466);
            Register_btn.Name = "Register_btn";
            Register_btn.Size = new Size(209, 45);
            Register_btn.TabIndex = 3;
            Register_btn.Text = "Create Account";
            Register_btn.UseVisualStyleBackColor = false;
            // 
            // PasswordConfirmInput
            // 
            PasswordConfirmInput.BackColor = Color.FromArgb(42, 71, 94);
            PasswordConfirmInput.BorderStyle = BorderStyle.None;
            PasswordConfirmInput.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordConfirmInput.ForeColor = Color.FromArgb(199, 213, 224);
            PasswordConfirmInput.Location = new Point(423, 402);
            PasswordConfirmInput.Name = "PasswordConfirmInput";
            PasswordConfirmInput.PasswordChar = '*';
            PasswordConfirmInput.Size = new Size(356, 39);
            PasswordConfirmInput.TabIndex = 2;
            // 
            // Password2_Label
            // 
            Password2_Label.AutoSize = true;
            Password2_Label.BackColor = Color.Transparent;
            Password2_Label.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold, GraphicsUnit.Point);
            Password2_Label.ForeColor = Color.White;
            Password2_Label.Location = new Point(245, 376);
            Password2_Label.Name = "Password2_Label";
            Password2_Label.Size = new Size(147, 72);
            Password2_Label.TabIndex = 14;
            Password2_Label.Text = "Re-Enter\r\nPassword:";
            Password2_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RegisterBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1025, 600);
            Controls.Add(PasswordConfirmInput);
            Controls.Add(Password2_Label);
            Controls.Add(haveAccountLink);
            Controls.Add(PasswordInput);
            Controls.Add(UsernameInput);
            Controls.Add(Password_Label);
            Controls.Add(Username_Label);
            Controls.Add(Register_Label);
            Controls.Add(Register_btn);
            DoubleBuffered = true;
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel haveAccountLink;
        private TextBox PasswordInput;
        private TextBox UsernameInput;
        private Label Password_Label;
        private Label Username_Label;
        private Label Register_Label;
        private Button Register_btn;
        private TextBox PasswordConfirmInput;
        private Label Password2_Label;
    }
}