using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestStoreWinforms
{
    public partial class Form3 : Form
    {
        public event EventHandler<Product> ProductAdded;

        public Form3()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product
            {
                Name = newNameTxtb.Text,
                Description = newdescriptionTxtb.Text,
                Price = Convert.ToDecimal(newmaskedTextBoxPrice.Text),
                Image=Properties.Resources.asus_removebg_preview_removebg_preview,
            };
            ProductAdded?.Invoke(this, newProduct);
            this.Close();
        }
    }
}
