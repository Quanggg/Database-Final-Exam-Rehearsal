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
        public MainForm()
        {
            InitializeComponent();
            initDataForMusicMenu();            
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
            Test testForm = new Test();
            openChildForm(testForm);
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
            panelMain.Controls.Clear();
            panelMain.Controls.Add(childForm);
            childForm.Show();
        }
      
        private void menuStripItemMusic_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            textBox1.Text = e.ClickedItem.Text;
        }
    }
}
