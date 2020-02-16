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
    public partial class frmPostEditor : Form
    {
        
        DateTime date1 = new DateTime();
        string date;
        string datef;
        string title;
        string content;
        public string fileName;

        public DateTime Date1 { get => date1; set => date1 = value; }

        public frmPostEditor()
        {
            InitializeComponent();
            //Apply user settings to this form.
            string tFont, tSize, cFont, cSize, shDate;
            GetSettings(out tFont, out tSize, out cFont, out cSize, out shDate);
            textBoxTitle.Font = new Font(tFont, Convert.ToSingle(tSize));
            richTextBoxContent.Font = new Font(cFont, Convert.ToSingle(cSize));
            //labelPostDate.Visible = Convert.ToBoolean(shDate);
        }
        

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help myHelp = new Help();
            myHelp.ShowDialog();
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin myAdmin = new frmAdmin();
            myAdmin.ShowDialog();
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClearForm_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = null;
            richTextBoxContent.Text = null;
            dateTimePicker1.Value = DateTime.Now;
        }

        //Save the data in the form to a file in a specific format to be parsed out later.
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Date1 = dateTimePicker1.Value;
            datef = Date1.ToString("yyyyMMddHHmmss");
            date = Date1.ToString("dddd, MMMM dd yyyy");
            title = textBoxTitle.Text;
            content = richTextBoxContent.Text;
            if(fileName == null)
                fileName = "post" + datef + ".txt";

            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText(fileName);
                outputFile.WriteLine(fileName + '^');
                outputFile.WriteLine(date + '^');
                outputFile.WriteLine(title + '^');
                outputFile.WriteLine(content);

                outputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Post has been saved.","Success");
           
        }
        

        private void exitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPostEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
           
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

        private void newPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = null;
            richTextBoxContent.Text = null;
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
