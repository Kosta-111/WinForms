namespace CalorieTracker
{
    partial class NotesForm
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
            add_btn = new Button();
            label1 = new Label();
            product_cb = new ComboBox();
            label2 = new Label();
            weight_tb = new TextBox();
            cancel_btn = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            SuspendLayout();
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.YellowGreen;
            add_btn.Location = new Point(19, 154);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(111, 41);
            add_btn.TabIndex = 1;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 81);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Product";
            // 
            // product_cb
            // 
            product_cb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            product_cb.AutoCompleteMode = AutoCompleteMode.Suggest;
            product_cb.AutoCompleteSource = AutoCompleteSource.ListItems;
            product_cb.FormattingEnabled = true;
            product_cb.Location = new Point(83, 78);
            product_cb.Name = "product_cb";
            product_cb.Size = new Size(234, 23);
            product_cb.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 117);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "Weight";
            // 
            // weight_tb
            // 
            weight_tb.Location = new Point(83, 114);
            weight_tb.Name = "weight_tb";
            weight_tb.Size = new Size(121, 23);
            weight_tb.TabIndex = 5;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.Salmon;
            cancel_btn.Location = new Point(229, 154);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(116, 41);
            cancel_btn.TabIndex = 6;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd.MM.yyyy hh:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(83, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(234, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 36);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Date Time";
            // 
            // NotesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(357, 225);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(cancel_btn);
            Controls.Add(weight_tb);
            Controls.Add(label2);
            Controls.Add(product_cb);
            Controls.Add(label1);
            Controls.Add(add_btn);
            Name = "NotesForm";
            Text = "New note";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button add_btn;
        private Label label1;
        private ComboBox product_cb;
        private Label label2;
        private TextBox weight_tb;
        private Button cancel_btn;
        private DateTimePicker dateTimePicker1;
        private Label label3;
    }
}