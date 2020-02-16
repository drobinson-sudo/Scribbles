using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scribbles
{
    class Post 
    {
        private string postFileName;
        private string postTitle;
        private string postDate;
        private string postContent;
        private string postExcerpt;

        public string PostFileName
        {
            get { return postFileName; }
            set { postFileName = value; }
        }
        public string PostTitle
        {
            get { return postTitle; }
            set { postTitle = value; }
        }
        public string PostDate
        {
            get { return postDate; }
            set { postDate = value; }
        }
        public string PostContent
        {
            get { return postContent; }
            set { postContent = value; }
        }
        public string PostExcerpt
        {
            get { return postExcerpt; }
            set { postExcerpt = GetPostExcerpt(PostContent); }
        }

        public string GetPostExcerpt(string content)
        {
            return content.Substring(0, Math.Min(content.Length, 300));
        }

        
    }
}
