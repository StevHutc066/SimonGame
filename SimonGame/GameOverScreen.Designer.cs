namespace SimonGame
{
    partial class GameOverScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.patternLengthLabel = new System.Windows.Forms.Label();
            this.mainScreenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patternLengthLabel
            // 
            this.patternLengthLabel.AutoSize = true;
            this.patternLengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.patternLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternLengthLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.patternLengthLabel.Location = new System.Drawing.Point(154, 69);
            this.patternLengthLabel.Name = "patternLengthLabel";
            this.patternLengthLabel.Size = new System.Drawing.Size(293, 31);
            this.patternLengthLabel.TabIndex = 0;
            this.patternLengthLabel.Text = "Yer pattern length was:";
            // 
            // mainScreenButton
            // 
            this.mainScreenButton.BackColor = System.Drawing.Color.Black;
            this.mainScreenButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mainScreenButton.FlatAppearance.BorderSize = 3;
            this.mainScreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainScreenButton.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenButton.ForeColor = System.Drawing.Color.White;
            this.mainScreenButton.Location = new System.Drawing.Point(113, 191);
            this.mainScreenButton.Name = "mainScreenButton";
            this.mainScreenButton.Size = new System.Drawing.Size(375, 219);
            this.mainScreenButton.TabIndex = 1;
            this.mainScreenButton.Text = "Main Screen";
            this.mainScreenButton.UseVisualStyleBackColor = false;
            this.mainScreenButton.Click += new System.EventHandler(this.mainScreenButton_Click_1);
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.mainScreenButton);
            this.Controls.Add(this.patternLengthLabel);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(600, 600);
            this.Load += new System.EventHandler(this.GameOverScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patternLengthLabel;
        private System.Windows.Forms.Button mainScreenButton;
    }
}
