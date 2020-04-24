using System;
using System.Drawing;
using System.Windows.Forms;
using BluInjector.Properties;

namespace BluInjector
{
    public delegate void DataSentHandler2(object sender, EventArgs e, Color clr1, Color clr2, Color clr3, bool close, bool sound, bool delay, int dtime, int method);
    public partial class SettingsForm : Form
    {
        public event DataSentHandler2 DataSent;

        Color backgroundclr = (Color)Settings.Default["bkColor"];
        Color textclr = (Color)Settings.Default["txColor"];
        Color bttnclr = (Color)Settings.Default["btColor"];

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            closeInjectBox.Checked = (bool) Settings.Default["closeInj"];
            injectSound.Checked = (bool)Settings.Default["soundInj"];
            delayInject.Checked = (bool)Settings.Default["delayInj"];
            delaySlider.Value = (int)Settings.Default["delayTime"];
            delayLabel.Text = delaySlider.Value.ToString() + "s";
            injMethodCombo.SelectedIndex = (int)Settings.Default["method"];

            if (backgroundclr.ToString() == "Color[empty]" || textclr.ToString() == "Color[empty]" || bttnclr.ToString() == "Color[empty]")
            {
                backgroundclr = Color.SteelBlue;
                textclr = Color.Black;
                bttnclr = Color.White;
                Apply2(sender, e);
            }
            else
                Apply2(sender, e);

        }
        private void Color1bttn_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                backgroundclr = colorDialog1.Color;
                color1bttn.BackColor = backgroundclr;
            }
            update(sender, e);
        }

        private void Color2bttn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textclr = colorDialog1.Color;
                color2bttn.BackColor = textclr;
            }
            update(sender, e);
        }

        private void Color3bttn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                bttnclr = colorDialog1.Color;
                color3bttn.BackColor = bttnclr;
            }
            update(sender, e);
        }
        private void ApplyBttn_Click(object sender, EventArgs e)
        {
            update(sender, e);
            this.Close();
        }
        private void update(object sender, EventArgs e)
        {
            this.DataSent(sender, e, backgroundclr, textclr, bttnclr, closeInjectBox.Checked, injectSound.Checked, delayInject.Checked, delaySlider.Value, injMethodCombo.SelectedIndex);
            Apply2(sender, e);
        }
        private void Apply2(object sender, EventArgs e)
        {
            color1bttn.BackColor = backgroundclr;
            color2bttn.BackColor = textclr;
            color3bttn.BackColor = bttnclr;

            //bacgkround
            this.BackColor = Color.FromArgb(backgroundclr.R, backgroundclr.G, backgroundclr.B);

            //text
            closeInjectBox.ForeColor = textclr;
            injectSound.ForeColor = textclr;
            colorBox.ForeColor = textclr;
            injectionBox.ForeColor = textclr;
            bkLabel.ForeColor = textclr;
            textLabel.ForeColor = textclr;
            bttnLabel.ForeColor = textclr;
            applyBttn.ForeColor = textclr;
            delayInject.ForeColor = textclr;
            delayLabel.ForeColor = textclr;
            injMethodLabel.ForeColor = textclr;

            //buttons
            applyBttn.BackColor = bttnclr;

            Settings.Default["bkColor"] = backgroundclr;
            Settings.Default["txColor"] = textclr;
            Settings.Default["btColor"] = bttnclr;
            Settings.Default["closeInj"] = closeInjectBox.Checked;
            Settings.Default["soundInj"] = injectSound.Checked;
            Settings.Default["delayInj"] = delayInject.Checked;
            Settings.Default["delayTime"] = delaySlider.Value;
            Settings.Default["method"] = injMethodCombo.SelectedIndex;
            Settings.Default.Save();
        }

        private void DelaySlider_Scroll(object sender, EventArgs e)
        {
            delayLabel.Text = delaySlider.Value.ToString() + "s";
        }
    }
}
