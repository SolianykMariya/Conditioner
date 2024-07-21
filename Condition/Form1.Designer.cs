namespace Condition
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
            panel1 = new Panel();
            button7 = new Button();
            label4 = new Label();
            panel4 = new Panel();
            textBox3 = new TextBox();
            button6 = new Button();
            button5 = new Button();
            panel3 = new Panel();
            textBox2 = new TextBox();
            label3 = new Label();
            button4 = new Button();
            button3 = new Button();
            label2 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            panel1.Location = new Point(12, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(758, 347);
            panel1.TabIndex = 0;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.GradientActiveCaption;
            button7.Location = new Point(277, 245);
            button7.Name = "button7";
            button7.Size = new Size(209, 91);
            button7.TabIndex = 9;
            button7.Text = "Змінити режим";
            button7.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(531, 230);
            label4.Name = "label4";
            label4.Size = new Size(182, 24);
            label4.TabIndex = 8;
            label4.Text = "відкритість жалюзів";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientActiveCaption;
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(button5);
            panel4.Location = new Point(531, 257);
            panel4.Name = "panel4";
            panel4.Size = new Size(194, 66);
            panel4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(64, 13);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(67, 40);
            textBox3.TabIndex = 3;
            // 
            // button6
            // 
            button6.Location = new Point(3, 15);
            button6.Name = "button6";
            button6.Size = new Size(42, 37);
            button6.TabIndex = 2;
            button6.Text = "-";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(149, 16);
            button5.Name = "button5";
            button5.Size = new Size(42, 37);
            button5.TabIndex = 1;
            button5.Text = "+";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(18, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(722, 100);
            panel3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(46, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(647, 40);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 0;
            label3.Text = "типу жалюзі";
            // 
            // button4
            // 
            button4.Location = new Point(663, 14);
            button4.Name = "button4";
            button4.Size = new Size(77, 45);
            button4.TabIndex = 4;
            button4.Text = "Off";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(564, 14);
            button3.Name = "button3";
            button3.Size = new Size(71, 45);
            button3.TabIndex = 3;
            button3.Text = "On";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 230);
            label2.Name = "label2";
            label2.Size = new Size(120, 24);
            label2.TabIndex = 2;
            label2.Text = "температура";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(15, 257);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 66);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(67, 40);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(0, 26);
            button2.Name = "button2";
            button2.Size = new Size(42, 37);
            button2.TabIndex = 1;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(153, 26);
            button1.Name = "button1";
            button1.Size = new Size(42, 37);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 13);
            label1.Name = "label1";
            label1.Size = new Size(258, 34);
            label1.TabIndex = 0;
            label1.Text = "КОНДИЦІОНЕР";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Label label2;
        private Button button3;
        private Button button4;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Button button6;
        private Button button5;
        private Button button7;
    }
}
