using BSOD_Simulator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSOD_Simulator.BSOD
{
    public partial class BSOD : Form
    {
        public BSOD()
        {
            InitializeComponent();
        }

        private void BSOD_Load(object sender, EventArgs e)
        {
            // colors
            if (Settings.Default.Color == "Blue")
            {
                panel1.BackColor = Color.FromArgb(17, 114, 169);
            }
            if (Settings.Default.Color == "Red")
            {
                panel1.BackColor = Color.Red;
            }
            if (Settings.Default.Color == "Black")
            {
                panel1.BackColor = Color.Black;
            }
            if (Settings.Default.Color == "Yellow")
            {
                panel1.BackColor = Color.Yellow;
            }
            if (Settings.Default.Color == "Green")
            {
                panel1.BackColor = Color.Green;
            }
            labelText.Text = Settings.Default.Text;
            labelErr.Text = Settings.Default.errorCode;
            label1.Text = Settings.Default.emoteIcon;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
