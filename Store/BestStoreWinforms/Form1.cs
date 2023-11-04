using Guna.UI2.WinForms.Helpers;
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
    public partial class Form1 : Form
    {

        List<Product> Products {  get; set; }

        public Form1()
        {
            InitializeComponent();

            Products = new List<Product>
            {
                new Product
                {
                    Name="Acer",
                    Image=Properties.Resources.acer_removebg_preview_removebg_preview,
                    Description="8gb ran,256Gb SSD",
                    Price=1200,
                },
                new Product
                {
                    Name="MacPro",
                    Image=Properties.Resources.mac_removebg_preview_removebg_preview,
                    Description="16gb ram,512Gb SSD",
                    Price=1800,
                },
                new Product
                {
                    Name="HP",
                    Image=Properties.Resources.hp_removebg_preview_removebg_preview,
                    Description="32gb ram,128Gb SSD",
                    Price=3000,
                },
                new Product
                {
                    Name="Lenovo",
                    Image=Properties.Resources.lenove_removebg_preview_removebg_preview,
                    Description="8gb ram,1TB SSD",
                    Price=1000,
                },
            };

            int x=0; int y=0;
            foreach(var item in Products)
            {
                ProductUC uc= new ProductUC();
                uc.Name = item.Name;
                uc.Description = item.Description;
                uc.Price=item.Price.ToString();
                uc.ProductImage = item.Image;
                uc.Location=new Point(x, y);
                y += 101;
                this.panel2.Controls.Add(uc);
            }
        }

        private void addNewProductBtn_Click(object sender, EventArgs e)
        {
            
            Form3 form3 = new Form3();
            form3.ProductAdded += (s, product) =>
            {
                Products.Add(product);
                RefreshProductList();
            };
            form3.ShowDialog();
        }

       

        private void RefreshProductList()
        {
            this.panel2.Controls.Clear();
            int x = 0;
            int y = 0;
            foreach (var item in Products)
            {
                ProductUC uc = new ProductUC();
                uc.Name = item.Name;
                uc.Description = item.Description;
                uc.Price = item.Price.ToString();
                uc.ProductImage = item.Image;
                uc.Location = new Point(x, y);
                y += 101;
                this.panel2.Controls.Add(uc);
            }
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            PanelScrollHelper panelScrollHelper = new PanelScrollHelper(panel2, vScrollBar1, true);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
