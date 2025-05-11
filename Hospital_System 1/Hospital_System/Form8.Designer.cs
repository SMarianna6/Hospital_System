namespace Hospital_System
{
    partial class Form8
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
            listView1 = new ListView();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 109);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 278);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(713, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 18;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(713, 80);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Sort";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 80);
            button3.Name = "button3";
            button3.Size = new Size(55, 23);
            button3.TabIndex = 20;
            button3.Text = "PREV";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(104, 80);
            button4.Name = "button4";
            button4.Size = new Size(55, 23);
            button4.TabIndex = 21;
            button4.Text = "NEXT";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(25, 23);
            textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(89, 399);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(25, 23);
            textBox2.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 402);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 24;
            label2.Text = "Max Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(146, 402);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 25;
            label1.Text = "Min Age";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(219, 399);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(25, 23);
            textBox3.TabIndex = 26;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(listView1);
            Name = "Form8";
            Text = "Admin page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listView1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
    }
}