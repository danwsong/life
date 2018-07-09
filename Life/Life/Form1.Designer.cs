namespace Life
{
    partial class Life
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
            this.gameScreen = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.stepButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // gameScreen
            // 
            this.gameScreen.BackColor = System.Drawing.Color.Black;
            this.gameScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameScreen.Location = new System.Drawing.Point(0, 0);
            this.gameScreen.Margin = new System.Windows.Forms.Padding(0);
            this.gameScreen.Name = "gameScreen";
            this.gameScreen.Size = new System.Drawing.Size(1465, 1024);
            this.gameScreen.TabIndex = 0;
            this.gameScreen.TabStop = false;
            this.gameScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.gameScreen_Paint);
            this.gameScreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gameScreen_MouseDown);
            this.gameScreen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gameScreen_MouseMove);
            this.gameScreen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gameScreen_MouseUp);
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(365, 863);
            this.playButton.Margin = new System.Windows.Forms.Padding(0);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(192, 48);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stepButton
            // 
            this.stepButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepButton.Location = new System.Drawing.Point(586, 863);
            this.stepButton.Margin = new System.Windows.Forms.Padding(0);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(192, 48);
            this.stepButton.TabIndex = 2;
            this.stepButton.Text = "Step";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Click += new System.EventHandler(this.stepButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(797, 863);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(192, 48);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(147, 863);
            this.clearButton.Margin = new System.Windows.Forms.Padding(0);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(192, 48);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomButton.Location = new System.Drawing.Point(-66, 863);
            this.randomButton.Margin = new System.Windows.Forms.Padding(0);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(192, 48);
            this.randomButton.TabIndex = 5;
            this.randomButton.Text = "Random";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // Life
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 947);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.gameScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Life";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conway\'s Game of Life";
            ((System.ComponentModel.ISupportInitialize)(this.gameScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox gameScreen;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button randomButton;
    }
}

