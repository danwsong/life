namespace Life
{
    partial class SettingsForm
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
            this.speedLabel = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.stepLabel = new System.Windows.Forms.Label();
            this.stepTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // speedLabel
            // 
            this.speedLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.Location = new System.Drawing.Point(3, 3);
            this.speedLabel.Margin = new System.Windows.Forms.Padding(3);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.speedLabel.Size = new System.Drawing.Size(294, 35);
            this.speedLabel.TabIndex = 0;
            this.speedLabel.Text = "Generations per second:";
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // speedTextBox
            // 
            this.speedTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedTextBox.Location = new System.Drawing.Point(300, 0);
            this.speedTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(211, 39);
            this.speedTextBox.TabIndex = 1;
            this.speedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.speedTextBox_KeyPress);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.speedLabel);
            this.flowLayoutPanel1.Controls.Add(this.speedTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 16, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(511, 41);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(13, 133);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 16);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(255, 48);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(284, 133);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 3, 16, 16);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(255, 48);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.stepLabel);
            this.flowLayoutPanel2.Controls.Add(this.stepTextBox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 73);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 16, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(511, 41);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // stepLabel
            // 
            this.stepLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepLabel.Location = new System.Drawing.Point(3, 3);
            this.stepLabel.Margin = new System.Windows.Forms.Padding(3);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.stepLabel.Size = new System.Drawing.Size(294, 35);
            this.stepLabel.TabIndex = 2;
            this.stepLabel.Text = "Generations per step:";
            this.stepLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // stepTextBox
            // 
            this.stepTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepTextBox.Location = new System.Drawing.Point(300, 0);
            this.stepTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.stepTextBox.Name = "stepTextBox";
            this.stepTextBox.Size = new System.Drawing.Size(211, 39);
            this.stepTextBox.TabIndex = 3;
            this.stepTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stepTextBox_KeyPress);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(721, 604);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label stepLabel;
        private System.Windows.Forms.TextBox stepTextBox;
    }
}