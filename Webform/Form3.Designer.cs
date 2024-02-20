namespace Webform
{
    partial class Form3
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
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(271, 22);
            label1.Name = "label1";
            label1.Size = new Size(353, 41);
            label1.TabIndex = 0;
            label1.Text = "CHOICE  T-Shirt COLLECTION ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Symbol", 21.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(251, 43);
            label2.TabIndex = 1;
            label2.Text = "T-shirt Quantity";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(255, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(-1, 131);
            label3.Name = "label3";
            label3.Size = new Size(224, 53);
            label3.TabIndex = 3;
            label3.Text = "Choose Size";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 196);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(122, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = " Small Size(Rs.125)";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 234);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(135, 19);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Medium Size(Rs.175)";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(12, 272);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(119, 19);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Large Size(Rs.250)";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(329, 298);
            label4.Name = "label4";
            label4.Size = new Size(171, 63);
            label4.TabIndex = 7;
            label4.Text = "Special offer --";
            // 
            // label5
            // 
            label5.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(58, 347);
            label5.Name = "label5";
            label5.Size = new Size(832, 36);
            label5.TabIndex = 8;
            label5.Text = "Enter Promocode and get 10%Discount(promocode \"TRUEBLUE\")";
            label5.Click += label5_Click;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.MenuHighlight;
            textBox2.Location = new Point(375, 386);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(77, 23);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label6
            // 
            label6.Location = new Point(164, 457);
            label6.Name = "label6";
            label6.Size = new Size(221, 23);
            label6.TabIndex = 10;
            label6.Text = "Applying  9%GST  on Final order  price";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.InfoText;
            button1.Location = new Point(375, 457);
            button1.Name = "button1";
            button1.Size = new Size(99, 23);
            button1.TabIndex = 11;
            button1.Text = "Final Amount";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(492, 457);
            label7.Name = "label7";
            label7.Size = new Size(80, 23);
            label7.TabIndex = 12;
            label7.Text = "0.00";
            label7.Click += label7_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 521);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.MenuHighlight;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private Button button1;
        private Label label7;
    }
}