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
    public partial class ProductUC : UserControl
    {

        public string Name
        {
            get { return namelbl.Text; }
            set { namelbl.Text = value; }
        }


        public string Description
        {
            get { return descriptionlbl.Text; }
            set { descriptionlbl.Text = value; }
        }


        public string Price
        {
            get { return pricelbl.Text; }
            set { pricelbl.Text = $"$ {value}"; }
        }


        public Image ProductImage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }


        public ProductUC()
        {
            InitializeComponent();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.Manual;
            int x = 800; 
            int y = 200; 
            form2.Location = new Point(this.Location.X + x, this.Location.Y + y);
            form2.ShowDialog();

            namelbl.Text = form2.UpdatedName;
            descriptionlbl.Text = form2.UpdatedDescription;
            pricelbl.Text = form2.UpdatedPrice;

            form2.Dispose();
        }
    }
}
