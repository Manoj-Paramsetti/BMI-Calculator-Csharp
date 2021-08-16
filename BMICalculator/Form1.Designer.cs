namespace BMICalculator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFeet = new System.Windows.Forms.TextBox();
            this.textBoxPounds = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateStandard = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxInches = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCM = new System.Windows.Forms.TextBox();
            this.textBoxKG = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.calculateMetric = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI Calculator";
            // 
            // textBoxFeet
            // 
            this.textBoxFeet.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFeet.Location = new System.Drawing.Point(104, 87);
            this.textBoxFeet.Name = "textBoxFeet";
            this.textBoxFeet.Size = new System.Drawing.Size(55, 26);
            this.textBoxFeet.TabIndex = 1;
            this.textBoxFeet.TextChanged += new System.EventHandler(this.textBoxFeet_TextChanged);
            // 
            // textBoxPounds
            // 
            this.textBoxPounds.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.textBoxPounds.Location = new System.Drawing.Point(104, 141);
            this.textBoxPounds.Name = "textBoxPounds";
            this.textBoxPounds.Size = new System.Drawing.Size(91, 26);
            this.textBoxPounds.TabIndex = 2;
            this.textBoxPounds.TextChanged += new System.EventHandler(this.textBoxPounds_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Standard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Weight";
            // 
            // calculateStandard
            // 
            this.calculateStandard.Location = new System.Drawing.Point(104, 212);
            this.calculateStandard.Name = "calculateStandard";
            this.calculateStandard.Size = new System.Drawing.Size(75, 23);
            this.calculateStandard.TabIndex = 6;
            this.calculateStandard.Text = "Calculate";
            this.calculateStandard.UseVisualStyleBackColor = true;
            this.calculateStandard.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Metric";
            // 
            // textBoxInches
            // 
            this.textBoxInches.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInches.Location = new System.Drawing.Point(185, 87);
            this.textBoxInches.Name = "textBoxInches";
            this.textBoxInches.Size = new System.Drawing.Size(57, 26);
            this.textBoxInches.TabIndex = 8;
            this.textBoxInches.TextChanged += new System.EventHandler(this.textBoxInches_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Feet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "inches";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "Pounds";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 14);
            this.label9.TabIndex = 12;
            this.label9.Text = "Height";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 14);
            this.label10.TabIndex = 13;
            this.label10.Text = "Weight";
            // 
            // textBoxCM
            // 
            this.textBoxCM.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCM.Location = new System.Drawing.Point(377, 92);
            this.textBoxCM.Name = "textBoxCM";
            this.textBoxCM.Size = new System.Drawing.Size(100, 26);
            this.textBoxCM.TabIndex = 14;
            this.textBoxCM.TextChanged += new System.EventHandler(this.textBoxCM_TextChanged);
            // 
            // textBoxKG
            // 
            this.textBoxKG.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKG.Location = new System.Drawing.Point(377, 141);
            this.textBoxKG.Name = "textBoxKG";
            this.textBoxKG.Size = new System.Drawing.Size(100, 26);
            this.textBoxKG.TabIndex = 16;
            this.textBoxKG.TextChanged += new System.EventHandler(this.textBoxKG_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(483, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 14);
            this.label11.TabIndex = 17;
            this.label11.Text = "Centimeter";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(484, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 14);
            this.label13.TabIndex = 19;
            this.label13.Text = "Kilogram";
            // 
            // calculateMetric
            // 
            this.calculateMetric.Location = new System.Drawing.Point(393, 212);
            this.calculateMetric.Name = "calculateMetric";
            this.calculateMetric.Size = new System.Drawing.Size(75, 23);
            this.calculateMetric.TabIndex = 20;
            this.calculateMetric.Text = "Calculate";
            this.calculateMetric.UseVisualStyleBackColor = true;
            this.calculateMetric.Click += new System.EventHandler(this.calculateMetric_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(76, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 14);
            this.label12.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(393, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 14);
            this.label14.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(607, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 12);
            this.label16.TabIndex = 24;
            this.label16.Text = "BMI Categories";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(600, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 14);
            this.label17.TabIndex = 25;
            this.label17.Text = "Underweight = < 18.5";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(600, 117);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(148, 14);
            this.label18.TabIndex = 26;
            this.label18.Text = "Normal Weight = 18.5-24.9";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(602, 135);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 14);
            this.label19.TabIndex = 27;
            this.label19.Text = "Overweight = 25-29.9";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(603, 153);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 14);
            this.label20.TabIndex = 28;
            this.label20.Text = "Obesity = 30+";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 291);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.calculateMetric);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxKG);
            this.Controls.Add(this.textBoxCM);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxInches);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calculateStandard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPounds);
            this.Controls.Add(this.textBoxFeet);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFeet;
        private System.Windows.Forms.TextBox textBoxPounds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculateStandard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxInches;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCM;
        private System.Windows.Forms.TextBox textBoxKG;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button calculateMetric;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}

