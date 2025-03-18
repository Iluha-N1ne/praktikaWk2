using System.Windows.Forms;
using SPO;

namespace praktikaWk2.mainPage
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }
        bool change;

        private void mainPage_Load(object sender, System.EventArgs e)
        {
            hiLbl.Text = $"Здравствуйте, {Transfer._Name}";
        }

        private void makePurchaseBtn_Click(object sender, System.EventArgs e)
        {

            orderPage.orderPage transfer = new orderPage.orderPage();
            Transfer.User.change = false;
            transfer.Show();
        }

        private void commitPurchaseBtn_Click(object sender, System.EventArgs e)
        {

            orderPage.orderPage transfer = new orderPage.orderPage();
            Transfer.User.change = true;
            transfer.Show();
        }
    
    }
}