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
using ctlPostExcerptLib;

namespace Scribbles
{
    public partial class frmHome : Form
    {
        
        public frmHome()
        {
            InitializeComponent();            
        }
        

        private void newPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPostEditor myPostEditor = new frmPostEditor();
            myPostEditor.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help myHelp = new Help();
            myHelp.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin myAdmin = new frmAdmin();
            myAdmin.ShowDialog();
        }

        private void exitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }    

        //A static method that can be called from other forms without an object reference to return a List of post filenames.
        public static string[] GetPostFileList()
        {
            string[] fileList;

            fileList = Directory.GetFiles(".", "post*.*");            
            Array.Sort(fileList);

            //return postFileList;
            return fileList;
        }

        //Instantiate the Post objects from the files, and add them to a List (instead of Array, because the size of the List will need to be dynamic)
        private static List<Post> GetPostObjects(string[] postFileList)
        {
            List<Post> currentPostList = new List<Post>();
            string postFile;
            string fileName, title, date, content;

            foreach (string file in postFileList)
            {
                //Open the post file, set the string 'postFile' to contents of file, then close the file.
                StreamReader inputFile;
                inputFile = File.OpenText(file);
                postFile = inputFile.ReadToEnd();
                inputFile.Close();

                //Declare the arrays needed to parse the file into substrings.
                char[] separators = new char[] { '^' };
                string[] postData;

                //Split the file string into substrings based on the delimiter declared above, and assign each substring in the new array to a unique variable.
                postData = postFile.Split(separators, StringSplitOptions.None);
                fileName = postData[0];
                date = postData[1];
                title = postData[2];
                content = postData[3];

                //Instantiate a new Post object and set the properties with the contents of the substrings parsed out above.
                Post savedPost = new Post();
                savedPost.PostFileName = fileName;
                savedPost.PostTitle = title;
                savedPost.PostDate = date;
                savedPost.PostContent = content;
                savedPost.PostExcerpt = savedPost.GetPostExcerpt(content);

                //Add the new Post object to the list of Post objects.
                currentPostList.Add(savedPost);             
                
            }
            return currentPostList;
        }

        List<Post> currentPostList = new List<Post>();
        int x = 0;
        int listCount = 0;
        int pointer = 0;

        //These actions will occur every time this form takes the Active state, keeping the list of posts fresh.
        protected void frmHome_Activated(object sender, EventArgs e)
        {
            flowLayoutPanelPostExcerpts.Controls.Clear();
            string tFont, tSize, cFont, cSize, shDate;
            string[] postFileNames;
            postFileNames = GetPostFileList();            
            currentPostList = GetPostObjects(postFileNames);
            currentPostList.Reverse();
            listCount = currentPostList.Count;
            
            

           //This loop adds the composite control 'ctlPostExcerpt' to the FlowLayoutPanel, 3 at a time.
            for (x = pointer; x < currentPostList.Count && x < (pointer + 3); x++)
            {
                ctlPostExcerpt excerpt = new ctlPostExcerpt();
                excerpt.TitleText = currentPostList[x].PostTitle;
                excerpt.DateText = currentPostList[x].PostDate;
                excerpt.ContentText = currentPostList[x].PostExcerpt;
                excerpt.FullContent = currentPostList[x].PostContent;
                excerpt.PostFileName = currentPostList[x].PostFileName;
                //Apply settings to each post excerpt.
                GetSettings(out tFont, out tSize, out cFont, out cSize, out shDate);
                excerpt.TitleFontSize = Convert.ToSingle(tSize);
                excerpt.TitleFont = tFont;
                excerpt.DateFontSize = 8;
                excerpt.DateFont = "Century Gothic";
                excerpt.ContentFontSize = Convert.ToSingle(cSize);
                excerpt.ContentFont = cFont;
                excerpt.DateVisible = Convert.ToBoolean(shDate);

                excerpt.ReadLinkClick += new EventHandler(excerpt_ReadLinkClick);
                excerpt.EditLinkClick += new EventHandler(excerpt_EditLinkClick);
                
                flowLayoutPanelPostExcerpts.Controls.Add(excerpt );               
            }
            
        }

        //Open SinglePost form and populate fields with the correct data.
        protected void excerpt_ReadLinkClick(object sender, EventArgs e)
        {
            ctlPostExcerpt excerpt = sender as ctlPostExcerpt;
            frmSinglePost mySinglePost = new frmSinglePost();
            mySinglePost.labelPostTitle.Text = excerpt.TitleText;
            mySinglePost.richTextBoxPostContent.Text = excerpt.FullContent;
            mySinglePost.labelPostDate.Text = excerpt.DateText;
            mySinglePost.ActiveControl = null;
            mySinglePost.ShowDialog();
        }

        //Open the post editor form and prepopulate the editor.
        protected void excerpt_EditLinkClick(object sender, EventArgs e)
        {
            ctlPostExcerpt excerpt = sender as ctlPostExcerpt;
            frmPostEditor myPostEditor = new frmPostEditor();
            myPostEditor.textBoxTitle.Text = excerpt.TitleText;
            myPostEditor.richTextBoxContent.Text = excerpt.FullContent;
            myPostEditor.dateTimePicker1.Value = Convert.ToDateTime(excerpt.DateText);
            myPostEditor.fileName = excerpt.PostFileName;
            myPostEditor.ActiveControl = null;
            myPostEditor.ShowDialog();
        }



        //Load 3 previous excerpts.
        private void buttonLoadOlder_Click(object sender, EventArgs e)
        {
            if(pointer < listCount)
            {
                pointer = pointer + 3;
                flowLayoutPanelPostExcerpts.Controls.Clear();
                
                this.Hide();
                this.Show();
            }
        }

        //Load 3 next excerpts.
        private void buttonLoadNewer_Click(object sender, EventArgs e)
        {
            if(pointer > 2)
            {
                pointer = pointer - 3;
                flowLayoutPanelPostExcerpts.Controls.Clear();
                
                this.Hide();
                this.Show();
            }
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

        private void frmHome_Load(object sender, EventArgs e)
        {
            
        }
    }

}
