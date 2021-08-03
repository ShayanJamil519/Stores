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
    public partial class ShoeStore : Form
    {
        public ShoeStore()
        {
            InitializeComponent();
        }

        private void ShoeStore_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.ShoeStore;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        int IndexOfImage = 0;
        string[] ItemName = { "Sneakers", "Flip-Flops", "Galoshes", "Crocs", "Huaraches" };
        int[] ItemPrice = { 5000, 250, 700, 600, 3250 };
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (IndexOfImage < 5)
            {
                pictureBoxShoeStore.Image = imageListShoeStore.Images[IndexOfImage];
                pictureBoxShoeStore.SizeMode = PictureBoxSizeMode.StretchImage;
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
            pictureBoxShoeStore.Image = imageListShoeStore.Images[IndexOfImage];
            pictureBoxShoeStore.SizeMode = PictureBoxSizeMode.StretchImage;
            labelItem.Text = "Item Name: " + ItemName[IndexOfImage];
            labelItemPrice.Text = "Price: " + ItemPrice[IndexOfImage].ToString();
        }

        private void timerShoeStore_Tick(object sender, EventArgs e)
        {
            textBoxETshoe.Text = DateTime.Now.ToLongTimeString();
            textBoxEDshoe.Text = DateTime.Now.ToLongDateString();
        }
        private void buttonExitShoeStore_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
