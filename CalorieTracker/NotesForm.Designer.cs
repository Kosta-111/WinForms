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
            note_lb = new ListBox();
            add_btn = new Button();
            label1 = new Label();
            product_cb = new ComboBox();
            label2 = new Label();
            weight_tb = new TextBox();
            cancel_btn = new Button();
            SuspendLayout();
            // 
            // note_lb
            // 
            note_lb.FormattingEnabled = true;
            note_lb.ItemHeight = 15;
            note_lb.Location = new Point(29, 24);
            note_lb.Name = "note_lb";
            note_lb.Size = new Size(455, 139);
            note_lb.TabIndex = 0;
            // 
            // add_btn
            // 
            add_btn.Location = new Point(29, 365);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(111, 47);
            add_btn.TabIndex = 1;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 186);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Product";
            // 
            // product_cb
            // 
            product_cb.FormattingEnabled = true;
            product_cb.Location = new Point(93, 183);
            product_cb.Name = "product_cb";
            product_cb.Size = new Size(121, 23);
            product_cb.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 222);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "Weight";
            // 
            // weight_tb
            // 
            weight_tb.Location = new Point(93, 219);
            weight_tb.Name = "weight_tb";
            weight_tb.Size = new Size(121, 23);
            weight_tb.TabIndex = 5;
            // 
            // cancel_btn
            // 
            cancel_btn.Location = new Point(213, 371);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(116, 41);
            cancel_btn.TabIndex = 6;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // NotesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 450);
            Controls.Add(cancel_btn);
            Controls.Add(weight_tb);
            Controls.Add(label2);
            Controls.Add(product_cb);
            Controls.Add(label1);
            Controls.Add(add_btn);
            Controls.Add(note_lb);
            Name = "NotesForm";
            Text = "NotesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox note_lb;
        private Button add_btn;
        private Label label1;
        private ComboBox product_cb;
        private Label label2;
        private TextBox weight_tb;
        private Button cancel_btn;
    }
}