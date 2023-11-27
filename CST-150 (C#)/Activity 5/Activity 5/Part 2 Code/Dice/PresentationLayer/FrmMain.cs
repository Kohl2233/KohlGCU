using Dice.BusinessLayer;
/* Kohl Johnson
 * CST-150
 * Activity 5
 * 11-25-2023
 * Citation(s):
 */
namespace Dice
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            lblRollResult.Visible = false;
            pbDieImage.Visible = false;
        }

        private void BtnRollDieClickEventHandler(object sender, EventArgs e)
        {
            Die die = new Die(); // create new die object
            die.RollDie(); // roll die

            switch (die.RollVal) // figure out what to do
            {
                case 1:
                    pbDieImage.Image = Dice.Properties.Resources.dice1;
                    break;
                case 2:
                    pbDieImage.Image = Dice.Properties.Resources.dice2;
                    break;
                case 3:
                    pbDieImage.Image = Dice.Properties.Resources.dice3;
                    break;
                case 4:
                    pbDieImage.Image = Dice.Properties.Resources.dice4;
                    break;
                case 5:
                    pbDieImage.Image = Dice.Properties.Resources.dice5;
                    break;
                case 6:
                    pbDieImage.Image = Dice.Properties.Resources.dice6;
                    break;
                default:
                    pbDieImage.Image = Dice.Properties.Resources.dice1;
                    break;
            }

            pbDieImage.Refresh(); // refresh image
            pbDieImage.Visible = true; // make picture visible
            lblRollResult.Text = "You rolled a " + die.RollVal.ToString() + "!!";
            lblRollResult.Visible = true;
        }
    }
}
