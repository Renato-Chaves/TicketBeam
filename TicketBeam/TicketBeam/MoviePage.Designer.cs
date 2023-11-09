namespace TicketBeam
{
    partial class MoviePage
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
            label2 = new Label();
            MovieCover = new PictureBox();
            BackArrow_btn = new Button();
            MovieTitle = new TextBox();
            label1 = new Label();
            Horarios_Label = new Label();
            BuyTickets_btn = new Button();
            MovieDuration = new TextBox();
            MovieDate1 = new LinkLabel();
            MovieDate2 = new LinkLabel();
            MovieDate3 = new LinkLabel();
            MovieDate4 = new LinkLabel();
            MovieDate5 = new LinkLabel();
            MovieDate6 = new LinkLabel();
            MovieDate7 = new LinkLabel();
            MovieTime1 = new LinkLabel();
            MovieTime2 = new LinkLabel();
            MovieTime3 = new LinkLabel();
            MovieTime4 = new LinkLabel();
            MovieTime5 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)MovieCover).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(209, 209, 209);
            label2.Location = new Point(205, 11);
            label2.Name = "label2";
            label2.Size = new Size(581, 45);
            label2.TabIndex = 4;
            label2.Text = "O melhores tickets só encontra aqui";
            // 
            // MovieCover
            // 
            MovieCover.BackColor = SystemColors.ActiveCaptionText;
            MovieCover.ImageLocation = "";
            MovieCover.InitialImage = Properties.Resources.Logo;
            MovieCover.Location = new Point(52, 213);
            MovieCover.Name = "MovieCover";
            MovieCover.Size = new Size(211, 306);
            MovieCover.SizeMode = PictureBoxSizeMode.StretchImage;
            MovieCover.TabIndex = 10;
            MovieCover.TabStop = false;
            // 
            // BackArrow_btn
            // 
            BackArrow_btn.BackColor = Color.Transparent;
            BackArrow_btn.BackgroundImage = Properties.Resources.BackArrow;
            BackArrow_btn.BackgroundImageLayout = ImageLayout.Stretch;
            BackArrow_btn.FlatAppearance.BorderSize = 0;
            BackArrow_btn.FlatStyle = FlatStyle.Flat;
            BackArrow_btn.Location = new Point(52, 131);
            BackArrow_btn.Name = "BackArrow_btn";
            BackArrow_btn.Size = new Size(45, 45);
            BackArrow_btn.TabIndex = 30;
            BackArrow_btn.UseVisualStyleBackColor = false;
            BackArrow_btn.Click += BackArrow_btn_Click;
            // 
            // MovieTitle
            // 
            MovieTitle.BackColor = Color.FromArgb(11, 11, 11);
            MovieTitle.BorderStyle = BorderStyle.None;
            MovieTitle.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            MovieTitle.ForeColor = Color.FromArgb(209, 209, 209);
            MovieTitle.Location = new Point(269, 131);
            MovieTitle.Multiline = true;
            MovieTitle.Name = "MovieTitle";
            MovieTitle.ReadOnly = true;
            MovieTitle.Size = new Size(684, 45);
            MovieTitle.TabIndex = 31;
            MovieTitle.Text = "Five Nights at Freddy’s";
            MovieTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(209, 209, 209);
            label1.Location = new Point(551, 207);
            label1.Name = "label1";
            label1.Size = new Size(149, 45);
            label1.TabIndex = 32;
            label1.Text = "Sessões:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Horarios_Label
            // 
            Horarios_Label.AutoSize = true;
            Horarios_Label.BackColor = Color.Transparent;
            Horarios_Label.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Horarios_Label.ForeColor = Color.FromArgb(209, 209, 209);
            Horarios_Label.Location = new Point(541, 347);
            Horarios_Label.Name = "Horarios_Label";
            Horarios_Label.Size = new Size(167, 45);
            Horarios_Label.TabIndex = 40;
            Horarios_Label.Text = "Horarios:";
            Horarios_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BuyTickets_btn
            // 
            BuyTickets_btn.BackColor = Color.FromArgb(19, 39, 54);
            BuyTickets_btn.BackgroundImageLayout = ImageLayout.None;
            BuyTickets_btn.FlatAppearance.BorderSize = 0;
            BuyTickets_btn.FlatStyle = FlatStyle.Flat;
            BuyTickets_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BuyTickets_btn.ForeColor = Color.White;
            BuyTickets_btn.Location = new Point(520, 500);
            BuyTickets_btn.Name = "BuyTickets_btn";
            BuyTickets_btn.Size = new Size(201, 46);
            BuyTickets_btn.TabIndex = 46;
            BuyTickets_btn.Text = "Ver Assentos";
            BuyTickets_btn.UseVisualStyleBackColor = false;
            BuyTickets_btn.Click += BuyTickets_btn_Click;
            // 
            // MovieDuration
            // 
            MovieDuration.BackColor = Color.FromArgb(11, 11, 11);
            MovieDuration.BorderStyle = BorderStyle.None;
            MovieDuration.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            MovieDuration.ForeColor = Color.FromArgb(209, 209, 209);
            MovieDuration.Location = new Point(52, 524);
            MovieDuration.Multiline = true;
            MovieDuration.Name = "MovieDuration";
            MovieDuration.ReadOnly = true;
            MovieDuration.Size = new Size(210, 22);
            MovieDuration.TabIndex = 47;
            MovieDuration.Text = "Duração: 2h30";
            MovieDuration.TextAlign = HorizontalAlignment.Center;
            // 
            // MovieDate1
            // 
            MovieDate1.ActiveLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate1.AutoSize = true;
            MovieDate1.BackColor = Color.Transparent;
            MovieDate1.DisabledLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            MovieDate1.ForeColor = Color.FromArgb(209, 209, 209);
            MovieDate1.LinkBehavior = LinkBehavior.AlwaysUnderline;
            MovieDate1.LinkColor = Color.FromArgb(209, 209, 209);
            MovieDate1.LinkVisited = true;
            MovieDate1.Location = new Point(340, 276);
            MovieDate1.Name = "MovieDate1";
            MovieDate1.Size = new Size(64, 37);
            MovieDate1.TabIndex = 48;
            MovieDate1.TabStop = true;
            MovieDate1.Text = "Seg";
            MovieDate1.VisitedLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate1.Click += Date_Click;
            // 
            // MovieDate2
            // 
            MovieDate2.ActiveLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate2.AutoSize = true;
            MovieDate2.BackColor = Color.Transparent;
            MovieDate2.DisabledLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate2.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            MovieDate2.ForeColor = Color.FromArgb(209, 209, 209);
            MovieDate2.LinkBehavior = LinkBehavior.NeverUnderline;
            MovieDate2.LinkColor = Color.FromArgb(209, 209, 209);
            MovieDate2.Location = new Point(432, 276);
            MovieDate2.Name = "MovieDate2";
            MovieDate2.Size = new Size(61, 37);
            MovieDate2.TabIndex = 49;
            MovieDate2.TabStop = true;
            MovieDate2.Text = "Ter";
            MovieDate2.VisitedLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate2.Click += Date_Click;
            // 
            // MovieDate3
            // 
            MovieDate3.ActiveLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate3.AutoSize = true;
            MovieDate3.BackColor = Color.Transparent;
            MovieDate3.DisabledLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate3.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            MovieDate3.ForeColor = Color.FromArgb(209, 209, 209);
            MovieDate3.LinkBehavior = LinkBehavior.NeverUnderline;
            MovieDate3.LinkColor = Color.FromArgb(209, 209, 209);
            MovieDate3.Location = new Point(520, 276);
            MovieDate3.Name = "MovieDate3";
            MovieDate3.Size = new Size(70, 37);
            MovieDate3.TabIndex = 50;
            MovieDate3.TabStop = true;
            MovieDate3.Text = "Qua";
            MovieDate3.VisitedLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate3.Click += Date_Click;
            // 
            // MovieDate4
            // 
            MovieDate4.ActiveLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate4.AutoSize = true;
            MovieDate4.BackColor = Color.Transparent;
            MovieDate4.DisabledLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate4.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            MovieDate4.ForeColor = Color.FromArgb(209, 209, 209);
            MovieDate4.LinkBehavior = LinkBehavior.NeverUnderline;
            MovieDate4.LinkColor = Color.FromArgb(209, 209, 209);
            MovieDate4.Location = new Point(617, 276);
            MovieDate4.Name = "MovieDate4";
            MovieDate4.Size = new Size(63, 37);
            MovieDate4.TabIndex = 51;
            MovieDate4.TabStop = true;
            MovieDate4.Text = "Qui";
            MovieDate4.VisitedLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate4.Click += Date_Click;
            // 
            // MovieDate5
            // 
            MovieDate5.ActiveLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate5.AutoSize = true;
            MovieDate5.BackColor = Color.Transparent;
            MovieDate5.DisabledLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate5.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            MovieDate5.ForeColor = Color.FromArgb(209, 209, 209);
            MovieDate5.LinkBehavior = LinkBehavior.NeverUnderline;
            MovieDate5.LinkColor = Color.FromArgb(209, 209, 209);
            MovieDate5.Location = new Point(701, 276);
            MovieDate5.Name = "MovieDate5";
            MovieDate5.Size = new Size(64, 37);
            MovieDate5.TabIndex = 52;
            MovieDate5.TabStop = true;
            MovieDate5.Text = "Sex";
            MovieDate5.VisitedLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate5.Click += Date_Click;
            // 
            // MovieDate6
            // 
            MovieDate6.ActiveLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate6.AutoSize = true;
            MovieDate6.BackColor = Color.Transparent;
            MovieDate6.DisabledLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate6.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            MovieDate6.ForeColor = Color.FromArgb(209, 209, 209);
            MovieDate6.LinkBehavior = LinkBehavior.NeverUnderline;
            MovieDate6.LinkColor = Color.FromArgb(209, 209, 209);
            MovieDate6.Location = new Point(790, 276);
            MovieDate6.Name = "MovieDate6";
            MovieDate6.Size = new Size(64, 37);
            MovieDate6.TabIndex = 53;
            MovieDate6.TabStop = true;
            MovieDate6.Text = "Sab";
            MovieDate6.VisitedLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate6.Click += Date_Click;
            // 
            // MovieDate7
            // 
            MovieDate7.ActiveLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate7.AutoSize = true;
            MovieDate7.BackColor = Color.Transparent;
            MovieDate7.DisabledLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate7.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            MovieDate7.ForeColor = Color.FromArgb(209, 209, 209);
            MovieDate7.LinkBehavior = LinkBehavior.NeverUnderline;
            MovieDate7.LinkColor = Color.FromArgb(209, 209, 209);
            MovieDate7.Location = new Point(873, 276);
            MovieDate7.Name = "MovieDate7";
            MovieDate7.Size = new Size(80, 37);
            MovieDate7.TabIndex = 54;
            MovieDate7.TabStop = true;
            MovieDate7.Text = "Dom";
            MovieDate7.VisitedLinkColor = Color.FromArgb(30, 106, 167);
            MovieDate7.Click += Date_Click;
            // 
            // MovieTime1
            // 
            MovieTime1.ActiveLinkColor = Color.FromArgb(30, 106, 167);
            MovieTime1.AutoSize = true;
            MovieTime1.BackColor = Color.Transparent;
            MovieTime1.DisabledLinkColor = Color.FromArgb(30, 106, 167);
            MovieTime1.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            MovieTime1.ForeColor = Color.FromArgb(209, 209, 209);
            MovieTime1.LinkBehavior = LinkBehavior.NeverUnderline;
            MovieTime1.LinkColor = Color.FromArgb(209, 209, 209);
            MovieTime1.Location = new Point(366, 420);
            MovieTime1.Name = "MovieTime1";
            MovieTime1.Size = new Size(100, 41);
            MovieTime1.TabIndex = 55;
            MovieTime1.TabStop = true;
            MovieTime1.Text = "08:00";
            MovieTime1.VisitedLinkColor = Color.FromArgb(30, 106, 167);
            MovieTime1.Click += Session_Click;
            // 
            // MovieTime2
            // 
            MovieTime2.ActiveLinkColor = Color.FromArgb(30, 106, 167);
            MovieTime2.AutoSize = true;
            MovieTime2.BackColor = Color.Transparent;
            MovieTime2.DisabledLinkColor = Color.FromArgb(30, 106, 167);
            MovieTime2.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            MovieTime2.ForeColor = Color.FromArgb(209, 209, 209);
            MovieTime2.LinkBehavior = LinkBehavior.AlwaysUnderline;
            MovieTime2.LinkColor = Color.FromArgb(209, 209, 209);
            MovieTime2.LinkVisited = true;
            MovieTime2.Location = new Point(472, 420);
            MovieTime2.Name = "MovieTime2";
            MovieTime2.Size = new Size(94, 41);
            MovieTime2.TabIndex = 56;
            MovieTime2.TabStop = true;
            MovieTime2.Text = "11:30";
            MovieTime2.VisitedLinkColor = Color.FromArgb(30, 106, 167);
            MovieTime2.Click += Session_Click;
            // 
            // MovieTime3
            // 
            MovieTime3.ActiveLinkColor = Color.FromArgb(30, 106, 167);
            MovieTime3.AutoSize = true;
            MovieTime3.BackColor = Color.Transparent;
            MovieTime3.DisabledLinkColor = Color.FromArgb(30, 106, 167);
            MovieTime3.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            MovieTime3.ForeColor = Color.FromArgb(209, 209, 209);
            MovieTime3.LinkBehavior = LinkBehavior.NeverUnderline;
            MovieTime3.LinkColor = Color.FromArgb(209, 209, 209);
            MovieTime3.Location = new Point(572, 420);
            MovieTime3.Name = "MovieTime3";
            MovieTime3.Size = new Size(97, 41);
            MovieTime3.TabIndex = 57;
            MovieTime3.TabStop = true;
            MovieTime3.Text = "19:20";
            MovieTime3.VisitedLinkColor = Color.FromArgb(30, 106, 167);
            MovieTime3.Click += Session_Click;
            // 
            // MovieTime4
            // 
            MovieTime4.ActiveLinkColor = Color.FromArgb(30, 106, 167);
            MovieTime4.AutoSize = true;
            MovieTime4.BackColor = Color.Transparent;
            MovieTime4.DisabledLinkColor = Color.FromArgb(30, 106, 167);
            MovieTime4.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            MovieTime4.ForeColor = Color.FromArgb(209, 209, 209);
            MovieTime4.LinkBehavior = LinkBehavior.NeverUnderline;
            MovieTime4.LinkColor = Color.FromArgb(209, 209, 209);
            MovieTime4.Location = new Point(675, 420);
            MovieTime4.Name = "MovieTime4";
            MovieTime4.Size = new Size(100, 41);
            MovieTime4.TabIndex = 58;
            MovieTime4.TabStop = true;
            MovieTime4.Text = "22:30";
            MovieTime4.VisitedLinkColor = Color.FromArgb(30, 106, 167);
            MovieTime4.Click += Session_Click;
            // 
            // MovieTime5
            // 
            MovieTime5.ActiveLinkColor = Color.FromArgb(30, 106, 167);
            MovieTime5.AutoSize = true;
            MovieTime5.BackColor = Color.Transparent;
            MovieTime5.DisabledLinkColor = Color.FromArgb(30, 106, 167);
            MovieTime5.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            MovieTime5.ForeColor = Color.FromArgb(209, 209, 209);
            MovieTime5.LinkBehavior = LinkBehavior.NeverUnderline;
            MovieTime5.LinkColor = Color.FromArgb(209, 209, 209);
            MovieTime5.Location = new Point(781, 420);
            MovieTime5.Name = "MovieTime5";
            MovieTime5.Size = new Size(100, 41);
            MovieTime5.TabIndex = 59;
            MovieTime5.TabStop = true;
            MovieTime5.Text = "23:99";
            MovieTime5.VisitedLinkColor = Color.FromArgb(30, 106, 167);
            MovieTime5.Click += Session_Click;
            // 
            // MoviePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MoviePageBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1025, 600);
            Controls.Add(MovieTime5);
            Controls.Add(MovieTime4);
            Controls.Add(MovieTime3);
            Controls.Add(MovieTime2);
            Controls.Add(MovieTime1);
            Controls.Add(MovieDate7);
            Controls.Add(MovieDate6);
            Controls.Add(MovieDate5);
            Controls.Add(MovieDate4);
            Controls.Add(MovieDate3);
            Controls.Add(MovieDate2);
            Controls.Add(MovieDate1);
            Controls.Add(MovieDuration);
            Controls.Add(BuyTickets_btn);
            Controls.Add(Horarios_Label);
            Controls.Add(label1);
            Controls.Add(MovieTitle);
            Controls.Add(BackArrow_btn);
            Controls.Add(MovieCover);
            Controls.Add(label2);
            DoubleBuffered = true;
            Name = "MoviePage";
            RightToLeft = RightToLeft.No;
            Text = "MoviePage";
            ((System.ComponentModel.ISupportInitialize)MovieCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox MovieCover;
        private Button BackArrow_btn;
        private TextBox MovieTitle;
        private Label label1;
        private Label Horarios_Label;
        private Button BuyTickets_btn;
        private TextBox MovieDuration;
        private LinkLabel MovieDate1;
        private LinkLabel MovieDate2;
        private LinkLabel MovieDate3;
        private LinkLabel MovieDate4;
        private LinkLabel MovieDate5;
        private LinkLabel MovieDate6;
        private LinkLabel MovieDate7;
        private LinkLabel MovieTime1;
        private LinkLabel MovieTime2;
        private LinkLabel MovieTime3;
        private LinkLabel MovieTime4;
        private LinkLabel MovieTime5;
    }
}