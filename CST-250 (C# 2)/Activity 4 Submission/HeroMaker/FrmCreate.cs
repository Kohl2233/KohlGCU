namespace HeroMaker
{
    public partial class FrmCreate : Form
    {
        string TrooperName = "";
        string ServiceBranch = "";
        string TrooperType = "";

        int TrooperAccuracy;
        int TrooperStamina;
        int TrooperSanity;
        int StatSum;

        string TrooperDeployment = "";

        string TrooperEnlistDate;
        string TrooperFirstCombatDate;

        int TrooperYearsService = 0;

        int DarkSideCorruption = 0;

        string TrooperArmorColor = "";

        TrooperList Troops;
        public FrmCreate()
        {
            InitializeComponent();

            // Set Initial Values
            UpdateDisplayLabels();

            TrooperAccuracy = hScrollBarAccuracy.Value;
            TrooperStamina = hScrollBarStamina.Value;
            TrooperSanity = hScrollBarSanity.Value;
            StatSum = TrooperAccuracy + TrooperStamina + TrooperSanity;

            // Create Trooper List
            Troops = new TrooperList();
        }



        /// <summary>
        /// Utility Function to Check if the Form is Completly Filled Out
        /// </summary>
        /// <returns></returns>
        private bool CheckFormComplete()
        {
            bool isComplete = true;

            // Check Name
            if (TrooperName == "")
            {
                isComplete = false;
                lblTrooperName.ForeColor = Color.Red;
            }
            else
            {
                lblTrooperName.ForeColor = Color.Black;
            }

            // Check Service Branch
            if (ServiceBranch == "")
            {
                isComplete = false;
                gbServiceBranch.ForeColor = Color.Red;
            }
            else
            {
                gbServiceBranch.ForeColor = Color.Black;
            }

            // Check Trooper Type
            if (TrooperType == "")
            {
                isComplete = false;
                gbTrooperType.ForeColor = Color.Red;
            }
            else
            {
                gbTrooperType.ForeColor = Color.Black;
            }

            // Check Deployments
            if (TrooperDeployment == "")
            {
                isComplete = false;
                gbDeployments.ForeColor = Color.Red;
            }
            else
            {
                gbDeployments.ForeColor = Color.Black;
            }

            // Check Color
            if (TrooperArmorColor == "")
            {
                isComplete = false;
                lblArmorColor.ForeColor = Color.Red;
            }
            else
            {
                lblArmorColor.ForeColor = Color.Black;
            }

            return isComplete;
        }



        /// <summary>
        /// Utility Function to Update Labels used for Displaying Data
        /// </summary>
        private void UpdateDisplayLabels()
        {
            lblAccuracy.Text = "Accuracy: " + hScrollBarAccuracy.Value.ToString();
            lblStamina.Text = "Stamina: " + hScrollBarStamina.Value.ToString();
            lblSanity.Text = "Sanity: " + hScrollBarSanity.Value.ToString();
            lblDarkSideCorVal.Text = trackBarDarkSide.Value.ToString();
        }
        /// <summary>
        /// Event Handler For Create Trooper Btn Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreateTrooper_ClickEventHandler(object sender, EventArgs e)
        {
            // Update Values
            TrooperName = textTrooperName.Text;
            TrooperEnlistDate = dtPickerEnlistment.Text;
            TrooperFirstCombatDate = dtPickerCombat.Text;
            DarkSideCorruption = trackBarDarkSide.Value;
            TrooperYearsService = (int)numUpDownService.Value;

            if (CheckFormComplete())
            {
                Trooper troop = new Trooper(TrooperName, ServiceBranch, TrooperType, TrooperAccuracy, TrooperStamina, TrooperSanity, TrooperDeployment, TrooperEnlistDate, TrooperFirstCombatDate, TrooperYearsService, DarkSideCorruption, TrooperArmorColor);
                Troops.TroopList.Add(troop);

                FrmDisplay display = new FrmDisplay(Troops);
                display.ShowDialog();
            }
        }



        /// <summary>
        /// Click Event Handler for the Two Service Branch Checkboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServiceBranchCheck_ClickEventHandler(object sender, EventArgs e)
        {
            if (cBoxArmy.Checked)
            {
                ServiceBranch = cBoxArmy.Text;
                cBoxNavy.Enabled = false;
            }

            if (cBoxNavy.Checked)
            {
                ServiceBranch = cBoxNavy.Text;
                cBoxArmy.Enabled = false;
            }

            if (!cBoxArmy.Checked && !cBoxNavy.Checked) { cBoxArmy.Enabled = true; cBoxNavy.Enabled = true; ServiceBranch = ""; }
        }



        /// <summary>
        /// Click Event Handler for Trooper Type List Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxTrooperType_ClickEventHandler(object sender, EventArgs e)
        {
            TrooperType = listBoxTrooperType.Text;
        }



        /// <summary>
        /// Scroll Event Handler for hScrollAccuracy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollAccuracy_ScrollEventHandler(object sender, ScrollEventArgs e)
        {
            StatSum = hScrollBarAccuracy.Value + hScrollBarStamina.Value + hScrollBarSanity.Value;
            TrooperAccuracy = hScrollBarAccuracy.Value;
            if (StatSum > 100)
            {
                // Reduce Other Two Stats
                int reduceByAmount = (StatSum % 100) / 2;
                if (hScrollBarStamina.Value > 0 && hScrollBarSanity.Value > 0)
                {
                    // reduce both
                    hScrollBarStamina.Value -= reduceByAmount;
                    hScrollBarSanity.Value -= reduceByAmount;
                }
                else if (hScrollBarStamina.Value > 0)
                {
                    // reduce just stamina
                    hScrollBarStamina.Value -= reduceByAmount * 2;
                }
                else
                {
                    // reduce just sanity
                    hScrollBarSanity.Value -= reduceByAmount * 2;
                }

                StatSum = hScrollBarAccuracy.Value + hScrollBarStamina.Value + hScrollBarSanity.Value;
            }

            // Update Labels & Values
            UpdateDisplayLabels();
            StatSum = hScrollBarAccuracy.Value + hScrollBarStamina.Value + hScrollBarSanity.Value;
            TrooperAccuracy = hScrollBarAccuracy.Value;
            TrooperStamina = hScrollBarStamina.Value;
            TrooperSanity = hScrollBarSanity.Value;
        }



        /// <summary>
        /// Scroll Event Handler for hScrollStamina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HScrollStamina_ScrollEventHandler(object sender, ScrollEventArgs e)
        {
            StatSum = hScrollBarAccuracy.Value + hScrollBarStamina.Value + hScrollBarSanity.Value;
            TrooperStamina = hScrollBarStamina.Value;
            if (StatSum > 100)
            {
                // Reduce Other Two Stats
                int reduceByAmount = (StatSum % 100) / 2;
                if (hScrollBarAccuracy.Value > 0 && hScrollBarSanity.Value > 0)
                {
                    // reduce both
                    hScrollBarAccuracy.Value -= reduceByAmount;
                    hScrollBarSanity.Value -= reduceByAmount;
                }
                else if (hScrollBarAccuracy.Value > 0)
                {
                    // reduce just accuracy
                    hScrollBarAccuracy.Value -= reduceByAmount * 2;
                }
                else
                {
                    // reduce just sanity
                    hScrollBarSanity.Value -= reduceByAmount * 2;
                }

                StatSum = hScrollBarAccuracy.Value + hScrollBarStamina.Value + hScrollBarSanity.Value;
            }

            // Update Labels & Values
            UpdateDisplayLabels();
            StatSum = hScrollBarAccuracy.Value + hScrollBarStamina.Value + hScrollBarSanity.Value;
            TrooperAccuracy = hScrollBarAccuracy.Value;
            TrooperStamina = hScrollBarStamina.Value;
            TrooperSanity = hScrollBarSanity.Value;
        }



        /// <summary>
        /// Scroll Event Handler for hScrollSanity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HScrollSanity_ScrollEventHandler(object sender, ScrollEventArgs e)
        {
            StatSum = hScrollBarAccuracy.Value + hScrollBarStamina.Value + hScrollBarSanity.Value;
            TrooperSanity = hScrollBarSanity.Value;
            if (StatSum > 100)
            {
                // Reduce Other Two Stats
                int reduceByAmount = (StatSum % 100) / 2;
                if (hScrollBarAccuracy.Value > 0 && hScrollBarStamina.Value > 0)
                {
                    // reduce both
                    hScrollBarAccuracy.Value -= reduceByAmount;
                    hScrollBarStamina.Value -= reduceByAmount;
                }
                else if (hScrollBarAccuracy.Value > 0)
                {
                    // reduce just accuracy
                    hScrollBarAccuracy.Value -= reduceByAmount * 2;
                }
                else
                {
                    // reduce just stamina
                    hScrollBarStamina.Value -= reduceByAmount * 2;
                }

                StatSum = hScrollBarAccuracy.Value + hScrollBarStamina.Value + hScrollBarSanity.Value;
            }

            // Update Labels & Values
            UpdateDisplayLabels();
            StatSum = hScrollBarAccuracy.Value + hScrollBarStamina.Value + hScrollBarSanity.Value;
            TrooperAccuracy = hScrollBarAccuracy.Value;
            TrooperStamina = hScrollBarStamina.Value;
            TrooperSanity = hScrollBarSanity.Value;
        }



        /// <summary>
        /// Clicked Event Handler for All Deployment Radio Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioBtnDeployment_ClickEventHandler(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            TrooperDeployment = btn.Text;
        }



        /// <summary>
        /// Click Event Handler for Color Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxArmorColor_ClickEventHandler(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            picBoxArmorColor.BackColor = colorDialog.Color;
            TrooperArmorColor = colorDialog.Color.ToString();
        }



        /// <summary>
        /// Scroll Event Handler for Dark Side Corruption Track Bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrackBarDarkSideCorrupt_ScrollEventHandler(object sender, EventArgs e)
        {
            DarkSideCorruption = trackBarDarkSide.Value;
            lblDarkSideCorVal.Text = DarkSideCorruption.ToString();
        }
    }
}