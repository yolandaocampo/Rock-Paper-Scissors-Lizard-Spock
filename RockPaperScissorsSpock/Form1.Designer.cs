namespace RockPaperScissorsSpock
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnLizard = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnSpock = new System.Windows.Forms.Button();
            this.bntReset = new System.Windows.Forms.Button();
            this.outTextBox = new System.Windows.Forms.TextBox();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.lblTie = new System.Windows.Forms.Label();
            this.winsTextBox = new System.Windows.Forms.TextBox();
            this.lossesTextBox = new System.Windows.Forms.TextBox();
            this.tiesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::RockPaperScissorsSpock.Properties.Resources.game;
            this.pictureBox1.InitialImage = global::RockPaperScissorsSpock.Properties.Resources.game;
            this.pictureBox1.Location = new System.Drawing.Point(327, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("MS PGothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Title.Location = new System.Drawing.Point(144, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(589, 47);
            this.Title.TabIndex = 1;
            this.Title.Text = "Rock Paper Scissors Spock";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRock.Font = new System.Drawing.Font("OCR A Extended", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRock.Location = new System.Drawing.Point(66, 112);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(104, 44);
            this.btnRock.TabIndex = 2;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPaper.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.Location = new System.Drawing.Point(185, 112);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(104, 44);
            this.btnPaper.TabIndex = 3;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnLizard
            // 
            this.btnLizard.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLizard.Location = new System.Drawing.Point(126, 162);
            this.btnLizard.Name = "btnLizard";
            this.btnLizard.Size = new System.Drawing.Size(104, 44);
            this.btnLizard.TabIndex = 5;
            this.btnLizard.Text = "Lizard";
            this.btnLizard.UseVisualStyleBackColor = true;
            this.btnLizard.Click += new System.EventHandler(this.btnLizard_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnScissors.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissors.Location = new System.Drawing.Point(16, 162);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(104, 44);
            this.btnScissors.TabIndex = 4;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = false;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnSpock
            // 
            this.btnSpock.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpock.Location = new System.Drawing.Point(236, 162);
            this.btnSpock.Name = "btnSpock";
            this.btnSpock.Size = new System.Drawing.Size(104, 44);
            this.btnSpock.TabIndex = 6;
            this.btnSpock.Text = "Spock";
            this.btnSpock.UseVisualStyleBackColor = true;
            this.btnSpock.Click += new System.EventHandler(this.btnSpock_Click);
            // 
            // bntReset
            // 
            this.bntReset.Location = new System.Drawing.Point(494, 461);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(171, 39);
            this.bntReset.TabIndex = 7;
            this.bntReset.Text = "Reset";
            this.bntReset.UseVisualStyleBackColor = true;
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click);
            // 
            // outTextBox
            // 
            this.outTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outTextBox.Location = new System.Drawing.Point(109, 285);
            this.outTextBox.Name = "outTextBox";
            this.outTextBox.ReadOnly = true;
            this.outTextBox.Size = new System.Drawing.Size(121, 27);
            this.outTextBox.TabIndex = 8;
            this.outTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(16, 354);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(72, 29);
            this.lblWin.TabIndex = 9;
            this.lblWin.Text = "Wins:";
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLose.Location = new System.Drawing.Point(9, 396);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(84, 29);
            this.lblLose.TabIndex = 10;
            this.lblLose.Text = "Loses:";
            // 
            // lblTie
            // 
            this.lblTie.AutoSize = true;
            this.lblTie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTie.Location = new System.Drawing.Point(21, 440);
            this.lblTie.Name = "lblTie";
            this.lblTie.Size = new System.Drawing.Size(67, 29);
            this.lblTie.TabIndex = 11;
            this.lblTie.Text = "Ties:";
            // 
            // winsTextBox
            // 
            this.winsTextBox.Location = new System.Drawing.Point(96, 358);
            this.winsTextBox.Name = "winsTextBox";
            this.winsTextBox.Size = new System.Drawing.Size(100, 22);
            this.winsTextBox.TabIndex = 12;
            // 
            // lossesTextBox
            // 
            this.lossesTextBox.Location = new System.Drawing.Point(96, 401);
            this.lossesTextBox.Name = "lossesTextBox";
            this.lossesTextBox.Size = new System.Drawing.Size(100, 22);
            this.lossesTextBox.TabIndex = 13;
            // 
            // tiesTextBox
            // 
            this.tiesTextBox.Location = new System.Drawing.Point(96, 447);
            this.tiesTextBox.Name = "tiesTextBox";
            this.tiesTextBox.Size = new System.Drawing.Size(100, 22);
            this.tiesTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "YOU";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tiesTextBox);
            this.Controls.Add(this.lossesTextBox);
            this.Controls.Add(this.winsTextBox);
            this.Controls.Add(this.lblTie);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.outTextBox);
            this.Controls.Add(this.bntReset);
            this.Controls.Add(this.btnSpock);
            this.Controls.Add(this.btnLizard);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "RockPaperScissorsSpock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnLizard;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnSpock;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.TextBox outTextBox;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Label lblTie;
        private System.Windows.Forms.TextBox winsTextBox;
        private System.Windows.Forms.TextBox lossesTextBox;
        private System.Windows.Forms.TextBox tiesTextBox;
        private System.Windows.Forms.Label label1;
    }
}

