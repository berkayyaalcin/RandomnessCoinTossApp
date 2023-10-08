
namespace RandomnessCoinTossApp
{
    partial class MainForm
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
            this.percentNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.percentLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.labelTryNumber1 = new System.Windows.Forms.Label();
            this.labelTryNumber2 = new System.Windows.Forms.Label();
            this.labelTryNumber3 = new System.Windows.Forms.Label();
            this.numericUpDownTryCount1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTryCount2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTryCount3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.percentNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTryCount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTryCount2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTryCount3)).BeginInit();
            this.SuspendLayout();
            // 
            // percentNumUpDown
            // 
            this.percentNumUpDown.Location = new System.Drawing.Point(166, 93);
            this.percentNumUpDown.Name = "percentNumUpDown";
            this.percentNumUpDown.Size = new System.Drawing.Size(74, 22);
            this.percentNumUpDown.TabIndex = 0;
            this.percentNumUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Location = new System.Drawing.Point(10, 95);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(150, 17);
            this.percentLabel.TabIndex = 1;
            this.percentLabel.Text = "Dik Gelme İhtimali (%):";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(13, 140);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(124, 33);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Hesapla";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // labelTryNumber1
            // 
            this.labelTryNumber1.AutoSize = true;
            this.labelTryNumber1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTryNumber1.Location = new System.Drawing.Point(10, 40);
            this.labelTryNumber1.Name = "labelTryNumber1";
            this.labelTryNumber1.Size = new System.Drawing.Size(124, 23);
            this.labelTryNumber1.TabIndex = 4;
            this.labelTryNumber1.Text = "1. Atış Sayısı:";
            // 
            // labelTryNumber2
            // 
            this.labelTryNumber2.AutoSize = true;
            this.labelTryNumber2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTryNumber2.Location = new System.Drawing.Point(290, 40);
            this.labelTryNumber2.Name = "labelTryNumber2";
            this.labelTryNumber2.Size = new System.Drawing.Size(124, 23);
            this.labelTryNumber2.TabIndex = 9;
            this.labelTryNumber2.Text = "2. Atış Sayısı:";
            // 
            // labelTryNumber3
            // 
            this.labelTryNumber3.AutoSize = true;
            this.labelTryNumber3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTryNumber3.Location = new System.Drawing.Point(570, 39);
            this.labelTryNumber3.Name = "labelTryNumber3";
            this.labelTryNumber3.Size = new System.Drawing.Size(124, 23);
            this.labelTryNumber3.TabIndex = 10;
            this.labelTryNumber3.Text = "3. Atış Sayısı:";
            // 
            // numericUpDownTryCount1
            // 
            this.numericUpDownTryCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.numericUpDownTryCount1.Location = new System.Drawing.Point(140, 40);
            this.numericUpDownTryCount1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownTryCount1.Name = "numericUpDownTryCount1";
            this.numericUpDownTryCount1.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownTryCount1.TabIndex = 11;
            this.numericUpDownTryCount1.Tag = "";
            this.numericUpDownTryCount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownTryCount1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownTryCount2
            // 
            this.numericUpDownTryCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.numericUpDownTryCount2.Location = new System.Drawing.Point(420, 40);
            this.numericUpDownTryCount2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownTryCount2.Name = "numericUpDownTryCount2";
            this.numericUpDownTryCount2.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownTryCount2.TabIndex = 12;
            this.numericUpDownTryCount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownTryCount2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownTryCount3
            // 
            this.numericUpDownTryCount3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.numericUpDownTryCount3.Location = new System.Drawing.Point(700, 40);
            this.numericUpDownTryCount3.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownTryCount3.Name = "numericUpDownTryCount3";
            this.numericUpDownTryCount3.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownTryCount3.TabIndex = 13;
            this.numericUpDownTryCount3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownTryCount3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 565);
            this.Controls.Add(this.numericUpDownTryCount3);
            this.Controls.Add(this.numericUpDownTryCount2);
            this.Controls.Add(this.numericUpDownTryCount1);
            this.Controls.Add(this.labelTryNumber3);
            this.Controls.Add(this.labelTryNumber2);
            this.Controls.Add(this.labelTryNumber1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.percentNumUpDown);
            this.Name = "MainForm";
            this.Text = "Randomness Coin Toss";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.percentNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTryCount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTryCount2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTryCount3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown percentNumUpDown;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label labelTryNumber1;
        private System.Windows.Forms.Label labelTryNumber2;
        private System.Windows.Forms.Label labelTryNumber3;
        private System.Windows.Forms.NumericUpDown numericUpDownTryCount1;
        private System.Windows.Forms.NumericUpDown numericUpDownTryCount2;
        private System.Windows.Forms.NumericUpDown numericUpDownTryCount3;
    }
}

