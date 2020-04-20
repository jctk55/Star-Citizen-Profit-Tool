using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitProfitGUI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            float _totalCredits = (float)totalCreditsBox.Value;
            int _totalPlayers = (int)totalPlayersBox.Value;
            float _PercentCut = (float)ownerCutPercent.Value / 100;

            float _ownerCut = _totalCredits * _PercentCut;
            float currentCredits = _totalCredits - _ownerCut;

            float _playerCut = currentCredits / (_totalPlayers - 1);

            ownersCutBox.Value = (decimal)_ownerCut;
            playersCutBox.Value = (decimal)_playerCut;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
    }
}
