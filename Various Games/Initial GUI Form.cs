using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Initial_GUI {
    public partial class Games_Form : Form {
        bool diceGame = false;
        bool cardGame = false;

        public Games_Form() {
            InitializeComponent();
        }

        private void Games_Load(object sender, EventArgs e) {

        }

        private void exitBtn_Click(object sender, EventArgs e) {
            exit();
        }

        public void exit() {

            DialogResult result = MessageBox.Show("Do you really want to quit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                this.Close();
            }
            else {
                DialogResult = DialogResult.None;
            }


        }

        private void diceGameRadioBtn_CheckedChanged(object sender, EventArgs e) {
            if (diceGameRadioBtn.Checked == true) {
                diceGame = true;
                cardGame = false;
                cardGameRadioBtn.Checked = false;
                startBtn.Enabled = true;
            }
            else if (cardGameRadioBtn.Checked == true) {
                cardGame = true;
                diceGame = false;
                diceGameRadioBtn.Checked = false;
                startBtn.Enabled = true;
            }
        }

        private void startBtn_Click(object sender, EventArgs e) {
            if (diceGame) {

                Games.Close();
                Which_Dice_Game_Form WhichDice = new Which_Dice_Game_Form();
                WhichDice.Show();

            }
            else if(cardGame){
                Games.Close();
                Which_Card_Game_Form WhichCard = new Which_Card_Game_Form();
                WhichCard.Show();
            }
        }
    }
}
