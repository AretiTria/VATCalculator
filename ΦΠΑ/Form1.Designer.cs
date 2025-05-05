namespace ΦΠΑ
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
            button1 = new Button();
            button2 = new Button();
            lblfinalPrice = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(73, 182);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 0;
            button1.Text = "Καθαρισμός";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnClear_click;
            // 
            // button2
            // 
            button2.Location = new Point(184, 182);
            button2.Name = "button2";
            button2.Size = new Size(108, 30);
            button2.TabIndex = 1;
            button2.Text = "Υπολογισμός";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCalculation_click;
            // 
            // lblfinalPrice
            // 
            lblfinalPrice.AutoSize = true;
            lblfinalPrice.Location = new Point(51, 234);
            lblfinalPrice.Name = "lblfinalPrice";
            lblfinalPrice.Size = new Size(138, 20);
            lblfinalPrice.TabIndex = 2;
            lblfinalPrice.Text = "Η τελική τιμή είναι:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 33);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 3;
            label2.Text = "Τιμή χωρίς ΦΠΑ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 98);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 4;
            label3.Text = "ΦΠΑ%:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(51, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 27);
            textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 284);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblfinalPrice);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label lblfinalPrice;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
