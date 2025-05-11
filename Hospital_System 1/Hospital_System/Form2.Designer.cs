namespace Hospital_System
{
    partial class Form2
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxName = new TextBox();
            textBoxAge = new TextBox();
            textBoxNumber = new TextBox();
            textBoxDoctorName = new TextBox();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 121);
            label1.Name = "label1";
            label1.Size = new Size(78, 29);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(93, 204);
            label2.Name = "label2";
            label2.Size = new Size(56, 29);
            label2.TabIndex = 1;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 289);
            label3.Name = "label3";
            label3.Size = new Size(94, 29);
            label3.TabIndex = 2;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 361);
            label4.Name = "label4";
            label4.Size = new Size(100, 29);
            label4.TabIndex = 3;
            label4.Text = "Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(470, 121);
            label5.Name = "label5";
            label5.Size = new Size(84, 29);
            label5.TabIndex = 4;
            label5.Text = "Doctor";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(169, 127);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 5;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(169, 212);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(100, 23);
            textBoxAge.TabIndex = 6;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(169, 369);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(100, 23);
            textBoxNumber.TabIndex = 8;
            // 
            // textBoxDoctorName
            // 
            textBoxDoctorName.Location = new Point(577, 127);
            textBoxDoctorName.Name = "textBoxDoctorName";
            textBoxDoctorName.Size = new Size(100, 23);
            textBoxDoctorName.TabIndex = 9;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(470, 308);
            button1.Name = "button1";
            button1.Size = new Size(205, 84);
            button1.TabIndex = 10;
            button1.Text = "CONFIRM";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(713, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(169, 295);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 12;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxDoctorName);
            Controls.Add(textBoxNumber);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Appointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxName;
        private TextBox textBoxAge;
        private TextBox textBoxNumber;
        private TextBox textBoxDoctorName;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
    }
}