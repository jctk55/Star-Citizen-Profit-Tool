namespace SplitProfitGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalCreditsBox = new System.Windows.Forms.NumericUpDown();
            this.totalPlayersBox = new System.Windows.Forms.NumericUpDown();
            this.ownerCutPercent = new System.Windows.Forms.NumericUpDown();
            this.ownersCutBox = new System.Windows.Forms.NumericUpDown();
            this.playersCutBox = new System.Windows.Forms.NumericUpDown();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.totalCreditsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPlayersBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerCutPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersCutBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersCutBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Credits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Owner Percent Cut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(112, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Owners Cut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(112, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Players Cut";
            // 
            // totalCreditsBox
            // 
            this.totalCreditsBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.totalCreditsBox.Location = new System.Drawing.Point(234, 54);
            this.totalCreditsBox.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.totalCreditsBox.Name = "totalCreditsBox";
            this.totalCreditsBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalCreditsBox.Size = new System.Drawing.Size(158, 27);
            this.totalCreditsBox.TabIndex = 1;
            this.totalCreditsBox.ThousandsSeparator = true;
            // 
            // totalPlayersBox
            // 
            this.totalPlayersBox.Location = new System.Drawing.Point(234, 88);
            this.totalPlayersBox.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.totalPlayersBox.Name = "totalPlayersBox";
            this.totalPlayersBox.Size = new System.Drawing.Size(55, 27);
            this.totalPlayersBox.TabIndex = 2;
            // 
            // ownerCutPercent
            // 
            this.ownerCutPercent.Location = new System.Drawing.Point(234, 121);
            this.ownerCutPercent.Name = "ownerCutPercent";
            this.ownerCutPercent.Size = new System.Drawing.Size(55, 27);
            this.ownerCutPercent.TabIndex = 3;
            this.ownerCutPercent.ThousandsSeparator = true;
            // 
            // ownersCutBox
            // 
            this.ownersCutBox.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ownersCutBox.InterceptArrowKeys = false;
            this.ownersCutBox.Location = new System.Drawing.Point(234, 196);
            this.ownersCutBox.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.ownersCutBox.Name = "ownersCutBox";
            this.ownersCutBox.ReadOnly = true;
            this.ownersCutBox.Size = new System.Drawing.Size(158, 27);
            this.ownersCutBox.TabIndex = 8;
            this.ownersCutBox.TabStop = false;
            this.ownersCutBox.ThousandsSeparator = true;
            // 
            // playersCutBox
            // 
            this.playersCutBox.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.playersCutBox.Location = new System.Drawing.Point(234, 229);
            this.playersCutBox.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.playersCutBox.Name = "playersCutBox";
            this.playersCutBox.ReadOnly = true;
            this.playersCutBox.Size = new System.Drawing.Size(158, 27);
            this.playersCutBox.TabIndex = 9;
            this.playersCutBox.TabStop = false;
            this.playersCutBox.ThousandsSeparator = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(234, 155);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(120, 35);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(419, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(455, 295);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.playersCutBox);
            this.Controls.Add(this.ownersCutBox);
            this.Controls.Add(this.ownerCutPercent);
            this.Controls.Add(this.totalPlayersBox);
            this.Controls.Add(this.totalCreditsBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCSplitProfit";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.totalCreditsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPlayersBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerCutPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersCutBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersCutBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown totalCreditsBox;
        private System.Windows.Forms.NumericUpDown totalPlayersBox;
        private System.Windows.Forms.NumericUpDown ownerCutPercent;
        private System.Windows.Forms.NumericUpDown ownersCutBox;
        private System.Windows.Forms.NumericUpDown playersCutBox;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button button1;

    }
}

