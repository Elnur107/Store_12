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
    public partial class Form2 : Form
    {
        public string UpdatedName { get; private set; }
        public string UpdatedDescription { get; private set; }
        public string UpdatedPrice { get; private set; }


        public Form2()
        {
            InitializeComponent();
        }

        private void update2_Click(object sender, EventArgs e)
        {
            UpdatedName=nameTxtb.Text;
            UpdatedDescription=descriptionTxtb.Text;
            UpdatedPrice=maskedTextBoxPrice.Text;
            this.Close();
        }
    }
}
