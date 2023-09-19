using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.IO;
using System.Windows.Shapes;

namespace fa_icon_demo
{
    public partial class SaveImage : Form
    {
        public SaveImage()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from images_and_storage", conn);
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                conn.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                //byte[] b = ImageToByteArray(pictureBox1.Image);
                byte[] b = PathToByteArray(this.Text);
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into images_and_storage values (@images_and_storage_id, @image,@skin_id,@user_id)", conn);

                cmd.Parameters.Add("@images_and_storage_id", textBox2.Text);
                cmd.Parameters.Add("@image", b);
                cmd.Parameters.Add("@skin_id", textBox1.Text);
                cmd.Parameters.Add("@user_id", txtname.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadData();
            }

        }
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        byte[] PathToByteArray(string path)
        {

            // MemoryStream m = new MemoryStream();
            // Image img = Image.FromFile(path);
            // img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            // return m.ToArray();

            //có the dung class File de chuyén
            return File.ReadAllBytes(path);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            byte[] b = (byte[])dataGridView1.Rows[r].Cells["image"].Value;
            pictureBox2.Image = ByteArrayToImage(b);
        }

        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m= new MemoryStream(b);
            return Image.FromStream(m);

        }
    }
}


