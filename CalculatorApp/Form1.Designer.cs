namespace CalculatorApp
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            labelResult = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(198, 158);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(395, 158);
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = RightToLeft.No;
            textBox2.Size = new Size(93, 29);
            textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.Location = new Point(329, 162);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.No;
            comboBox1.Size = new Size(46, 23);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Location = new Point(284, 251);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(173, 51);
            button1.TabIndex = 3;
            button1.Text = "Порахувати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.BorderStyle = BorderStyle.Fixed3D;
            labelResult.FlatStyle = FlatStyle.Flat;
            labelResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelResult.Location = new Point(515, 162);
            labelResult.Name = "labelResult";
            labelResult.RightToLeft = RightToLeft.No;
            labelResult.Size = new Size(88, 23);
            labelResult.TabIndex = 4;
            labelResult.Text = "                   ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(494, 165);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 5;
            label1.Text = "=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 402);
            Controls.Add(label1);
            Controls.Add(labelResult);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button button1;
        private Label labelResult;
        private Label label1;
    }
}
