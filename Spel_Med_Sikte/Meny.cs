using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spel_Med_Sikte
{
    public partial class Meny : Form
    {
        public Meny()
        {
            InitializeComponent();
            lbxScoreboard.Items.Add("Hitler: 17 miljoner");
        }

        private void btn_Start_Game_Session_Click(object sender, EventArgs e)
        {
            //this.Close(); Om man vill ta bort meny innan spelet startas
            Game_Session new_Game_session = new Game_Session();
            new_Game_session.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBossTest_Click(object sender, EventArgs e)
        {
            //this.Close();
            Game_Boss_Hitler new_Game_Boss_Hitler = new Game_Boss_Hitler();
            new_Game_Boss_Hitler.Show();
        }
    }
}
