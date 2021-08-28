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
using BSOD_Simulator.BSOD;
namespace BSOD_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Settings.Default.Color = siticoneRoundedComboBox1.Text;
            Settings.Default.Text = BxText.Text;
            Settings.Default.errorCode = errCode.Text;
            Settings.Default.emoteIcon = emIc.Text;
            Settings.Default.Save();
            BSOD.BSOD blueScreenOfDeath = new BSOD.BSOD();
            blueScreenOfDeath.Show();
        }
    }
}
