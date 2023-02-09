namespace WinformsCalc
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Calc = new System.Windows.Forms.Button();
            this.inputBox1 = new System.Windows.Forms.NumericUpDown();
            this.inputBox2 = new System.Windows.Forms.NumericUpDown();
            this.addBox = new System.Windows.Forms.NumericUpDown();
            this.subBox = new System.Windows.Forms.NumericUpDown();
            this.multBox = new System.Windows.Forms.NumericUpDown();
            this.divBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inputBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type two numbers, then click Calc to see the results!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Addition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Subtraction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Multiplication";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(602, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Division";
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(323, 254);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(75, 23);
            this.Calc.TabIndex = 11;
            this.Calc.Text = "Calc";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // inputBox1
            // 
            this.inputBox1.DecimalPlaces = 3;
            this.inputBox1.Location = new System.Drawing.Point(151, 73);
            this.inputBox1.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.inputBox1.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(120, 22);
            this.inputBox1.TabIndex = 13;
            // 
            // inputBox2
            // 
            this.inputBox2.DecimalPlaces = 3;
            this.inputBox2.Location = new System.Drawing.Point(411, 72);
            this.inputBox2.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.inputBox2.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.inputBox2.Name = "inputBox2";
            this.inputBox2.Size = new System.Drawing.Size(120, 22);
            this.inputBox2.TabIndex = 14;
            // 
            // addBox
            // 
            this.addBox.DecimalPlaces = 3;
            this.addBox.InterceptArrowKeys = false;
            this.addBox.Location = new System.Drawing.Point(60, 343);
            this.addBox.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.addBox.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.addBox.Name = "addBox";
            this.addBox.ReadOnly = true;
            this.addBox.Size = new System.Drawing.Size(120, 22);
            this.addBox.TabIndex = 15;
            // 
            // subBox
            // 
            this.subBox.DecimalPlaces = 3;
            this.subBox.Location = new System.Drawing.Point(222, 343);
            this.subBox.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.subBox.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.subBox.Name = "subBox";
            this.subBox.ReadOnly = true;
            this.subBox.Size = new System.Drawing.Size(120, 22);
            this.subBox.TabIndex = 16;
            // 
            // multBox
            // 
            this.multBox.DecimalPlaces = 3;
            this.multBox.Location = new System.Drawing.Point(411, 342);
            this.multBox.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.multBox.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.multBox.Name = "multBox";
            this.multBox.ReadOnly = true;
            this.multBox.Size = new System.Drawing.Size(120, 22);
            this.multBox.TabIndex = 17;
            // 
            // divBox
            // 
            this.divBox.DecimalPlaces = 3;
            this.divBox.Location = new System.Drawing.Point(605, 342);
            this.divBox.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.divBox.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.divBox.Name = "divBox";
            this.divBox.ReadOnly = true;
            this.divBox.Size = new System.Drawing.Size(120, 22);
            this.divBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 423);
            this.Controls.Add(this.divBox);
            this.Controls.Add(this.multBox);
            this.Controls.Add(this.subBox);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.inputBox2);
            this.Controls.Add(this.inputBox1);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inputBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.NumericUpDown inputBox1;
        private System.Windows.Forms.NumericUpDown inputBox2;
        private System.Windows.Forms.NumericUpDown addBox;
        private System.Windows.Forms.NumericUpDown multBox;
        private System.Windows.Forms.NumericUpDown divBox;
        public System.Windows.Forms.NumericUpDown subBox;
    }
}

