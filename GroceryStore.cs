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
    public partial class GroceryStore : Form
    {
        public GroceryStore()
        {
            InitializeComponent();
        }

        private void GroceryStore_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.GroceryStore;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        int IndexOfImage = 0;
        string[] ItemName = { "Tomato", "Brinjal", "CauliFlower", "Potato", "Cucumber" };
        int[] ItemPrice = { 200, 50, 70, 130, 40 };
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (IndexOfImage < 5)
            {
                pictureBoxGroceryStore.Image = imageListGroceryStore.Images[IndexOfImage];
                pictureBoxGroceryStore.SizeMode = PictureBoxSizeMode.StretchImage;
                labelItem.Text = "Item Name: " + ItemName[IndexOfImage];
                labelItemPrice.Text = "Price: " + ItemPrice[IndexOfImage].ToString();
                IndexOfImage++;
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (IndexOfImage > 0)
            {
                IndexOfImage--;
            }
            pictureBoxGroceryStore.Image = imageListGroceryStore.Images[IndexOfImage];
            pictureBoxGroceryStore.SizeMode = PictureBoxSizeMode.StretchImage;
            labelItem.Text = "Item Name: " + ItemName[IndexOfImage];
            labelItemPrice.Text = "Price: " + ItemPrice[IndexOfImage].ToString();
        }
        private void timerGroceryStore_Tick(object sender, EventArgs e)
        {
            textBoxETgrocery.Text = DateTime.Now.ToLongTimeString();
            textBoxEDgrocery.Text = DateTime.Now.ToLongDateString();
        }
        private void buttonExitGroceryStore_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
