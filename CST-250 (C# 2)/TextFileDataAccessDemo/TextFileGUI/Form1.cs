using TextFileDataAccessDemo;

namespace TextFileGUI
{
    public partial class Form1 : Form
    {
        List<Person> Persons = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Utility Method to Update GUI 
        /// </summary>
        private void UpdateGUIList()
        {
            // Reset List Box
            lboxPeople.Items.Clear();

            // Add Current List
            foreach (Person person in Persons)
            {
                lboxPeople.Items.Add(String.Format("{0} {1}, {2}", person.FirstName, person.LastName, person.Url));
            }
        }



        /// <summary>
        /// Method to Handle Adding new Person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNewPerson_ClickEventHandler(object sender, EventArgs e)
        {
            // Valid Input Checking
            bool isValid = true;
            if (txtFirstName.Text == "")
            {
                lblFirstName.ForeColor = Color.Red;
                isValid = false;
            }
            else { lblFirstName.ForeColor = Color.Black; isValid = true; }

            if (txtLastName.Text == "")
            {
                lblLastName.ForeColor = Color.Red;
                isValid = false;
            }
            else { lblLastName.ForeColor = Color.Black; isValid = true; }

            if (txtURL.Text == "")
            {
                lblURL.ForeColor = Color.Red;
                isValid = false;
            }
            else { lblURL.ForeColor = Color.Black; isValid = true; }

            // Person Addition
            if (isValid)
            {
                Person p = new Person();
                p.FirstName = txtFirstName.Text;
                p.LastName = txtLastName.Text;
                p.Url = txtURL.Text;
                Persons.Add(p);
                UpdateGUIList();

                // 'Reset' Text Boxes
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtURL.Text = "";
            }
        }

        private void FileBtnClicked_EventHandler(object sender, EventArgs e)
        {
            // Figure out Which Button
            Button btn = (Button)sender;
            string btnName = btn.Name;

            string filePath = @"E:\demos\test.txt";
            if (btnName == "btnSaveToFile")
            {
                // Format Output
                List<String> outputLines = new List<String>();
                foreach (Person person in Persons)
                {
                    outputLines.Add(String.Format("{0}, {1}, {2}", person.FirstName, person.LastName, person.Url));
                }

                // Write to File
                File.WriteAllLines(filePath, outputLines);

            }
            else if (btnName == "btnLoadFromFile")
            {
                // Clear Persons List
                Persons.Clear();

                // Load File
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] att = line.Split(',');
                    Person p = new Person();
                    p.FirstName = att[0].Trim();
                    p.LastName = att[1].Trim();
                    p.Url = att[2].Trim();
                    Persons.Add(p);
                }

                // Update GUI
                UpdateGUIList();
            }
        }
    }
}