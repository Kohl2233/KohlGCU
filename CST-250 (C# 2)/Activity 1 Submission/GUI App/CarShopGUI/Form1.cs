using CarClassLibrary;
namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store store = new Store();
        BindingSource CarListBinding = new BindingSource();
        BindingSource ShoppingListBinding = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            setBindings();
        }

        private void setBindings()
        {
            CarListBinding.DataSource = store.CarsList;
            ShoppingListBinding.DataSource = store.ShoppingList;
            lbInventory.DataSource = CarListBinding;
            lbInventory.DisplayMember = "Display";
            lbInventory.ValueMember = "Display";
            lbShoppingCart.DataSource = ShoppingListBinding;
            lbShoppingCart.DisplayMember = "Display";
            lbShoppingCart.ValueMember = "Display";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Car newCar = new Car();
                newCar.Make = txtMake.Text;
                newCar.Model = txtModel.Text;
                newCar.Price = Decimal.Parse(txtPrice.Text);
                newCar.Color = txtColor.Text;
                newCar.Year = int.Parse(txtYear.Text);

                store.CarsList.Add(newCar);

                CarListBinding.ResetBindings(false);
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            store.ShoppingList.Add((Car)lbInventory.SelectedItem);
            ShoppingListBinding.ResetBindings(false);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            decimal total = store.checkout();
            lblTotal.Text = total.ToString();
        }
    }
}