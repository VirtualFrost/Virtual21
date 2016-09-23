namespace VirtualTwentyOne
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.balanceLbl = new System.Windows.Forms.Label();
            this.balanceValueLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hitBtn = new System.Windows.Forms.Button();
            this.standBtn = new System.Windows.Forms.Button();
            this.playerHandLbl = new System.Windows.Forms.Label();
            this.betLbl = new System.Windows.Forms.Label();
            this.betValueLbl = new System.Windows.Forms.Label();
            this.valueOneBtn = new System.Windows.Forms.Button();
            this.valueFiveBtn = new System.Windows.Forms.Button();
            this.valueTenBtn = new System.Windows.Forms.Button();
            this.valueTwentyBtn = new System.Windows.Forms.Button();
            this.valueFiftyBtn = new System.Windows.Forms.Button();
            this.valueHundredBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.compHandLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.balanceLbl.Location = new System.Drawing.Point(12, 9);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(84, 20);
            this.balanceLbl.TabIndex = 0;
            this.balanceLbl.Text = "Balance: $";
            // 
            // balanceValueLbl
            // 
            this.balanceValueLbl.AutoSize = true;
            this.balanceValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceValueLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.balanceValueLbl.Location = new System.Drawing.Point(91, 9);
            this.balanceValueLbl.Name = "balanceValueLbl";
            this.balanceValueLbl.Size = new System.Drawing.Size(18, 20);
            this.balanceValueLbl.TabIndex = 1;
            this.balanceValueLbl.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VirtualTwentyOne.Properties.Resources.blackjack_table;
            this.pictureBox1.Location = new System.Drawing.Point(16, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // hitBtn
            // 
            this.hitBtn.Location = new System.Drawing.Point(663, 29);
            this.hitBtn.Name = "hitBtn";
            this.hitBtn.Size = new System.Drawing.Size(128, 37);
            this.hitBtn.TabIndex = 3;
            this.hitBtn.Text = "Hit";
            this.hitBtn.UseVisualStyleBackColor = true;
            this.hitBtn.Click += new System.EventHandler(this.hitBtn_Click);
            // 
            // standBtn
            // 
            this.standBtn.Location = new System.Drawing.Point(663, 72);
            this.standBtn.Name = "standBtn";
            this.standBtn.Size = new System.Drawing.Size(128, 37);
            this.standBtn.TabIndex = 4;
            this.standBtn.Text = "Stand";
            this.standBtn.UseVisualStyleBackColor = true;
            this.standBtn.Click += new System.EventHandler(this.standBtn_Click);
            // 
            // playerHandLbl
            // 
            this.playerHandLbl.AutoSize = true;
            this.playerHandLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(98)))), ((int)(((byte)(2)))));
            this.playerHandLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHandLbl.ForeColor = System.Drawing.Color.White;
            this.playerHandLbl.Location = new System.Drawing.Point(352, 258);
            this.playerHandLbl.Name = "playerHandLbl";
            this.playerHandLbl.Size = new System.Drawing.Size(24, 25);
            this.playerHandLbl.TabIndex = 5;
            this.playerHandLbl.Text = "0";
            // 
            // betLbl
            // 
            this.betLbl.AutoSize = true;
            this.betLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betLbl.ForeColor = System.Drawing.Color.White;
            this.betLbl.Location = new System.Drawing.Point(659, 157);
            this.betLbl.Name = "betLbl";
            this.betLbl.Size = new System.Drawing.Size(51, 20);
            this.betLbl.TabIndex = 6;
            this.betLbl.Text = "Bet: $";
            // 
            // betValueLbl
            // 
            this.betValueLbl.AutoSize = true;
            this.betValueLbl.BackColor = System.Drawing.Color.Maroon;
            this.betValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betValueLbl.ForeColor = System.Drawing.Color.Yellow;
            this.betValueLbl.Location = new System.Drawing.Point(706, 157);
            this.betValueLbl.Name = "betValueLbl";
            this.betValueLbl.Size = new System.Drawing.Size(18, 20);
            this.betValueLbl.TabIndex = 7;
            this.betValueLbl.Text = "0";
            // 
            // valueOneBtn
            // 
            this.valueOneBtn.Location = new System.Drawing.Point(663, 234);
            this.valueOneBtn.Name = "valueOneBtn";
            this.valueOneBtn.Size = new System.Drawing.Size(61, 23);
            this.valueOneBtn.TabIndex = 8;
            this.valueOneBtn.Text = "+1";
            this.valueOneBtn.UseVisualStyleBackColor = true;
            this.valueOneBtn.Click += new System.EventHandler(this.valueOneBtn_Click);
            // 
            // valueFiveBtn
            // 
            this.valueFiveBtn.Location = new System.Drawing.Point(730, 234);
            this.valueFiveBtn.Name = "valueFiveBtn";
            this.valueFiveBtn.Size = new System.Drawing.Size(61, 23);
            this.valueFiveBtn.TabIndex = 9;
            this.valueFiveBtn.Text = "+5";
            this.valueFiveBtn.UseVisualStyleBackColor = true;
            this.valueFiveBtn.Click += new System.EventHandler(this.valueFiveBtn_Click);
            // 
            // valueTenBtn
            // 
            this.valueTenBtn.Location = new System.Drawing.Point(663, 263);
            this.valueTenBtn.Name = "valueTenBtn";
            this.valueTenBtn.Size = new System.Drawing.Size(61, 23);
            this.valueTenBtn.TabIndex = 10;
            this.valueTenBtn.Text = "+10";
            this.valueTenBtn.UseVisualStyleBackColor = true;
            this.valueTenBtn.Click += new System.EventHandler(this.valueTenBtn_Click);
            // 
            // valueTwentyBtn
            // 
            this.valueTwentyBtn.Location = new System.Drawing.Point(730, 263);
            this.valueTwentyBtn.Name = "valueTwentyBtn";
            this.valueTwentyBtn.Size = new System.Drawing.Size(61, 23);
            this.valueTwentyBtn.TabIndex = 11;
            this.valueTwentyBtn.Text = "+20";
            this.valueTwentyBtn.UseVisualStyleBackColor = true;
            this.valueTwentyBtn.Click += new System.EventHandler(this.valueTwentyBtn_Click);
            // 
            // valueFiftyBtn
            // 
            this.valueFiftyBtn.Location = new System.Drawing.Point(663, 292);
            this.valueFiftyBtn.Name = "valueFiftyBtn";
            this.valueFiftyBtn.Size = new System.Drawing.Size(61, 23);
            this.valueFiftyBtn.TabIndex = 12;
            this.valueFiftyBtn.Text = "+50";
            this.valueFiftyBtn.UseVisualStyleBackColor = true;
            this.valueFiftyBtn.Click += new System.EventHandler(this.valueFiftyBtn_Click);
            // 
            // valueHundredBtn
            // 
            this.valueHundredBtn.Location = new System.Drawing.Point(730, 292);
            this.valueHundredBtn.Name = "valueHundredBtn";
            this.valueHundredBtn.Size = new System.Drawing.Size(61, 23);
            this.valueHundredBtn.TabIndex = 13;
            this.valueHundredBtn.Text = "+100";
            this.valueHundredBtn.UseVisualStyleBackColor = true;
            this.valueHundredBtn.Click += new System.EventHandler(this.valueHundredBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(663, 321);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(128, 23);
            this.resetBtn.TabIndex = 14;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(663, 192);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(128, 36);
            this.startBtn.TabIndex = 15;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // compHandLbl
            // 
            this.compHandLbl.AutoSize = true;
            this.compHandLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(98)))), ((int)(((byte)(2)))));
            this.compHandLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compHandLbl.ForeColor = System.Drawing.Color.White;
            this.compHandLbl.Location = new System.Drawing.Point(316, 62);
            this.compHandLbl.Name = "compHandLbl";
            this.compHandLbl.Size = new System.Drawing.Size(24, 25);
            this.compHandLbl.TabIndex = 16;
            this.compHandLbl.Text = "0";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 349);
            this.Controls.Add(this.compHandLbl);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.valueHundredBtn);
            this.Controls.Add(this.valueFiftyBtn);
            this.Controls.Add(this.valueTwentyBtn);
            this.Controls.Add(this.valueTenBtn);
            this.Controls.Add(this.valueFiveBtn);
            this.Controls.Add(this.valueOneBtn);
            this.Controls.Add(this.betValueLbl);
            this.Controls.Add(this.betLbl);
            this.Controls.Add(this.playerHandLbl);
            this.Controls.Add(this.standBtn);
            this.Controls.Add(this.hitBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.balanceValueLbl);
            this.Controls.Add(this.balanceLbl);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMain";
            this.Text = "Virtual21 - Blackjack Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Label balanceValueLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button hitBtn;
        private System.Windows.Forms.Button standBtn;
        private System.Windows.Forms.Label playerHandLbl;
        private System.Windows.Forms.Label betLbl;
        private System.Windows.Forms.Label betValueLbl;
        private System.Windows.Forms.Button valueOneBtn;
        private System.Windows.Forms.Button valueFiveBtn;
        private System.Windows.Forms.Button valueTenBtn;
        private System.Windows.Forms.Button valueTwentyBtn;
        private System.Windows.Forms.Button valueFiftyBtn;
        private System.Windows.Forms.Button valueHundredBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label compHandLbl;
    }
}

