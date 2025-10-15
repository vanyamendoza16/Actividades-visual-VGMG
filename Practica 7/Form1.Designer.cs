namespace Practica_7
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 255);
            label1.Location = new Point(62, 30);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "\"Ingresa Valor\"";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Location = new Point(89, 69);
            button1.Name = "button1";
            button1.Size = new Size(214, 29);
            button1.TabIndex = 2;
            button1.Text = "Celsius a Fahrenheit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 192);
            button2.Location = new Point(89, 104);
            button2.Name = "button2";
            button2.Size = new Size(214, 29);
            button2.TabIndex = 3;
            button2.Text = "Fahrenheit a Celsius";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 192);
            button3.Location = new Point(89, 139);
            button3.Name = "button3";
            button3.Size = new Size(214, 29);
            button3.TabIndex = 4;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 255, 255);
            label2.Location = new Point(123, 181);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 5;
            label2.Text = "Resultado en grados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(38, 227);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 6;
            label3.Text = "Equivalente en grados";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 224);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Conversion de Temperaturas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
    }
}
