namespace HangmanDefinition
{
    partial class HangmanDefinition
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
            this.labelAvailableWords = new System.Windows.Forms.Label();
            this.checkBoxRemovePreviousWords = new System.Windows.Forms.CheckBox();
            this.buttonNextWord = new System.Windows.Forms.Button();
            this.labelGuessesLeft = new System.Windows.Forms.Label();
            this.labelDefinition = new System.Windows.Forms.Label();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAvailableWords
            // 
            this.labelAvailableWords.AutoSize = true;
            this.labelAvailableWords.BackColor = System.Drawing.SystemColors.Control;
            this.labelAvailableWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableWords.Location = new System.Drawing.Point(351, 6);
            this.labelAvailableWords.Name = "labelAvailableWords";
            this.labelAvailableWords.Size = new System.Drawing.Size(93, 13);
            this.labelAvailableWords.TabIndex = 9;
            this.labelAvailableWords.Text = "Available words: 0";
            // 
            // checkBoxRemovePreviousWords
            // 
            this.checkBoxRemovePreviousWords.AutoSize = true;
            this.checkBoxRemovePreviousWords.Checked = true;
            this.checkBoxRemovePreviousWords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRemovePreviousWords.Location = new System.Drawing.Point(648, 7);
            this.checkBoxRemovePreviousWords.Name = "checkBoxRemovePreviousWords";
            this.checkBoxRemovePreviousWords.Size = new System.Drawing.Size(140, 17);
            this.checkBoxRemovePreviousWords.TabIndex = 3;
            this.checkBoxRemovePreviousWords.Text = "Remove previous words";
            this.checkBoxRemovePreviousWords.UseVisualStyleBackColor = true;
            // 
            // buttonNextWord
            // 
            this.buttonNextWord.AutoSize = true;
            this.buttonNextWord.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNextWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextWord.Location = new System.Drawing.Point(385, 194);
            this.buttonNextWord.Name = "buttonNextWord";
            this.buttonNextWord.Size = new System.Drawing.Size(120, 36);
            this.buttonNextWord.TabIndex = 2;
            this.buttonNextWord.Text = "Next word";
            this.buttonNextWord.UseVisualStyleBackColor = true;
            this.buttonNextWord.Click += new System.EventHandler(this.ButtonNextWord_Click);
            // 
            // labelGuessesLeft
            // 
            this.labelGuessesLeft.AutoSize = true;
            this.labelGuessesLeft.BackColor = System.Drawing.SystemColors.Control;
            this.labelGuessesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuessesLeft.Location = new System.Drawing.Point(9, 6);
            this.labelGuessesLeft.Name = "labelGuessesLeft";
            this.labelGuessesLeft.Size = new System.Drawing.Size(77, 13);
            this.labelGuessesLeft.TabIndex = 5;
            this.labelGuessesLeft.Text = "Guesses left: 5";
            // 
            // labelDefinition
            // 
            this.labelDefinition.BackColor = System.Drawing.SystemColors.Control;
            this.labelDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefinition.Location = new System.Drawing.Point(12, 36);
            this.labelDefinition.Name = "labelDefinition";
            this.labelDefinition.Size = new System.Drawing.Size(776, 58);
            this.labelDefinition.TabIndex = 10;
            this.labelDefinition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxWord
            // 
            this.textBoxWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWord.Location = new System.Drawing.Point(12, 107);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(776, 80);
            this.textBoxWord.TabIndex = 0;
            this.textBoxWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxWord.TextChanged += new System.EventHandler(this.TextBoxWord_TextChanged);
            // 
            // buttonGuess
            // 
            this.buttonGuess.AutoSize = true;
            this.buttonGuess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuess.Location = new System.Drawing.Point(294, 194);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(85, 36);
            this.buttonGuess.TabIndex = 1;
            this.buttonGuess.Text = "Guess";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.ButtonGuess_Click);
            // 
            // HangmanDefinition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 236);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.labelDefinition);
            this.Controls.Add(this.labelAvailableWords);
            this.Controls.Add(this.checkBoxRemovePreviousWords);
            this.Controls.Add(this.buttonNextWord);
            this.Controls.Add(this.labelGuessesLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HangmanDefinition";
            this.Text = "HangmanDefinition";
            this.Load += new System.EventHandler(this.HangmanDefinition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAvailableWords;
        private System.Windows.Forms.CheckBox checkBoxRemovePreviousWords;
        private System.Windows.Forms.Button buttonNextWord;
        private System.Windows.Forms.Label labelGuessesLeft;
        private System.Windows.Forms.Label labelDefinition;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Button buttonGuess;
    }
}

