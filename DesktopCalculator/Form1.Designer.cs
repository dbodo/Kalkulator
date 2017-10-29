namespace DesktopCalculator
{
    partial class LblResult
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
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.inptFirstNumber = new System.Windows.Forms.NumericUpDown();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.inptSecondNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.inptResult = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inptFirstNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptSecondNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Location = new System.Drawing.Point(16, 30);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(45, 13);
            this.lblFirstNumber.TabIndex = 0;
            this.lblFirstNumber.Text = "Prvi broj";
            // 
            // inptFirstNumber
            // 
            this.inptFirstNumber.Location = new System.Drawing.Point(70, 30);
            this.inptFirstNumber.Name = "inptFirstNumber";
            this.inptFirstNumber.Size = new System.Drawing.Size(90, 20);
            this.inptFirstNumber.TabIndex = 1;
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Location = new System.Drawing.Point(16, 68);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(52, 13);
            this.lblSecondNumber.TabIndex = 2;
            this.lblSecondNumber.Text = "Drugi broj";
            // 
            // inptSecondNumber
            // 
            this.inptSecondNumber.Location = new System.Drawing.Point(70, 66);
            this.inptSecondNumber.Name = "inptSecondNumber";
            this.inptSecondNumber.Size = new System.Drawing.Size(90, 20);
            this.inptSecondNumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rezultat";
            // 
            // inptResult
            // 
            this.inptResult.Location = new System.Drawing.Point(70, 134);
            this.inptResult.Name = "inptResult";
            this.inptResult.Size = new System.Drawing.Size(90, 20);
            this.inptResult.TabIndex = 5;
            this.inptResult.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(197, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "(+) Zbroji";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(197, 62);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(120, 30);
            this.btnSubstract.TabIndex = 7;
            this.btnSubstract.Text = "(-) Oduzmi";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(197, 95);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(120, 30);
            this.btnMultiply.TabIndex = 8;
            this.btnMultiply.Text = "(*) Pomnoži";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(197, 128);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(120, 30);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.Text = "(%) Podijeli";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // LblResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 186);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.inptResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inptSecondNumber);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.inptFirstNumber);
            this.Controls.Add(this.lblFirstNumber);
            this.Name = "LblResult";
            this.Text = "Calculator v1.0";
            this.Load += new System.EventHandler(this.LblResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inptFirstNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptSecondNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.NumericUpDown inptFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.NumericUpDown inptSecondNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inptResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
    }
}

