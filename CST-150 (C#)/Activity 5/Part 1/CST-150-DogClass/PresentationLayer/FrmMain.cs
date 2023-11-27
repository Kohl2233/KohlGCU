using CST_150_DogClass.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Kohl Johnson
 * CST-150
 * Activity 5
 * 11-25-2023
 * Citation(s):
 */
namespace CST_150_DogClass.PresentationLayer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            lblErrorMessage.Visible = false;
        }

        /// <summary>
        /// Method to Handle Click Event for 'Add New Dog' Btn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddNewDogClickEvent(object sender, EventArgs e)
        {
            bool isValidEntries = true;
            double weight = 0.00D, neckRad = 0.00D, neckCircum = 0.00D;
            bool isValid = false;
            lblErrorMessage.Visible = false;
            Utility utility = new Utility();

            if ((!utility.NotNull(txtName.Text)) || (!utility.NotNull(txtColor.Text)) || (cmbSit.SelectedItem == null))
            {
                isValidEntries = false;
            }

            (neckRad, isValid) = utility.ValidDouble(txtNeck.Text);
            if (!isValid ) { isValidEntries = false; }

            (weight, isValid) = utility.ValidDouble(txtWeight.Text);
            if (!isValid ) { isValidEntries = false; }

            if (isValidEntries)
            {
                Dog dogObject = new Dog(txtName.Text, neckRad, txtColor.Text, weight, utility.ConvertToBool(cmbSit.Text));
                gvShowDogs.Rows.Add(dogObject.Name, dogObject.CalCircumfrence(), dogObject.Sit, dogObject.CalWeight(), dogObject.Color);
            } else
            {
                lblErrorMessage.Visible = true;
            }
        }

        /// <summary>
        /// Method to Be Run When Frm is Loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMainLoadEventHandler(object sender, EventArgs e)
        {
            gvShowDogs.ColumnCount = 5;
            gvShowDogs.Columns[0].Name = "Name";
            gvShowDogs.Columns[1].Name = "Neck Circum";
            gvShowDogs.Columns[2].Name = "Sitting";
            gvShowDogs.Columns[3].Name = "Weight";
            gvShowDogs.Columns[4].Name = "Color";

            gvShowDogs.Columns[1].DefaultCellStyle.Format = "#.00";
            gvShowDogs.Columns[3].DefaultCellStyle.Format = "#.00";
        }
    }
}
