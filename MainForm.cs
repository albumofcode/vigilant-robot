// David Escobar
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dle20
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            txtFirstColor.Paste("Enter a basic color.");
            txtSecondColor.Paste("Enter another basic color.");
        }

        private void btnApplyColor_Click(object sender, EventArgs e)
        {
            int timesAppliedCount = Convert.ToInt32(lblTimesAppliedCount.Text);
            SelectSchemeColor(txtFirstColor.Text);
            SelectButtonColor(txtSecondColor.Text);
            lblTimesAppliedCount.Text = Convert.ToString(CountTimesApplied(timesAppliedCount));
        }

        // Determines the appropiate color scheme
        public void SelectSchemeColor(string firstColor)
        {

            if (firstColor.ToLower().Equals("red"))
            {
                firstColor = "ColorScheme";
                RedColorScheme(firstColor);
            }

            else if (firstColor.ToLower().Equals("blue"))
            {
                firstColor = "ColorScheme";
                BlueColorScheme(firstColor);
            }

            else if (firstColor.ToLower().Equals("yellow"))
            {
                firstColor = "ColorScheme";
                YellowColorScheme(firstColor);
            }

            else if (firstColor.ToLower().Equals("green"))
            {
                firstColor = "ColorScheme";
                GreenColorScheme(firstColor);
            }

            else if (firstColor.ToLower().Equals("orange"))
            {
                firstColor = "ColorScheme";
                OrangeColorScheme(firstColor);
            }

            else if (firstColor.ToLower().Equals("purple"))
            {
                firstColor = "ColorScheme";
                PurpleColorScheme(firstColor);
            }

            else
            {
                if (firstColor.Equals("Enter a basic color."))
                {

                }

                else if (firstColor.Equals("That is not a basic color"))
                {
                    txtFirstColor.Text = "Enter a basic color.";
                }

                else
                {
                    txtFirstColor.Text = "";
                    txtFirstColor.Paste("That is not a basic color");
                }
            }
        }

        // Determines the appropriate button color
        public void SelectButtonColor(string secondColor)
        {
            if (secondColor.ToLower().Equals("red"))
            {
                secondColor = "buttons";
                RedColorScheme(secondColor);
            }

            else if (secondColor.ToLower().Equals("blue"))
            {
                secondColor = "buttons";
                BlueColorScheme(secondColor);
            }

            else if (secondColor.ToLower().Equals("yellow"))
            {
                secondColor = "buttons";
                YellowColorScheme(secondColor);
            }

            else if (secondColor.ToLower().Equals("green"))
            {
                secondColor = "buttons";
                GreenColorScheme(secondColor);
            }

            else if (secondColor.ToLower().Equals("orange"))
            {
                secondColor = "buttons";
                OrangeColorScheme(secondColor);
            }

            else if (secondColor.ToLower().Equals("purple"))
            {
                secondColor = "buttons";
                PurpleColorScheme(secondColor);
            }

            else
            {
                if (secondColor.Equals("Enter another basic color."))
                {

                }

                else if (secondColor.Equals("That is not a basic color"))
                {
                    txtSecondColor.Text = "Enter another basic color.";
                }

                else
                {
                    txtSecondColor.Text = "";
                    txtSecondColor.Paste("That is not a basic color");
                }
            }
        }

        // Counts the number of times the "apply" button has been clicked
        public int CountTimesApplied(int timesApplied)
        {
            return timesApplied += 1;
        }

        // Changes the color scheme back to default
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Inputs
            txtFirstColor.BackColor = DefaultBackColor;
            txtFirstColor.ForeColor = Color.Black;
            txtSecondColor.BackColor = DefaultBackColor;
            txtSecondColor.ForeColor = Color.Black;
            txtFirstColor.Text = "";
            txtFirstColor.Paste("Enter a basic color.");
            txtSecondColor.Text = "";
            txtSecondColor.Paste("Enter another basic color.");

            // Reset Button
            btnReset.BackColor = DefaultBackColor;
            btnReset.FlatAppearance.MouseOverBackColor = DefaultBackColor;
            btnReset.ForeColor = Color.Black;

            // Apply Button
            btnApplyColor.BackColor = DefaultBackColor;
            btnApplyColor.FlatAppearance.MouseOverBackColor = DefaultBackColor;
            btnApplyColor.ForeColor = Color.Black;

            // Main Form
            txtFirstColor.BackColor = DefaultBackColor;
            txtSecondColor.BackColor = DefaultBackColor;
            BackColor = DefaultBackColor;
            lblHeaderInfo.ForeColor = Color.Black;
            lblColorName.ForeColor = Color.DimGray;
            lblColorName.Text = "Grey";
            lblTimesAppliedCount.Text = "0";
        }

        // #b71c1c
        public void RedColorScheme(string txtInput)
        {
            if (txtInput == "buttons")
            {
                // Reset Button
                btnReset.ForeColor = Color.White;
                btnReset.BackColor = Color.FromArgb(183, 28, 28);
                btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(160, 24, 24);

                // Apply Button
                btnApplyColor.ForeColor = Color.White;
                btnApplyColor.BackColor = Color.FromArgb(183, 28, 28);
                btnApplyColor.FlatAppearance.MouseOverBackColor = Color.FromArgb(160, 24, 24);
            }
            
            else
            {
                // Inputs
                txtFirstColor.BackColor = Color.FromArgb(255, 255, 255);
                txtSecondColor.BackColor = Color.FromArgb(255, 255, 255);

                // Reset Button
                btnReset.ForeColor = Color.White;
                btnReset.BackColor = Color.FromArgb(183, 28, 28);
                btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(160, 24, 24);

                // Apply Button
                btnApplyColor.ForeColor = Color.White;
                btnApplyColor.BackColor = Color.FromArgb(183, 28, 28);
                btnApplyColor.FlatAppearance.MouseOverBackColor = Color.FromArgb(160, 24, 24);

                // Main Form
                BackColor = Color.FromArgb(255, 235, 238);
                ForeColor = Color.Black;
                lblHeaderInfo.ForeColor = Color.Black;
                lblColorName.ForeColor = Color.FromArgb(183, 28, 28);
                lblColorName.Text = "Red";
            }
        }

        // #0d46a0
        public void BlueColorScheme(string txtInput)
        {
            if (txtInput == "buttons")
            {
                // Reset Button
                btnReset.ForeColor = Color.FromArgb(226, 241, 252);
                btnReset.BackColor = Color.FromArgb(13, 70, 160);
                btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 62, 141);

                // Apply Button
                btnApplyColor.ForeColor = Color.FromArgb(226, 241, 252);
                btnApplyColor.BackColor = Color.FromArgb(13, 70, 160);
                btnApplyColor.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 62, 141);
            }

            else
            {
                // Inputs
                txtFirstColor.BackColor = Color.FromArgb(255, 255, 255);
                txtSecondColor.BackColor = Color.FromArgb(255, 255, 255);

                // Reset Button
                btnReset.ForeColor = Color.FromArgb(226, 241, 252);
                btnReset.BackColor = Color.FromArgb(13, 70, 160);
                btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 62, 141);

                // Apply Button
                btnApplyColor.ForeColor = Color.FromArgb(226, 241, 252);
                btnApplyColor.BackColor = Color.FromArgb(13, 70, 160);
                btnApplyColor.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 62, 141);

                // Main Form
                BackColor = Color.FromArgb(226, 241, 252);
                ForeColor = Color.Black;
                lblHeaderInfo.ForeColor = Color.Black;
                lblColorName.ForeColor = Color.FromArgb(13, 70, 160);
                lblColorName.Text = "Blue";
            }
        }

        // #f57f17
        public void YellowColorScheme(string txtInput)
        {
            if (txtInput == "buttons")
            {
                // Reset Button
                btnReset.ForeColor = Color.FromArgb(255, 253, 231);
                btnReset.BackColor = Color.FromArgb(245, 127, 23);
                btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(214, 111, 20);

                // Apply Button
                btnApplyColor.ForeColor = Color.FromArgb(255, 253, 231);
                btnApplyColor.BackColor = Color.FromArgb(245, 127, 23);
                btnApplyColor.FlatAppearance.MouseOverBackColor = Color.FromArgb(214, 111, 20);
            }

            else
            {
                // Inputs
                txtFirstColor.BackColor = Color.FromArgb(255, 255, 255);
                txtSecondColor.BackColor = Color.FromArgb(255, 255, 255);

                // Reset Button
                btnReset.ForeColor = Color.FromArgb(255, 253, 231);
                btnReset.BackColor = Color.FromArgb(245, 127, 23);
                btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(214, 111, 20);

                // Apply Button
                btnApplyColor.ForeColor = Color.FromArgb(255, 253, 231);
                btnApplyColor.BackColor = Color.FromArgb(245, 127, 23);
                btnApplyColor.FlatAppearance.MouseOverBackColor = Color.FromArgb(214, 111, 20);

                // Main Form
                BackColor = Color.FromArgb(255, 253, 231);
                ForeColor = Color.Black;
                lblHeaderInfo.ForeColor = Color.Black;
                lblColorName.ForeColor = Color.FromArgb(245, 127, 23);
                lblColorName.Text = "Yellow";
            }
        }

        // #1b5e20
        public void GreenColorScheme(string txtInput)
        {
            if (txtInput == "buttons")
            {
                // Reset Button
                btnReset.ForeColor = Color.FromArgb(232, 245, 233);
                btnReset.BackColor = Color.FromArgb(27, 94, 32);
                btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 82, 28);

                // Apply Button
                btnApplyColor.ForeColor = Color.FromArgb(232, 245, 233);
                btnApplyColor.BackColor = Color.FromArgb(27, 94, 32);
                btnApplyColor.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 82, 28);
            }

            else
            {
                // Inputs
                txtFirstColor.BackColor = Color.FromArgb(255, 255, 255);
                txtSecondColor.BackColor = Color.FromArgb(255, 255, 255);

                // Reset Button
                btnReset.ForeColor = Color.FromArgb(232, 245, 233);
                btnReset.BackColor = Color.FromArgb(27, 94, 32);
                btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 82, 28);

                // Apply Button
                btnApplyColor.ForeColor = Color.FromArgb(232, 245, 233);
                btnApplyColor.BackColor = Color.FromArgb(27, 94, 32);
                btnApplyColor.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 82, 28);

                // Main Form
                BackColor = Color.FromArgb(232, 245, 233);
                ForeColor = Color.Black;
                lblHeaderInfo.ForeColor = Color.Black;
                lblColorName.ForeColor = Color.FromArgb(27, 94, 32);
                lblColorName.Text = "Green";
            }
        }

        // #e65100
        public void OrangeColorScheme(string txtInput)
        {
            if (txtInput == "buttons")
            {
                // Reset Button
                btnReset.ForeColor = Color.FromArgb(255, 243, 224);
                btnReset.BackColor = Color.FromArgb(230, 81, 0);
                btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(201, 71, 0);

                // Apply Button
                btnApplyColor.ForeColor = Color.FromArgb(255, 243, 224);
                btnApplyColor.BackColor = Color.FromArgb(230, 81, 0);
                btnApplyColor.FlatAppearance.MouseOverBackColor = Color.FromArgb(201, 71, 0);
            }

            else
            {
                // Inputs
                txtFirstColor.BackColor = Color.FromArgb(255, 255, 255);
                txtSecondColor.BackColor = Color.FromArgb(255, 255, 255);

                // Reset Button
                btnReset.ForeColor = Color.FromArgb(255, 243, 224);
                btnReset.BackColor = Color.FromArgb(230, 81, 0);
                btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(201, 71, 0);

                // Apply Button
                btnApplyColor.ForeColor = Color.FromArgb(255, 243, 224);
                btnApplyColor.BackColor = Color.FromArgb(230, 81, 0);
                btnApplyColor.FlatAppearance.MouseOverBackColor = Color.FromArgb(201, 71, 0);

                // Main Form
                BackColor = Color.FromArgb(255, 243, 224);
                ForeColor = Color.Black;
                lblHeaderInfo.ForeColor = Color.Black;
                lblColorName.ForeColor = Color.FromArgb(230, 81, 0);
                lblColorName.Text = "Orange";
            }
        }

        // #4a148c
        public void PurpleColorScheme(string txtInput)
        {
            if (txtInput == "buttons")
            {
                // Reset Button
                btnReset.ForeColor = Color.FromArgb(243, 229, 245);
                btnReset.BackColor = Color.FromArgb(74, 20, 140);
                btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 18, 123);

                // Apply Button
                btnApplyColor.ForeColor = Color.FromArgb(243, 229, 245);
                btnApplyColor.BackColor = Color.FromArgb(74, 20, 140);
                btnApplyColor.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 18, 123);
            }
            
            else
            {
                // Inputs
                txtFirstColor.BackColor = Color.FromArgb(255, 255, 255);
                txtSecondColor.BackColor = Color.FromArgb(255, 255, 255);

                // Reset Button
                btnReset.ForeColor = Color.FromArgb(243, 229, 245);
                btnReset.BackColor = Color.FromArgb(74, 20, 140);
                btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 18, 123);

                // Apply Button
                btnApplyColor.ForeColor = Color.FromArgb(243, 229, 245);
                btnApplyColor.BackColor = Color.FromArgb(74, 20, 140);
                btnApplyColor.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 18, 123);

                // Main Form
                BackColor = Color.FromArgb(243, 229, 245);
                ForeColor = Color.Black;
                lblHeaderInfo.ForeColor = Color.Black;
                lblColorName.ForeColor = Color.FromArgb(74, 20, 140);
                lblColorName.Text = "Purple";
            }
        }
    }
}
