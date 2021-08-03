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
    public partial class Form1 : Form
    {
        ClothingStore clothstore = new ClothingStore();
        ShoeStore shoestore = new ShoeStore();
        GroceryStore grocstore = new GroceryStore();
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonClothingStore_Click(object sender, EventArgs e)
        {
            clothstore.Show();
            shoestore.Hide();
            grocstore.Hide();
         }
        private void buttonShoesStore_Click(object sender, EventArgs e)
        {
            shoestore.Show();
            clothstore.Hide();
            grocstore.Hide();
        }
        private void buttonGroceryStore_Click(object sender, EventArgs e)
        {
            grocstore.Show();
            shoestore.Hide();
            clothstore.Hide();
        }
    }
}
