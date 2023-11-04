namespace TicketBeam
{
    partial class MainPage
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
            LeftArrow_btn = new Button();
            RightArrow_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            MyTickets_btn = new Button();
            MovieCover1 = new PictureBox();
            MovieCover2 = new PictureBox();
            MovieCover4 = new PictureBox();
            MovieCover3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)MovieCover1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MovieCover2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MovieCover4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MovieCover3).BeginInit();
            SuspendLayout();
            // 
            // LeftArrow_btn
            // 
            LeftArrow_btn.BackColor = Color.Transparent;
            LeftArrow_btn.BackgroundImage = Properties.Resources.LeftArrow;
            LeftArrow_btn.FlatAppearance.BorderSize = 0;
            LeftArrow_btn.FlatStyle = FlatStyle.Flat;
            LeftArrow_btn.Location = new Point(58, 349);
            LeftArrow_btn.Name = "LeftArrow_btn";
            LeftArrow_btn.Size = new Size(40, 40);
            LeftArrow_btn.TabIndex = 0;
            LeftArrow_btn.UseVisualStyleBackColor = false;
            // 
            // RightArrow_btn
            // 
            RightArrow_btn.BackColor = Color.Transparent;
            RightArrow_btn.BackgroundImage = Properties.Resources.RightArrow;
            RightArrow_btn.FlatAppearance.BorderSize = 0;
            RightArrow_btn.FlatStyle = FlatStyle.Flat;
            RightArrow_btn.Location = new Point(932, 349);
            RightArrow_btn.Name = "RightArrow_btn";
            RightArrow_btn.Size = new Size(40, 40);
            RightArrow_btn.TabIndex = 1;
            RightArrow_btn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(209, 209, 209);
            label1.Location = new Point(335, 138);
            label1.Name = "label1";
            label1.Size = new Size(339, 51);
            label1.TabIndex = 2;
            label1.Text = "Filmes em Cartaz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(209, 209, 209);
            label2.Location = new Point(130, 9);
            label2.Name = "label2";
            label2.Size = new Size(581, 45);
            label2.TabIndex = 3;
            label2.Text = "O melhores tickets só encontra aqui";
            // 
            // MyTickets_btn
            // 
            MyTickets_btn.BackColor = Color.FromArgb(19, 39, 54);
            MyTickets_btn.BackgroundImageLayout = ImageLayout.None;
            MyTickets_btn.FlatAppearance.BorderSize = 0;
            MyTickets_btn.FlatStyle = FlatStyle.Flat;
            MyTickets_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            MyTickets_btn.ForeColor = Color.White;
            MyTickets_btn.Location = new Point(766, 11);
            MyTickets_btn.Name = "MyTickets_btn";
            MyTickets_btn.Size = new Size(201, 46);
            MyTickets_btn.TabIndex = 8;
            MyTickets_btn.Text = "Meus Ingressos";
            MyTickets_btn.UseVisualStyleBackColor = false;
            MyTickets_btn.Click += MyTickets_btn_Click;
            // 
            // MovieCover1
            // 
            MovieCover1.BackColor = SystemColors.ActiveCaptionText;
            MovieCover1.ImageLocation = "https://www.saltypopcorn.co.uk/film-images/five-nights-at-freddys.jpg";
            MovieCover1.InitialImage = Properties.Resources.Logo;
            MovieCover1.Location = new Point(117, 238);
            MovieCover1.Name = "MovieCover1";
            MovieCover1.Size = new Size(181, 266);
            MovieCover1.SizeMode = PictureBoxSizeMode.StretchImage;
            MovieCover1.TabIndex = 9;
            MovieCover1.TabStop = false;
            MovieCover1.Click += MovieCover_Click;
            // 
            // MovieCover2
            // 
            MovieCover2.BackColor = SystemColors.ActiveCaptionText;
            MovieCover2.ImageLocation = "https://www.saltypopcorn.co.uk/film-images/five-nights-at-freddys.jpg";
            MovieCover2.InitialImage = Properties.Resources.Logo;
            MovieCover2.Location = new Point(321, 238);
            MovieCover2.Name = "MovieCover2";
            MovieCover2.Size = new Size(181, 266);
            MovieCover2.SizeMode = PictureBoxSizeMode.StretchImage;
            MovieCover2.TabIndex = 10;
            MovieCover2.TabStop = false;
            MovieCover2.Click += MovieCover_Click;
            // 
            // MovieCover4
            // 
            MovieCover4.BackColor = SystemColors.ActiveCaptionText;
            MovieCover4.ImageLocation = "https://www.saltypopcorn.co.uk/film-images/five-nights-at-freddys.jpg";
            MovieCover4.InitialImage = Properties.Resources.Logo;
            MovieCover4.Location = new Point(729, 238);
            MovieCover4.Name = "MovieCover4";
            MovieCover4.Size = new Size(181, 266);
            MovieCover4.SizeMode = PictureBoxSizeMode.StretchImage;
            MovieCover4.TabIndex = 12;
            MovieCover4.TabStop = false;
            MovieCover4.Click += MovieCover_Click;
            // 
            // MovieCover3
            // 
            MovieCover3.BackColor = SystemColors.ActiveCaptionText;
            MovieCover3.ImageLocation = "https://www.saltypopcorn.co.uk/film-images/five-nights-at-freddys.jpg";
            MovieCover3.InitialImage = Properties.Resources.Logo;
            MovieCover3.Location = new Point(525, 238);
            MovieCover3.Name = "MovieCover3";
            MovieCover3.Size = new Size(181, 266);
            MovieCover3.SizeMode = PictureBoxSizeMode.StretchImage;
            MovieCover3.TabIndex = 11;
            MovieCover3.TabStop = false;
            MovieCover3.Click += MovieCover_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MainPageBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1025, 600);
            Controls.Add(MovieCover4);
            Controls.Add(MovieCover3);
            Controls.Add(MovieCover2);
            Controls.Add(MovieCover1);
            Controls.Add(MyTickets_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RightArrow_btn);
            Controls.Add(LeftArrow_btn);
            DoubleBuffered = true;
            Name = "MainPage";
            Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)MovieCover1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MovieCover2).EndInit();
            ((System.ComponentModel.ISupportInitialize)MovieCover4).EndInit();
            ((System.ComponentModel.ISupportInitialize)MovieCover3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LeftArrow_btn;
        private Button RightArrow_btn;
        private Label label1;
        private Label label2;
        private Button MyTickets_btn;
        private PictureBox MovieCover1;
        private PictureBox MovieCover2;
        private PictureBox MovieCover4;
        private PictureBox MovieCover3;
    }
}