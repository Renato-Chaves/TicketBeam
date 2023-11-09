namespace TicketBeam
{
    partial class BuyTickets
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
            MyTickets_btn = new Button();
            MovieSession = new Label();
            Horarios_Label = new Label();
            MovieDate = new Label();
            label1 = new Label();
            MovieTitle = new TextBox();
            BackArrow_btn = new Button();
            label2 = new Label();
            TicketPanel = new Panel();
            SuspendLayout();
            // 
            // MyTickets_btn
            // 
            MyTickets_btn.BackColor = Color.FromArgb(19, 39, 54);
            MyTickets_btn.BackgroundImageLayout = ImageLayout.None;
            MyTickets_btn.FlatAppearance.BorderSize = 0;
            MyTickets_btn.FlatStyle = FlatStyle.Flat;
            MyTickets_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            MyTickets_btn.ForeColor = Color.White;
            MyTickets_btn.Location = new Point(703, 500);
            MyTickets_btn.Name = "MyTickets_btn";
            MyTickets_btn.Size = new Size(261, 46);
            MyTickets_btn.TabIndex = 0;
            MyTickets_btn.Text = "Comprar Ingressos";
            MyTickets_btn.UseVisualStyleBackColor = false;
            MyTickets_btn.Click += PurchaseTickets;
            // 
            // MovieSession
            // 
            MovieSession.AutoSize = true;
            MovieSession.BackColor = Color.Transparent;
            MovieSession.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            MovieSession.ForeColor = Color.FromArgb(30, 106, 167);
            MovieSession.Location = new Point(790, 419);
            MovieSession.Name = "MovieSession";
            MovieSession.Size = new Size(94, 41);
            MovieSession.TabIndex = 61;
            MovieSession.Text = "11:30";
            // 
            // Horarios_Label
            // 
            Horarios_Label.AutoSize = true;
            Horarios_Label.BackColor = Color.Transparent;
            Horarios_Label.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Horarios_Label.ForeColor = Color.FromArgb(209, 209, 209);
            Horarios_Label.Location = new Point(761, 345);
            Horarios_Label.Name = "Horarios_Label";
            Horarios_Label.Size = new Size(152, 45);
            Horarios_Label.TabIndex = 60;
            Horarios_Label.Text = "Horario:";
            Horarios_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MovieDate
            // 
            MovieDate.AutoSize = true;
            MovieDate.BackColor = Color.Transparent;
            MovieDate.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            MovieDate.ForeColor = Color.FromArgb(30, 106, 167);
            MovieDate.Location = new Point(800, 283);
            MovieDate.Name = "MovieDate";
            MovieDate.Size = new Size(71, 41);
            MovieDate.TabIndex = 53;
            MovieDate.Text = "Seg";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(209, 209, 209);
            label1.Location = new Point(770, 217);
            label1.Name = "label1";
            label1.Size = new Size(134, 45);
            label1.TabIndex = 52;
            label1.Text = "Sessão:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MovieTitle
            // 
            MovieTitle.BackColor = Color.FromArgb(11, 11, 11);
            MovieTitle.BorderStyle = BorderStyle.None;
            MovieTitle.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            MovieTitle.ForeColor = Color.FromArgb(209, 209, 209);
            MovieTitle.Location = new Point(114, 131);
            MovieTitle.Multiline = true;
            MovieTitle.Name = "MovieTitle";
            MovieTitle.ReadOnly = true;
            MovieTitle.Size = new Size(797, 55);
            MovieTitle.TabIndex = 51;
            MovieTitle.Text = "Five Nights at Freddy’s";
            MovieTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // BackArrow_btn
            // 
            BackArrow_btn.BackColor = Color.Transparent;
            BackArrow_btn.BackgroundImage = Properties.Resources.BackArrow;
            BackArrow_btn.BackgroundImageLayout = ImageLayout.Stretch;
            BackArrow_btn.FlatAppearance.BorderSize = 0;
            BackArrow_btn.FlatStyle = FlatStyle.Flat;
            BackArrow_btn.Location = new Point(63, 131);
            BackArrow_btn.Name = "BackArrow_btn";
            BackArrow_btn.Size = new Size(45, 45);
            BackArrow_btn.TabIndex = 1;
            BackArrow_btn.UseVisualStyleBackColor = false;
            BackArrow_btn.Click += BackArrow_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(209, 209, 209);
            label2.Location = new Point(216, 11);
            label2.Name = "label2";
            label2.Size = new Size(581, 45);
            label2.TabIndex = 48;
            label2.Text = "O melhores tickets só encontra aqui";
            // 
            // TicketPanel
            // 
            TicketPanel.BackColor = Color.FromArgb(11, 11, 11);
            TicketPanel.Location = new Point(63, 192);
            TicketPanel.Name = "TicketPanel";
            TicketPanel.Size = new Size(634, 354);
            TicketPanel.TabIndex = 67;
            // 
            // BuyTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MoviePageBG;
            ClientSize = new Size(1025, 600);
            Controls.Add(TicketPanel);
            Controls.Add(MyTickets_btn);
            Controls.Add(MovieSession);
            Controls.Add(Horarios_Label);
            Controls.Add(MovieDate);
            Controls.Add(label1);
            Controls.Add(MovieTitle);
            Controls.Add(BackArrow_btn);
            Controls.Add(label2);
            Name = "BuyTickets";
            Text = "BuyTickets";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button MyTickets_btn;
        private Label MovieSession;
        private Label Horarios_Label;
        private Label MovieDate;
        private Label label1;
        private TextBox MovieTitle;
        private Button BackArrow_btn;
        private Label label2;
        private Panel TicketPanel;
    }
}