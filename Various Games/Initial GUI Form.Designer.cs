namespace Initial_GUI {
    partial class Games_Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.interactiveGamesLabel = new System.Windows.Forms.Label();
            this.selectGameTypeLabel = new System.Windows.Forms.Label();
            this.diceGameRadioBtn = new System.Windows.Forms.RadioButton();
            this.cardGameRadioBtn = new System.Windows.Forms.RadioButton();
            this.startBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // interactiveGamesLabel
            // 
            this.interactiveGamesLabel.AutoSize = true;
            this.interactiveGamesLabel.Location = new System.Drawing.Point(77, 79);
            this.interactiveGamesLabel.Name = "interactiveGamesLabel";
            this.interactiveGamesLabel.Size = new System.Drawing.Size(93, 13);
            this.interactiveGamesLabel.TabIndex = 0;
            this.interactiveGamesLabel.Text = "Interactive Games";
            // 
            // selectGameTypeLabel
            // 
            this.selectGameTypeLabel.AutoSize = true;
            this.selectGameTypeLabel.Location = new System.Drawing.Point(77, 116);
            this.selectGameTypeLabel.Name = "selectGameTypeLabel";
            this.selectGameTypeLabel.Size = new System.Drawing.Size(95, 13);
            this.selectGameTypeLabel.TabIndex = 1;
            this.selectGameTypeLabel.Text = "Select Game Type";
            // 
            // diceGameRadioBtn
            // 
            this.diceGameRadioBtn.AutoSize = true;
            this.diceGameRadioBtn.Location = new System.Drawing.Point(80, 173);
            this.diceGameRadioBtn.Name = "diceGameRadioBtn";
            this.diceGameRadioBtn.Size = new System.Drawing.Size(83, 17);
            this.diceGameRadioBtn.TabIndex = 2;
            this.diceGameRadioBtn.Text = "Dice Games";
            this.diceGameRadioBtn.UseVisualStyleBackColor = true;
            this.diceGameRadioBtn.CheckedChanged += new System.EventHandler(this.diceGameRadioBtn_CheckedChanged);
            // 
            // cardGameRadioBtn
            // 
            this.cardGameRadioBtn.AutoSize = true;
            this.cardGameRadioBtn.Location = new System.Drawing.Point(80, 208);
            this.cardGameRadioBtn.Name = "cardGameRadioBtn";
            this.cardGameRadioBtn.Size = new System.Drawing.Size(78, 17);
            this.cardGameRadioBtn.TabIndex = 3;
            this.cardGameRadioBtn.Text = "Card Game";
            this.cardGameRadioBtn.UseVisualStyleBackColor = true;
            this.cardGameRadioBtn.CheckedChanged += new System.EventHandler(this.diceGameRadioBtn_CheckedChanged);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(62, 253);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(110, 25);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(62, 293);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(110, 25);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Games_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 442);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.cardGameRadioBtn);
            this.Controls.Add(this.diceGameRadioBtn);
            this.Controls.Add(this.selectGameTypeLabel);
            this.Controls.Add(this.interactiveGamesLabel);
            this.Name = "Games_Form";
            this.Text = "Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label interactiveGamesLabel;
        private System.Windows.Forms.Label selectGameTypeLabel;
        private System.Windows.Forms.RadioButton diceGameRadioBtn;
        private System.Windows.Forms.RadioButton cardGameRadioBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

