using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            // Set contents of text boxes to current values of the variables
            speedTextBox.Text = "" + Life.speed;
            stepTextBox.Text = "" + Life.stepSize;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Resume the timer and close the window
            Life.timer.Start();
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int newSpeed, newStep;
            // Attempt to parse the text in the textboxes as an integer
            if (int.TryParse(speedTextBox.Text, out newSpeed) && int.TryParse(stepTextBox.Text, out newStep))
            {
                // If the speed is not within the valid range, alert the user
                if (newSpeed <= 0 || newSpeed > 60)
                {
                    MessageBox.Show("The number of generations per second needs to be between 1 and 60.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                // If the step size is not within the valid range, alert the user
                else if (newStep <= 0 || newStep > 5)
                {
                    MessageBox.Show("The number of generations per step needs to be between 1 and 5.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                // Otherwise, set the variables to the new values and close the window
                else
                {
                    Life.speed = newSpeed;
                    Life.timer.Interval = 1000.0 / Life.speed;
                    Life.stepSize = newStep;
                    Life.timer.Start();
                    Close();
                }
            }
            else if (!int.TryParse(speedTextBox.Text, out newSpeed))
            {
                // If the speed cannot be parsed, alert the user
                MessageBox.Show("The number of generations per second needs to be a number between 1 and 60.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                // If the step size cannot be parsed, alert the user
                MessageBox.Show("The number of generations per step needs to be a number between 1 and 5.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void speedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the user presses the return key on a textbox, press the OK button
            if (e.KeyChar == '\r')
            {
                okButton_Click(sender, e);
            }
        }

        private void stepTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the user presses the return key on a textbox, press the OK button
            if (e.KeyChar == '\r')
            {
                okButton_Click(sender, e);
            }
        }

        private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            // If user presses escape, close the window without changing the variables
            if (e.KeyCode == Keys.Escape)
            {
                cancelButton_Click(sender, e);
            }
        }
    }
}
