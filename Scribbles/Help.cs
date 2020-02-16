using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Scribbles
{
    public partial class Help : Form
    {
        string[] helpDocs;
        public Help()
        {
            InitializeComponent();
        }        

        private void newPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPostEditor myPostEditor = new frmPostEditor();
            this.Close();
            myPostEditor.ShowDialog();            
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin myAdmin = new frmAdmin();
            this.Close();
            myAdmin.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void exitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Load the file with help docs and split it into an array of strings.
        private void Help_Load(object sender, EventArgs e)
        {
           string helpFile;

            StreamReader inputFile;
            inputFile = File.OpenText("helpdocs.txt");
            helpFile = inputFile.ReadToEnd();
            inputFile.Close();

            char[] separators = new char[] { '`' };
            helpDocs = helpFile.Split(separators, StringSplitOptions.None);
        }

        private void radioButtonHelpAbout_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHelpTopic.Text = helpDocs[0];
        }

        private void radioButtonHelpNavigating_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHelpTopic.Text = helpDocs[1];
        }

        private void radioButtonHelpHome_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHelpTopic.Text = helpDocs[2];
        }

        private void radioButtonHelpNewPost_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHelpTopic.Text = helpDocs[3];
        }

        private void radioButtonHelpSettings_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHelpTopic.Text = helpDocs[4];
        }

        private void radioButtonHelpHelp_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHelpTopic.Text = helpDocs[5];
        }

        private void radioButtonSinglePost_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHelpTopic.Text = helpDocs[6];
        }

        private void radioButtonHelpEditPost_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHelpTopic.Text = helpDocs[7];
        }

        private void radioButtonHelpClose_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHelpTopic.Text = helpDocs[8];
        }

        private void radioButtonHelpDev_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHelpTopic.Text = helpDocs[9].ToString();
        }
    }
}
