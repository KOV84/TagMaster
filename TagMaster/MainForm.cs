using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Vision.V1;
using TagMaster_BL;

namespace TagMaster
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTagImage_Click(object sender, EventArgs e)
        {
            
            var labels = GoogleClasses.GVisionFactory.createGVisionLabels(ImageFactory.ConvertImageToBytes(imgSelectedImage.Image), (int)nbrOfTagsRequested.Value);
            TagList data = new TagList(); 

            foreach (var label in labels)
            {
                data.Rows.Add(ImageFactory.ConvertImageToShortenedBase64(imgSelectedImage.Image), label.Description, label.Score);
                //Console.WriteLine($"{label.Description} ({(int)(label.Score * 100)}%)");
            }

            data.DefaultView.Sort = "GV_Confidence DESC";
            grdTags.DataSource = data;
            

        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectImage = new OpenFileDialog();
            if (selectImage.ShowDialog() == DialogResult.OK)
                imgSelectedImage.Image = new Bitmap(selectImage.FileName);
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void grdTags_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

           // Console.WriteLine(grdTags.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnDBTest_Click(object sender, EventArgs e)
        {
            var csb = new System.Data.SqlClient.SqlConnectionStringBuilder
            {
                DataSource = "(localdb)\\MSSQLLocalDB",
                IntegratedSecurity = true,
                InitialCatalog = "TagMaster"
            };

            var connection = new System.Data.SqlClient.SqlConnection(csb.ConnectionString);
            connection.Open();
            MessageBox.Show("Connection succeeded!");
            connection.Close();
            connection.Dispose();
        }

        private void btnTagText_Click(object sender, EventArgs e)
        {
            grdTags.DataSource = GoogleClasses.GLanguageFactory.createGLanguageLabels(txtTextInput.Text);   
        }
    }
}
