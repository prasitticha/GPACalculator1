namespace GPAxCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxGPA_input = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMinName = new System.Windows.Forms.TextBox();
            this.textBoxMaxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxMinGPA = new System.Windows.Forms.TextBox();
            this.textBoxMaxGPA = new System.Windows.Forms.TextBox();
            this.textBoxGPAx = new System.Windows.Forms.TextBox();
            this.textBoxName_input = new System.Windows.Forms.TextBox();
            this.textBoxAllData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "GPA INPUT";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(596, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxGPA_input
            // 
            this.textBoxGPA_input.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGPA_input.Location = new System.Drawing.Point(451, 24);
            this.textBoxGPA_input.Name = "textBoxGPA_input";
            this.textBoxGPA_input.Size = new System.Drawing.Size(139, 43);
            this.textBoxGPA_input.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxMinName);
            this.groupBox1.Controls.Add(this.textBoxMaxName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBoxMinGPA);
            this.groupBox1.Controls.Add(this.textBoxMaxGPA);
            this.groupBox1.Controls.Add(this.textBoxGPAx);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OUTPUT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(584, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "CLEAR OUTPUT";
            // 
            // textBoxMinName
            // 
            this.textBoxMinName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMinName.Location = new System.Drawing.Point(166, 132);
            this.textBoxMinName.Name = "textBoxMinName";
            this.textBoxMinName.ReadOnly = true;
            this.textBoxMinName.Size = new System.Drawing.Size(267, 43);
            this.textBoxMinName.TabIndex = 10;
            this.textBoxMinName.TabStop = false;
            // 
            // textBoxMaxName
            // 
            this.textBoxMaxName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMaxName.Location = new System.Drawing.Point(166, 83);
            this.textBoxMaxName.Name = "textBoxMaxName";
            this.textBoxMaxName.ReadOnly = true;
            this.textBoxMaxName.Size = new System.Drawing.Size(267, 43);
            this.textBoxMaxName.TabIndex = 9;
            this.textBoxMaxName.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "MAX GPAX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "GPAX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "MIN GPAX";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(584, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 141);
            this.button2.TabIndex = 5;
            this.button2.TabStop = false;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxMinGPA
            // 
            this.textBoxMinGPA.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMinGPA.Location = new System.Drawing.Point(439, 132);
            this.textBoxMinGPA.Name = "textBoxMinGPA";
            this.textBoxMinGPA.ReadOnly = true;
            this.textBoxMinGPA.Size = new System.Drawing.Size(139, 43);
            this.textBoxMinGPA.TabIndex = 4;
            this.textBoxMinGPA.TabStop = false;
            // 
            // textBoxMaxGPA
            // 
            this.textBoxMaxGPA.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMaxGPA.Location = new System.Drawing.Point(439, 83);
            this.textBoxMaxGPA.Name = "textBoxMaxGPA";
            this.textBoxMaxGPA.ReadOnly = true;
            this.textBoxMaxGPA.Size = new System.Drawing.Size(139, 43);
            this.textBoxMaxGPA.TabIndex = 3;
            this.textBoxMaxGPA.TabStop = false;
            // 
            // textBoxGPAx
            // 
            this.textBoxGPAx.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGPAx.Location = new System.Drawing.Point(439, 34);
            this.textBoxGPAx.Name = "textBoxGPAx";
            this.textBoxGPAx.ReadOnly = true;
            this.textBoxGPAx.Size = new System.Drawing.Size(139, 43);
            this.textBoxGPAx.TabIndex = 2;
            this.textBoxGPAx.TabStop = false;
            // 
            // textBoxName_input
            // 
            this.textBoxName_input.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName_input.Location = new System.Drawing.Point(178, 24);
            this.textBoxName_input.Name = "textBoxName_input";
            this.textBoxName_input.Size = new System.Drawing.Size(267, 43);
            this.textBoxName_input.TabIndex = 0;
            // 
            // textBoxAllData
            // 
            this.textBoxAllData.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAllData.Location = new System.Drawing.Point(12, 278);
            this.textBoxAllData.Multiline = true;
            this.textBoxAllData.Name = "textBoxAllData";
            this.textBoxAllData.ReadOnly = true;
            this.textBoxAllData.Size = new System.Drawing.Size(698, 173);
            this.textBoxAllData.TabIndex = 10;
            this.textBoxAllData.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(178, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(451, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "SCORE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "All DATA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(722, 463);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAllData);
            this.Controls.Add(this.textBoxName_input);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxGPA_input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBoxGPA_input;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private TextBox textBoxMinGPA;
        private TextBox textBoxMaxGPA;
        private TextBox textBoxGPAx;
        private TextBox textBoxMinName;
        private TextBox textBoxMaxName;
        private TextBox textBoxName_input;
        private TextBox textBoxAllData;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label8;
    }
}