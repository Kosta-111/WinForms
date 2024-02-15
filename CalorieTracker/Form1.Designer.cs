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
            label1 = new Label();
            label2 = new Label();
            editing_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label1.Location = new Point(195, 9);
            label1.Name = "label1";
            label1.Size = new Size(249, 36);
            label1.TabIndex = 0;
            label1.Text = "Calorie tracker v1.0";
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
            // editing_btn
            // 
            editing_btn.Location = new Point(440, 391);
            editing_btn.Name = "editing_btn";
            editing_btn.Size = new Size(135, 60);
            editing_btn.TabIndex = 2;
            editing_btn.Text = "Add new product";
            editing_btn.UseVisualStyleBackColor = true;
            editing_btn.Click += editing_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(635, 602);
            Controls.Add(editing_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calorie tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button editing_btn;
    }
}
