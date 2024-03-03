namespace CalorieTracker
{
    partial class SettingsForm
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
            label1 = new Label();
            proteins_Tb = new TextBox();
            fats_Tb = new TextBox();
            label2 = new Label();
            carbohydrates_Tb = new TextBox();
            label3 = new Label();
            calories_Tb = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 30);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Proteins";
            // 
            // proteins_Tb
            // 
            proteins_Tb.Location = new Point(124, 27);
            proteins_Tb.Name = "proteins_Tb";
            proteins_Tb.Size = new Size(100, 23);
            proteins_Tb.TabIndex = 1;
            proteins_Tb.Text = "0";
            // 
            // fats_Tb
            // 
            fats_Tb.Location = new Point(124, 76);
            fats_Tb.Name = "fats_Tb";
            fats_Tb.Size = new Size(100, 23);
            fats_Tb.TabIndex = 3;
            fats_Tb.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 79);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "Fats";
            // 
            // carbohydrates_Tb
            // 
            carbohydrates_Tb.Location = new Point(124, 119);
            carbohydrates_Tb.Name = "carbohydrates_Tb";
            carbohydrates_Tb.Size = new Size(100, 23);
            carbohydrates_Tb.TabIndex = 5;
            carbohydrates_Tb.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 122);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 4;
            label3.Text = "Carbohydrates";
            // 
            // calories_Tb
            // 
            calories_Tb.Location = new Point(124, 169);
            calories_Tb.Name = "calories_Tb";
            calories_Tb.Size = new Size(100, 23);
            calories_Tb.TabIndex = 7;
            calories_Tb.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 172);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Calories";
            // 
            // button1
            // 
            button1.Location = new Point(101, 228);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 286);
            Controls.Add(button1);
            Controls.Add(calories_Tb);
            Controls.Add(label4);
            Controls.Add(carbohydrates_Tb);
            Controls.Add(label3);
            Controls.Add(fats_Tb);
            Controls.Add(label2);
            Controls.Add(proteins_Tb);
            Controls.Add(label1);
            Name = "SettingsForm";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox proteins_Tb;
        private TextBox fats_Tb;
        private Label label2;
        private TextBox carbohydrates_Tb;
        private Label label3;
        private TextBox calories_Tb;
        private Label label4;
        private Button button1;
    }
}