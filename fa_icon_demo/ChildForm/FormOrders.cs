using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fa_icon_demo.DbHelper;
namespace fa_icon_demo.NewFolder1
{
    public partial class FormOrders : Form
    {
        Helpers db;
        public FormOrders()
        {
            InitializeComponent();
            db= new Helpers();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            db.getButtons("select name, price, image, Skins.skin_id from images_and_storage join Skins on images_and_storage.skin_id= Skins.skin_id", pnlOders);
        }






    }
}
