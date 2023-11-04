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
            label12 = new Label();
            Horarios_Label = new Label();
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            BackArrow_btn = new Button();
            label2 = new Label();
            panel1 = new Panel();
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
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(30, 106, 167);
            label12.Location = new Point(790, 419);
            label12.Name = "label12";
            label12.Size = new Size(94, 41);
            label12.TabIndex = 61;
            label12.Text = "11:30";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(30, 106, 167);
            label3.Location = new Point(800, 283);
            label3.Name = "label3";
            label3.Size = new Size(71, 41);
            label3.TabIndex = 53;
            label3.Text = "Seg";
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
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(11, 11, 11);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(209, 209, 209);
            textBox1.Location = new Point(114, 131);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(797, 100);
            textBox1.TabIndex = 51;
            textBox1.Text = "Five Nights at Freddy’s";
            textBox1.TextAlign = HorizontalAlignment.Center;
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
            // panel1
            // 
            panel1.Location = new Point(63, 205);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 341);
            panel1.TabIndex = 67;
            // 
            // BuyTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MoviePageBG;
            ClientSize = new Size(1025, 600);
            Controls.Add(panel1);
            Controls.Add(MyTickets_btn);
            Controls.Add(label12);
            Controls.Add(Horarios_Label);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(BackArrow_btn);
            Controls.Add(label2);
            Name = "BuyTickets";
            Text = "BuyTickets";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button MyTickets_btn;
        private Label label12;
        private Label Horarios_Label;
        private Label label3;
        private Label label1;
        private TextBox textBox1;
        private Button BackArrow_btn;
        private Label label2;
        private Panel panel1;
    }
}