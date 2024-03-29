﻿namespace CalorieTracker
{
    partial class ProductsForm
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
            Edit_btn = new Button();
            Add_Btn = new Button();
            name_tb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Prot_tb = new TextBox();
            fat_tb = new TextBox();
            Carb_tb = new TextBox();
            Calo_tb = new TextBox();
            label6 = new Label();
            Catgr_cb = new ComboBox();
            dlt_btn = new Button();
            Exit_btn = new Button();
            product_lb = new ListBox();
            SuspendLayout();
            // 
            // Edit_btn
            // 
            Edit_btn.BackColor = Color.LightSkyBlue;
            Edit_btn.Location = new Point(229, 464);
            Edit_btn.Name = "Edit_btn";
            Edit_btn.Size = new Size(65, 30);
            Edit_btn.TabIndex = 1;
            Edit_btn.Text = "Edit";
            Edit_btn.UseVisualStyleBackColor = false;
            Edit_btn.Click += Edit_btn_Click;
            // 
            // Add_Btn
            // 
            Add_Btn.BackColor = Color.DarkKhaki;
            Add_Btn.Location = new Point(12, 464);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.Size = new Size(65, 30);
            Add_Btn.TabIndex = 2;
            Add_Btn.Text = "Add";
            Add_Btn.UseVisualStyleBackColor = false;
            Add_Btn.Click += Add_Btn_Click;
            // 
            // name_tb
            // 
            name_tb.Location = new Point(158, 235);
            name_tb.Name = "name_tb";
            name_tb.Size = new Size(100, 23);
            name_tb.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 243);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 284);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 5;
            label2.Text = "Proteins";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 323);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 6;
            label3.Text = "Fats";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 362);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 7;
            label4.Text = "Carbohydrates";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 398);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 8;
            label5.Text = "Calories";
            // 
            // Prot_tb
            // 
            Prot_tb.Location = new Point(158, 276);
            Prot_tb.Name = "Prot_tb";
            Prot_tb.Size = new Size(100, 23);
            Prot_tb.TabIndex = 9;
            // 
            // fat_tb
            // 
            fat_tb.Location = new Point(158, 320);
            fat_tb.Name = "fat_tb";
            fat_tb.Size = new Size(100, 23);
            fat_tb.TabIndex = 10;
            // 
            // Carb_tb
            // 
            Carb_tb.Location = new Point(158, 354);
            Carb_tb.Name = "Carb_tb";
            Carb_tb.Size = new Size(100, 23);
            Carb_tb.TabIndex = 11;
            // 
            // Calo_tb
            // 
            Calo_tb.Location = new Point(158, 390);
            Calo_tb.Name = "Calo_tb";
            Calo_tb.Size = new Size(100, 23);
            Calo_tb.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 435);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 13;
            label6.Text = "Category";
            // 
            // Catgr_cb
            // 
            Catgr_cb.FormattingEnabled = true;
            Catgr_cb.Location = new Point(158, 427);
            Catgr_cb.Name = "Catgr_cb";
            Catgr_cb.Size = new Size(100, 23);
            Catgr_cb.TabIndex = 14;
            // 
            // dlt_btn
            // 
            dlt_btn.BackColor = Color.Coral;
            dlt_btn.Location = new Point(124, 464);
            dlt_btn.Name = "dlt_btn";
            dlt_btn.Size = new Size(65, 30);
            dlt_btn.TabIndex = 15;
            dlt_btn.Text = "Delete";
            dlt_btn.UseVisualStyleBackColor = false;
            dlt_btn.Click += dlt_btn_Click;
            // 
            // Exit_btn
            // 
            Exit_btn.BackColor = Color.Violet;
            Exit_btn.Location = new Point(327, 464);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(94, 30);
            Exit_btn.TabIndex = 16;
            Exit_btn.Text = "Save and Exit";
            Exit_btn.UseVisualStyleBackColor = false;
            Exit_btn.Click += Cnl_Btn_Click;
            // 
            // product_lb
            // 
            product_lb.FormattingEnabled = true;
            product_lb.ItemHeight = 15;
            product_lb.Location = new Point(12, 17);
            product_lb.Name = "product_lb";
            product_lb.Size = new Size(536, 214);
            product_lb.Sorted = true;
            product_lb.TabIndex = 17;
            product_lb.SelectedIndexChanged += product_lb_SelectedIndexChanged;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(560, 506);
            Controls.Add(product_lb);
            Controls.Add(Exit_btn);
            Controls.Add(dlt_btn);
            Controls.Add(Catgr_cb);
            Controls.Add(label6);
            Controls.Add(Calo_tb);
            Controls.Add(Carb_tb);
            Controls.Add(fat_tb);
            Controls.Add(Prot_tb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(name_tb);
            Controls.Add(Add_Btn);
            Controls.Add(Edit_btn);
            Name = "ProductsForm";
            Text = "Products";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Edit_btn;
        private Button Add_Btn;
        private TextBox name_tb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Prot_tb;
        private TextBox fat_tb;
        private TextBox Carb_tb;
        private TextBox Calo_tb;
        private Label label6;
        private ComboBox Catgr_cb;
        private Button dlt_btn;
        private Button Exit_btn;
        private ListBox product_lb;
    }
}