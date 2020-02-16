using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctlPostExcerptLib
{
    public partial class ctlPostExcerpt: UserControl
    {
        private string titleText;        
        private string titleFont;
        private Single titleFontSize;
        private string dateText;
        private string dateFont;
        private Single dateFontSize;
        private string contentText;
        private string contentFont;
        private Single contentFontSize;
        

        public string TitleText
        {
            get { return titleText; }
            set { titleText = value;
                labelPostTitle.Text = titleText;
                }
        }
        public string TitleFont
        {
            get { return titleFont; }
            set { titleFont = value;
                labelPostTitle.Font = new Font(titleFont,titleFontSize);
                }
        }
        public Single TitleFontSize
        {
            get { return titleFontSize; }
            set { titleFontSize = value; }
        }
        
        public string DateText
        {
            get { return dateText; }
            set { dateText = value;
                labelPostDate.Text = dateText;
                }
        }
        public string DateFont
        {
            get { return dateFont; }
            set { dateFont = value;
                labelPostDate.Font = new Font(dateFont, dateFontSize); }
        }
        public Single DateFontSize
        {
            get { return dateFontSize; }
            set { dateFontSize = value; }
        }

        public string ContentText
        {
            get { return contentText; }
            set { contentText = value;
                textBoxPostContent.Text = contentText;
                }
        }
        public string ContentFont
        {
            get { return contentFont; }
            set { contentFont = value;
                textBoxPostContent.Font = new Font(contentFont, contentFontSize);
                }
        }
        public Single ContentFontSize
        {
            get { return contentFontSize; }
            set { contentFontSize = value; }
        }

        public ctlPostExcerpt()
        {
            InitializeComponent();
        }
    }
}
