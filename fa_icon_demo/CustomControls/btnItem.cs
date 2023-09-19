using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fa_icon_demo.CustomControls
{

    public partial class btnItem : UserControl
    {
        public string ItemId
        { get; set; }
        public string itemName
        {
            get
            { return ItemName.Text; }
            set { ItemName.Text = value; }
        }
        public string itemPrice
        {
            get { return ItemPrice.Text; }
            set { ItemPrice.Text = value; }

        }
        public Image itemImage { get { return ItemImages.Image; } set { ItemImages.Image = value; } }
        public btnItem()
        {
            InitializeComponent();
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ItemName.Text.ToString());
        }
    }
}
