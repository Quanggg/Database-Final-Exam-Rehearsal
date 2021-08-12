using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Final_Exam_Rehearsal
{
    public partial class MainForm : Form
    {
        SQLHelper sqlHelper;
        public MainForm()
        {
            InitializeComponent();
            initDataForMusicMenu();
            sqlHelper = new SQLHelper();
        }

        private void initDataForMusicMenu()
        {
            string[] origins = new string[3] { "ba", "ca", "da" };
            foreach (var origin in origins)
            {
                ToolStripItem subItem = new ToolStripMenuItem(origin);
                menuStripItemMusic.DropDownItems.Add(subItem);
            }
        }

        private void menuStripItemIntroduction_Click(object sender, EventArgs e)
        {
            formIntroduction newForm = new formIntroduction();
            openChildForm(newForm);
        }

        Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            childForm.Show();
        }
      
        private void menuStripItemMusic_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DataSet dataSet = new DataSet();
            sqlHelper.getMusicOrigin(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
