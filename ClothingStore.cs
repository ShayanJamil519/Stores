using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stores
{
    public partial class ClothingStore : Form
    {
        public ClothingStore()
        {
            InitializeComponent();
        }
        private void ClothingStore_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.ClothingStore;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        int IndexOfImage = 0;
        string[] ItemName = { "Polo-shirt", "Flannel Shirt", "Linen Shirts", "Polo Shirt.", "Denim Shirt" };
        int[] ItemPrice = { 1000, 800, 700, 300, 1200 };
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (IndexOfImage < 5)
            {
                pictureBoxClothingStore.Image = imageListClothingStore.Images[IndexOfImage];
                pictureBoxClothingStore.SizeMode = PictureBoxSizeMode.StretchImage;
                labelItem.Text ="Item Name: "+ ItemName[IndexOfImage];
                labelItemPrice.Text ="Price: "+ ItemPrice[IndexOfImage].ToString();
                IndexOfImage++;
            }
        }
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (IndexOfImage > 0)
            {
                IndexOfImage--;
            }
            pictureBoxClothingStore.Image = imageListClothingStore.Images[IndexOfImage];
            pictureBoxClothingStore.SizeMode = PictureBoxSizeMode.StretchImage;
            labelItem.Text = "Item Name: " + ItemName[IndexOfImage];
            labelItemPrice.Text = "Price: " + ItemPrice[IndexOfImage].ToString();
        }
        private void timerClothingStore_Tick(object sender, EventArgs e)
        {
            textBoxETclothing.Text = DateTime.Now.ToLongTimeString();
            textBoxEDclothing.Text = DateTime.Now.ToLongDateString();
        }
        private void buttonExitClothingStore_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
