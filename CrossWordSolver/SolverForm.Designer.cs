namespace CrossWordSolver
{
    partial class SolverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolverForm));
            this.wordsLoadedIndLabel = new System.Windows.Forms.Label();
            this.wordsLoadedCountLabel = new System.Windows.Forms.Label();
            this.puzzlePanel = new System.Windows.Forms.Panel();
            this.showWordsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wordsLoadedIndLabel
            // 
            this.wordsLoadedIndLabel.AutoSize = true;
            this.wordsLoadedIndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordsLoadedIndLabel.Location = new System.Drawing.Point(670, 548);
            this.wordsLoadedIndLabel.Name = "wordsLoadedIndLabel";
            this.wordsLoadedIndLabel.Size = new System.Drawing.Size(101, 13);
            this.wordsLoadedIndLabel.TabIndex = 0;
            this.wordsLoadedIndLabel.Text = "Words Loaded : ";
            // 
            // wordsLoadedCountLabel
            // 
            this.wordsLoadedCountLabel.AutoSize = true;
            this.wordsLoadedCountLabel.Location = new System.Drawing.Point(778, 548);
            this.wordsLoadedCountLabel.Name = "wordsLoadedCountLabel";
            this.wordsLoadedCountLabel.Size = new System.Drawing.Size(0, 13);
            this.wordsLoadedCountLabel.TabIndex = 1;
            // 
            // puzzlePanel
            // 
            this.puzzlePanel.Location = new System.Drawing.Point(12, 12);
            this.puzzlePanel.Name = "puzzlePanel";
            this.puzzlePanel.Size = new System.Drawing.Size(370, 329);
            this.puzzlePanel.TabIndex = 2;
            // 
            // showWordsButton
            // 
            this.showWordsButton.Location = new System.Drawing.Point(657, 36);
            this.showWordsButton.Name = "showWordsButton";
            this.showWordsButton.Size = new System.Drawing.Size(103, 31);
            this.showWordsButton.TabIndex = 3;
            this.showWordsButton.Text = "Show Words";
            this.showWordsButton.UseVisualStyleBackColor = true;
            this.showWordsButton.Click += new System.EventHandler(this.showWordsButton_Click);
            // 
            // SolverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 570);
            this.Controls.Add(this.showWordsButton);
            this.Controls.Add(this.puzzlePanel);
            this.Controls.Add(this.wordsLoadedCountLabel);
            this.Controls.Add(this.wordsLoadedIndLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SolverForm";
            this.Text = "Cross Word Solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordsLoadedIndLabel;
        private System.Windows.Forms.Label wordsLoadedCountLabel;
        private System.Windows.Forms.Panel puzzlePanel;
        private System.Windows.Forms.Button showWordsButton;
    }
}

