﻿namespace RSA
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
            textBox7.Location = new Point(147, 378);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(744, 30);
            textBox7.TabIndex = 13;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(147, 431);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(744, 30);
            textBox8.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 381);
            label7.Name = "label7";
            label7.Size = new Size(85, 23);
            label7.TabIndex = 15;
            label7.Text = "Input text";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 434);
            label8.Name = "label8";
            label8.Size = new Size(99, 23);
            label8.TabIndex = 16;
            label8.Text = "Output text";
            // 
            // button2
            // 
            button2.Location = new Point(231, 502);
            button2.Name = "button2";
            button2.Size = new Size(116, 48);
            button2.TabIndex = 17;
            button2.Text = "Encrypt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(418, 502);
            button3.Name = "button3";
            button3.Size = new Size(113, 48);
            button3.TabIndex = 18;
            button3.Text = "Decrypt";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 583);
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
    }
}