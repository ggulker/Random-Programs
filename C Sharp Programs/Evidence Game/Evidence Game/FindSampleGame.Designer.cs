namespace Evidence_Game
{
    partial class FindSampleGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindSampleGame));
            this.StartButton = new System.Windows.Forms.Button();
            this.rowLabel = new System.Windows.Forms.Label();
            this.colLabel = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.rowBox = new System.Windows.Forms.TextBox();
            this.colBox = new System.Windows.Forms.TextBox();
            this.warning = new System.Windows.Forms.Label();
            this.subTitle = new System.Windows.Forms.Label();
            this.quitBut = new System.Windows.Forms.Button();
            this.guessBut = new System.Windows.Forms.Button();
            this.rowNums = new System.Windows.Forms.Label();
            this.colNums = new System.Windows.Forms.Label();
            this.gridForm = new System.Windows.Forms.Label();
            this.exitBut = new System.Windows.Forms.Button();
            this.rules = new System.Windows.Forms.Label();
            this.lastGuess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(558, 432);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(120, 30);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowLabel.Location = new System.Drawing.Point(552, 342);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(69, 27);
            this.rowLabel.TabIndex = 1;
            this.rowLabel.Text = "Row :";
            // 
            // colLabel
            // 
            this.colLabel.AutoSize = true;
            this.colLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLabel.Location = new System.Drawing.Point(521, 382);
            this.colLabel.Name = "colLabel";
            this.colLabel.Size = new System.Drawing.Size(100, 27);
            this.colLabel.TabIndex = 2;
            this.colLabel.Text = "Column :";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(250, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(201, 32);
            this.title.TabIndex = 3;
            this.title.Text = "Evidence Game";
            // 
            // rowBox
            // 
            this.rowBox.Location = new System.Drawing.Point(623, 346);
            this.rowBox.Name = "rowBox";
            this.rowBox.Size = new System.Drawing.Size(50, 22);
            this.rowBox.TabIndex = 4;
            this.rowBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colBox
            // 
            this.colBox.Location = new System.Drawing.Point(623, 387);
            this.colBox.Name = "colBox";
            this.colBox.Size = new System.Drawing.Size(50, 22);
            this.colBox.TabIndex = 5;
            this.colBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Location = new System.Drawing.Point(555, 412);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(118, 17);
            this.warning.TabIndex = 6;
            this.warning.Text = "Max Size = 25x25";
            // 
            // subTitle
            // 
            this.subTitle.AutoSize = true;
            this.subTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitle.Location = new System.Drawing.Point(553, 320);
            this.subTitle.Name = "subTitle";
            this.subTitle.Size = new System.Drawing.Size(120, 23);
            this.subTitle.TabIndex = 7;
            this.subTitle.Text = "choose a size";
            // 
            // quitBut
            // 
            this.quitBut.Location = new System.Drawing.Point(558, 468);
            this.quitBut.Name = "quitBut";
            this.quitBut.Size = new System.Drawing.Size(120, 30);
            this.quitBut.TabIndex = 8;
            this.quitBut.Text = "Quit";
            this.quitBut.UseVisualStyleBackColor = true;
            this.quitBut.Visible = false;
            this.quitBut.Click += new System.EventHandler(this.quitBut_Click);
            // 
            // guessBut
            // 
            this.guessBut.Location = new System.Drawing.Point(557, 432);
            this.guessBut.Name = "guessBut";
            this.guessBut.Size = new System.Drawing.Size(120, 30);
            this.guessBut.TabIndex = 9;
            this.guessBut.Text = "Guess";
            this.guessBut.UseVisualStyleBackColor = true;
            this.guessBut.Visible = false;
            this.guessBut.Click += new System.EventHandler(this.guessBut_Click);
            // 
            // rowNums
            // 
            this.rowNums.AutoSize = true;
            this.rowNums.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowNums.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rowNums.Location = new System.Drawing.Point(40, 45);
            this.rowNums.Name = "rowNums";
            this.rowNums.Size = new System.Drawing.Size(0, 17);
            this.rowNums.TabIndex = 10;
            this.rowNums.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // colNums
            // 
            this.colNums.AutoSize = true;
            this.colNums.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNums.Location = new System.Drawing.Point(10, 62);
            this.colNums.Name = "colNums";
            this.colNums.Size = new System.Drawing.Size(0, 18);
            this.colNums.TabIndex = 11;
            this.colNums.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gridForm
            // 
            this.gridForm.AutoSize = true;
            this.gridForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridForm.Location = new System.Drawing.Point(39, 65);
            this.gridForm.Name = "gridForm";
            this.gridForm.Size = new System.Drawing.Size(0, 18);
            this.gridForm.TabIndex = 12;
            // 
            // exitBut
            // 
            this.exitBut.Location = new System.Drawing.Point(558, 468);
            this.exitBut.Name = "exitBut";
            this.exitBut.Size = new System.Drawing.Size(120, 30);
            this.exitBut.TabIndex = 13;
            this.exitBut.Text = "Exit";
            this.exitBut.UseVisualStyleBackColor = true;
            this.exitBut.Click += new System.EventHandler(this.exitBut_Click);
            // 
            // rules
            // 
            this.rules.AutoSize = true;
            this.rules.Location = new System.Drawing.Point(518, 45);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(224, 255);
            this.rules.TabIndex = 14;
            this.rules.Text = resources.GetString("rules.Text");
            // 
            // lastGuess
            // 
            this.lastGuess.AutoSize = true;
            this.lastGuess.Location = new System.Drawing.Point(518, 503);
            this.lastGuess.Name = "lastGuess";
            this.lastGuess.Size = new System.Drawing.Size(0, 17);
            this.lastGuess.TabIndex = 15;
            // 
            // FindSampleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 549);
            this.Controls.Add(this.lastGuess);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.exitBut);
            this.Controls.Add(this.gridForm);
            this.Controls.Add(this.colNums);
            this.Controls.Add(this.rowNums);
            this.Controls.Add(this.guessBut);
            this.Controls.Add(this.quitBut);
            this.Controls.Add(this.subTitle);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.colBox);
            this.Controls.Add(this.rowBox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.colLabel);
            this.Controls.Add(this.rowLabel);
            this.Controls.Add(this.StartButton);
            this.Name = "FindSampleGame";
            this.Text = "Evidence Game";
            this.Load += new System.EventHandler(this.FindSampleGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label rowLabel;
        private System.Windows.Forms.Label colLabel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox rowBox;
        private System.Windows.Forms.TextBox colBox;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Label subTitle;
        private System.Windows.Forms.Button quitBut;
        private System.Windows.Forms.Button guessBut;
        private System.Windows.Forms.Label rowNums;
        private System.Windows.Forms.Label colNums;
        private System.Windows.Forms.Label gridForm;
        private System.Windows.Forms.Button exitBut;
        private System.Windows.Forms.Label rules;
        private System.Windows.Forms.Label lastGuess;
    }
}

