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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            //Load user settings and apply to form.
            string tFont, tSize, cFont, cSize, shDate;
            GetSettings(out tFont, out tSize, out cFont, out cSize, out shDate);
            textBoxTitleFont.Text = tFont;
            textBoxTitleFontSize.Text = tSize;
            textBoxContentFontName.Text = cFont;
            textBoxContentFontSize.Text = cSize;
            checkBoxShowDates.Checked = Convert.ToBoolean(shDate);
            textBoxTitleSample.Font = new Font(tFont, Convert.ToSingle(tSize));
            textBoxContentSample.Font = new Font(cFont, Convert.ToSingle(cSize));
        }

        //Open Font Dialog for Title options and set Title variables.
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result1 = fontDialog1.ShowDialog();
            if (result1 == DialogResult.OK)
            {
                textBoxTitleSample.Font = fontDialog1.Font;
                textBoxTitleFont.Text = fontDialog1.Font.Name;
                textBoxTitleFontSize.Text = fontDialog1.Font.Size.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help myHelp = new Help();
            myHelp.ShowDialog();
            this.Close();
        }

        private void newPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPostEditor myPostEditor = new frmPostEditor();
            myPostEditor.ShowDialog();
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Open Font Dialog for Content options and set Content variables.
        private void buttonChangeContentFont_Click(object sender, EventArgs e)
        {
            DialogResult result2 = fontDialog1.ShowDialog();
            if (result2 == DialogResult.OK)
            {
                textBoxContentSample.Font = fontDialog1.Font;
                textBoxContentFontName.Text = fontDialog1.Font.Name;
                textBoxContentFontSize.Text = fontDialog1.Font.Size.ToString();
            }
        }

        //Save any changes to user settings to a file named settings.txt
        private void buttonSaveSettingsChanges_Click(object sender, EventArgs e)
        {
            string titleFont, titleSize, contentFont, contentSize;
            bool showDate;
            titleFont = textBoxTitleFont.Text;
            titleSize = textBoxTitleFontSize.Text;
            contentFont = textBoxContentFontName.Text;
            contentSize = textBoxContentFontSize.Text;
            showDate = checkBoxShowDates.Checked;

            SaveSettings(titleFont, titleSize, contentFont, contentSize, showDate);
            
        }
        public static void SaveSettings(string tFont, string tSize, string cFont, string cSize, bool date)
        {
            
            try
            {

                string fileName = "settings.txt";
                StreamWriter outputFile;
                outputFile = File.CreateText(fileName);
                outputFile.WriteLine(tFont + '^' + tSize + '^' + cFont + '^' + cSize + '^' + date);         

                outputFile.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            MessageBox.Show("Settings saved.","Success");
            

        }
        //Get the user-saved settings from the 'settings.txt' file. Use default settings if the file has null fields.
        private static void GetSettings(out string tFont, out string tSize, out string cFont, out string cSize, out string shDate)
        {

            string settingsFile = "settings.txt";
            string settings;
            string[] settingsArray;
            char[] separator = new char[] { '^' };

            //Read the settings.txt file.
            StreamReader inputFile;
            inputFile = File.OpenText(settingsFile);
            settings = inputFile.ReadToEnd();
            inputFile.Close();

            //Split the settings file into an array.
            settingsArray = settings.Split(separator, StringSplitOptions.None);
            //Set up fallback values for fonts if the array has null values            
            if (settingsArray[0] != null)
                tFont = settingsArray[0];
            else
                tFont = "Century Gothic";
            if (settingsArray[1] != null)
                tSize = settingsArray[1];
            else
                tSize = "16";
            if (settingsArray[2] != null)
                cFont = settingsArray[2];
            else
                cFont = "Century Gothic";
            if (settingsArray[3] != null)
                cSize = settingsArray[3];
            else
                cSize = "12";
            shDate = settingsArray[4];
        }
    }
}
