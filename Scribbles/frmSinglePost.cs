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
    public partial class frmSinglePost : Form
    {
        List<Post> currentPostList = new List<Post>();

        public frmSinglePost()
        {
            InitializeComponent();
            //Get the List of posts for index purposes to use 'Previous' and 'Next' buttons.
            GetFileList();
            //Apply user settings to this form.
            string tFont, tSize, cFont, cSize, shDate;
            GetSettings(out tFont, out tSize, out cFont, out cSize, out shDate);
            labelPostTitle.Font = new Font(tFont, Convert.ToSingle(tSize));
            richTextBoxPostContent.Font = new Font(cFont, Convert.ToSingle(cSize));
            labelPostDate.Visible = Convert.ToBoolean(shDate);
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

        private void exitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        //Get an array of post filenames.
        protected void GetFileList()
        {
            string[] postFileNames;
            postFileNames = frmHome.GetPostFileList();
            currentPostList = GetPostObjects(postFileNames);
            currentPostList.Reverse();
            int listCount = currentPostList.Count;
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

        //Compare currently loaded post date to dates in the List of Post objects
        private int FindThisPostIndex(List<Post> list, string title)
        {
            int x = list.FindIndex(r =>  r.PostTitle == title);
            return x;
        }

        //Find index of current post and display next(list is in reverse order)
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            int index = FindThisPostIndex(currentPostList, labelPostTitle.Text);
            if (index != -1 && index < currentPostList.Count - 1)
            {
                index += 1;
                labelPostTitle.Text = currentPostList[index].PostTitle;
                labelPostDate.Text = currentPostList[index].PostDate;
                richTextBoxPostContent.Text = currentPostList[index].PostContent;
            }
        }

        //Find indes of current post and display previous(list is in reverse order)
        private void buttonNext_Click(object sender, EventArgs e)
        {
            int index = FindThisPostIndex(currentPostList, labelPostTitle.Text);
            if (index != -1 && index >0)
            {
                index -= 1;
                labelPostTitle.Text = currentPostList[index].PostTitle;
                labelPostDate.Text = currentPostList[index].PostDate;
                richTextBoxPostContent.Text = currentPostList[index].PostContent;
            }
        }
    }
}
