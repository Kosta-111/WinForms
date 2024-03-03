namespace CalorieTracker
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
            label1 = new Label();
            label2 = new Label();
            products_btn = new Button();
            note_btn = new Button();
            dataGridView1 = new DataGridView();
            period_Cb = new ComboBox();
            protein_Pb = new ProgressBar();
            settings = new PictureBox();
            label3 = new Label();
            prot_Lb = new Label();
            fat_Lb = new Label();
            label5 = new Label();
            fat_Pb = new ProgressBar();
            carb_Lb = new Label();
            label7 = new Label();
            carbohydrates_Pb = new ProgressBar();
            calor_Lb = new Label();
            label8 = new Label();
            calories_Pb = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settings).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label1.Location = new Point(232, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 36);
            label1.TabIndex = 0;
            label1.Text = "Calorie tracker";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 587);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 1;
            label2.Text = "© 2024 Team B, IT Step";
            // 
            // products_btn
            // 
            products_btn.BackColor = Color.Plum;
            products_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            products_btn.Location = new Point(161, 474);
            products_btn.Name = "products_btn";
            products_btn.Size = new Size(135, 52);
            products_btn.TabIndex = 2;
            products_btn.Text = "Products editor";
            products_btn.UseVisualStyleBackColor = false;
            products_btn.Click += Product_btn_Click;
            // 
            // note_btn
            // 
            note_btn.BackColor = Color.SpringGreen;
            note_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            note_btn.Location = new Point(14, 474);
            note_btn.Name = "note_btn";
            note_btn.Size = new Size(119, 52);
            note_btn.TabIndex = 3;
            note_btn.Text = "Add note";
            note_btn.UseVisualStyleBackColor = false;
            note_btn.Click += Note_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(736, 323);
            dataGridView1.TabIndex = 4;
            // 
            // period_Cb
            // 
            period_Cb.DropDownStyle = ComboBoxStyle.DropDownList;
            period_Cb.FormattingEnabled = true;
            period_Cb.Items.AddRange(new object[] { "Today", "Week", "Month", "All" });
            period_Cb.Location = new Point(175, 412);
            period_Cb.Name = "period_Cb";
            period_Cb.Size = new Size(121, 23);
            period_Cb.TabIndex = 6;
            period_Cb.SelectedIndexChanged += period_Cb_SelectedIndexChanged;
            // 
            // protein_Pb
            // 
            protein_Pb.Location = new Point(436, 410);
            protein_Pb.Name = "protein_Pb";
            protein_Pb.Size = new Size(235, 23);
            protein_Pb.Step = 1;
            protein_Pb.TabIndex = 7;
            // 
            // settings
            // 
            settings.Image = (Image)resources.GetObject("settings.Image");
            settings.Location = new Point(709, 9);
            settings.Name = "settings";
            settings.Size = new Size(39, 36);
            settings.SizeMode = PictureBoxSizeMode.StretchImage;
            settings.TabIndex = 8;
            settings.TabStop = false;
            settings.Click += Settings_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(380, 413);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 9;
            label3.Text = "Proteins";
            // 
            // prot_Lb
            // 
            prot_Lb.AutoSize = true;
            prot_Lb.Location = new Point(677, 415);
            prot_Lb.Name = "prot_Lb";
            prot_Lb.Size = new Size(24, 15);
            prot_Lb.TabIndex = 10;
            prot_Lb.Text = "0/0";
            // 
            // fat_Lb
            // 
            fat_Lb.AutoSize = true;
            fat_Lb.Location = new Point(677, 462);
            fat_Lb.Name = "fat_Lb";
            fat_Lb.Size = new Size(24, 15);
            fat_Lb.TabIndex = 13;
            fat_Lb.Text = "0/0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(402, 460);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 12;
            label5.Text = "Fats";
            // 
            // fat_Pb
            // 
            fat_Pb.Location = new Point(436, 457);
            fat_Pb.Name = "fat_Pb";
            fat_Pb.Size = new Size(235, 23);
            fat_Pb.Step = 1;
            fat_Pb.TabIndex = 11;
            // 
            // carb_Lb
            // 
            carb_Lb.AutoSize = true;
            carb_Lb.Location = new Point(677, 506);
            carb_Lb.Name = "carb_Lb";
            carb_Lb.Size = new Size(24, 15);
            carb_Lb.TabIndex = 16;
            carb_Lb.Text = "0/0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(346, 504);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 15;
            label7.Text = "Carbohydrates";
            // 
            // carbohydrates_Pb
            // 
            carbohydrates_Pb.Location = new Point(436, 501);
            carbohydrates_Pb.Name = "carbohydrates_Pb";
            carbohydrates_Pb.Size = new Size(235, 23);
            carbohydrates_Pb.Step = 1;
            carbohydrates_Pb.TabIndex = 14;
            // 
            // calor_Lb
            // 
            calor_Lb.AutoSize = true;
            calor_Lb.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            calor_Lb.Location = new Point(677, 556);
            calor_Lb.Name = "calor_Lb";
            calor_Lb.Size = new Size(26, 15);
            calor_Lb.TabIndex = 19;
            calor_Lb.Text = "0/0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(380, 554);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 18;
            label8.Text = "Calories";
            // 
            // calories_Pb
            // 
            calories_Pb.Location = new Point(436, 551);
            calories_Pb.Name = "calories_Pb";
            calories_Pb.Size = new Size(235, 23);
            calories_Pb.Step = 1;
            calories_Pb.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(758, 602);
            Controls.Add(calor_Lb);
            Controls.Add(label8);
            Controls.Add(calories_Pb);
            Controls.Add(carb_Lb);
            Controls.Add(label7);
            Controls.Add(carbohydrates_Pb);
            Controls.Add(fat_Lb);
            Controls.Add(label5);
            Controls.Add(fat_Pb);
            Controls.Add(prot_Lb);
            Controls.Add(label3);
            Controls.Add(settings);
            Controls.Add(protein_Pb);
            Controls.Add(period_Cb);
            Controls.Add(dataGridView1);
            Controls.Add(note_btn);
            Controls.Add(products_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calorie tracker v1.0";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)settings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button products_btn;
        private Button note_btn;
        private DataGridView dataGridView1;
        private ComboBox period_Cb;
        private ProgressBar protein_Pb;
        private PictureBox settings;
        private Label label3;
        private Label prot_Lb;
        private Label fat_Lb;
        private Label label5;
        private ProgressBar fat_Pb;
        private Label carb_Lb;
        private Label label7;
        private ProgressBar carbohydrates_Pb;
        private Label calor_Lb;
        private Label label8;
        private ProgressBar calories_Pb;
    }
}
