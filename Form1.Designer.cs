﻿namespace CalculadoraWinApps
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
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(171, 71);
            button1.Name = "button1";
            button1.Size = new Size(101, 23);
            button1.TabIndex = 0;
            button1.Text = "Soma";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAdd_Click;
            // 
            // button2
            // 
            button2.Location = new Point(171, 126);
            button2.Name = "button2";
            button2.Size = new Size(101, 23);
            button2.TabIndex = 1;
            button2.Text = "Subtração";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSubtract_Click;
            // 
            // button3
            // 
            button3.Location = new Point(171, 178);
            button3.Name = "button3";
            button3.Size = new Size(101, 23);
            button3.TabIndex = 2;
            button3.Text = "Multiplicação";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnMultiply_Click;
            // 
            // button4
            // 
            button4.Location = new Point(171, 226);
            button4.Name = "button4";
            button4.Size = new Size(101, 23);
            button4.TabIndex = 3;
            button4.Text = "Divisão";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnDivide_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(289, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 275);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
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
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}