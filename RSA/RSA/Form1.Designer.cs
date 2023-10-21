namespace RSA
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            button3 = new Button();
            label9 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(716, 48);
            button1.Name = "button1";
            button1.Size = new Size(233, 33);
            button1.TabIndex = 0;
            button1.Text = "Generate prime number";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 25);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 1;
            label1.Text = "Prime number p";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 79);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 2;
            label2.Text = "Prime number q";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(526, 30);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(526, 30);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(150, 135);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(526, 30);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 138);
            label3.Name = "label3";
            label3.Size = new Size(20, 23);
            label3.TabIndex = 6;
            label3.Text = "n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 192);
            label4.Name = "label4";
            label4.Size = new Size(42, 23);
            label4.TabIndex = 7;
            label4.Text = "Ф(n)";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(150, 189);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(526, 30);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(150, 248);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(526, 30);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 252);
            label5.Name = "label5";
            label5.Size = new Size(19, 23);
            label5.TabIndex = 10;
            label5.Text = "e";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(122, 315);
            label6.Name = "label6";
            label6.Size = new Size(20, 23);
            label6.TabIndex = 11;
            label6.Text = "d";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(150, 312);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(526, 30);
            textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(150, 432);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(744, 30);
            textBox7.TabIndex = 13;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(150, 491);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(744, 30);
            textBox8.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 435);
            label7.Name = "label7";
            label7.Size = new Size(85, 23);
            label7.TabIndex = 15;
            label7.Text = "Input text";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 494);
            label8.Name = "label8";
            label8.Size = new Size(99, 23);
            label8.TabIndex = 16;
            label8.Text = "Output text";
            // 
            // button2
            // 
            button2.Location = new Point(229, 550);
            button2.Name = "button2";
            button2.Size = new Size(116, 48);
            button2.TabIndex = 17;
            button2.Text = "Encrypt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(420, 550);
            button3.Name = "button3";
            button3.Size = new Size(113, 48);
            button3.TabIndex = 18;
            button3.Text = "Decrypt";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(229, 378);
            label9.Name = "label9";
            label9.Size = new Size(76, 23);
            label9.TabIndex = 19;
            label9.Text = "Input as:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(311, 348);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 58);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(131, 25);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(91, 27);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "number";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 25);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 27);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "text";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 622);
            Controls.Add(groupBox1);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "RSA - TH1.08";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label5;
        private Label label6;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label7;
        private Label label8;
        private Button button2;
        private Button button3;
        private Label label9;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}