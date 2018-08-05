//Name: Ray Ketcham
//Date: 08/05/2018
//Instructor: Dr. Smithers
//Class: CST-117
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class formAddInventory : Form
    {
        public formAddInventory()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            string name;
            string num;
            string amount;

            name = textBoxName.Text;
            num = textBoxNum.Text;
            amount = textBoxAmount.Text;
            Inv item1 = new Inv(name, num, amount);
            MessageBox.Show(string.Format("Items {0}, {1}, {2} were added to Inventory." + "\nThere were a total of {3} items", item1.Name, item1.StockNum, item1.Amount, item1.Qty));

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}