namespace ctlPostExcerptLib
{
    partial class ctlPostExcerpt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPostTitle = new System.Windows.Forms.Label();
            this.labelPostDate = new System.Windows.Forms.Label();
            this.textBoxPostContent = new System.Windows.Forms.TextBox();
            this.linkLabelReadMore = new System.Windows.Forms.LinkLabel();
            this.linkLabelEdit = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelPostTitle
            // 
            this.labelPostTitle.AutoSize = true;
            this.labelPostTitle.Location = new System.Drawing.Point(32, 35);
            this.labelPostTitle.Name = "labelPostTitle";
            this.labelPostTitle.Size = new System.Drawing.Size(48, 13);
            this.labelPostTitle.TabIndex = 0;
            this.labelPostTitle.Text = "PostTitle";
            // 
            // labelPostDate
            // 
            this.labelPostDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPostDate.AutoSize = true;
            this.labelPostDate.Location = new System.Drawing.Point(581, 34);
            this.labelPostDate.Name = "labelPostDate";
            this.labelPostDate.Size = new System.Drawing.Size(51, 13);
            this.labelPostDate.TabIndex = 1;
            this.labelPostDate.Text = "PostDate";
            // 
            // textBoxPostContent
            // 
            this.textBoxPostContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPostContent.BackColor = System.Drawing.Color.White;
            this.textBoxPostContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPostContent.Location = new System.Drawing.Point(35, 69);
            this.textBoxPostContent.Multiline = true;
            this.textBoxPostContent.Name = "textBoxPostContent";
            this.textBoxPostContent.Size = new System.Drawing.Size(587, 98);
            this.textBoxPostContent.TabIndex = 2;
            // 
            // linkLabelReadMore
            // 
            this.linkLabelReadMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabelReadMore.AutoSize = true;
            this.linkLabelReadMore.Location = new System.Drawing.Point(32, 172);
            this.linkLabelReadMore.Name = "linkLabelReadMore";
            this.linkLabelReadMore.Size = new System.Drawing.Size(57, 13);
            this.linkLabelReadMore.TabIndex = 3;
            this.linkLabelReadMore.TabStop = true;
            this.linkLabelReadMore.Text = "ReadMore";
            // 
            // linkLabelEdit
            // 
            this.linkLabelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelEdit.AutoSize = true;
            this.linkLabelEdit.Location = new System.Drawing.Point(597, 172);
            this.linkLabelEdit.Name = "linkLabelEdit";
            this.linkLabelEdit.Size = new System.Drawing.Size(25, 13);
            this.linkLabelEdit.TabIndex = 4;
            this.linkLabelEdit.TabStop = true;
            this.linkLabelEdit.Text = "Edit";
            // 
            // ctlPostExcerpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabelEdit);
            this.Controls.Add(this.linkLabelReadMore);
            this.Controls.Add(this.textBoxPostContent);
            this.Controls.Add(this.labelPostDate);
            this.Controls.Add(this.labelPostTitle);
            this.Name = "ctlPostExcerpt";
            this.Size = new System.Drawing.Size(658, 204);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPostTitle;
        private System.Windows.Forms.Label labelPostDate;
        private System.Windows.Forms.TextBox textBoxPostContent;
        private System.Windows.Forms.LinkLabel linkLabelReadMore;
        private System.Windows.Forms.LinkLabel linkLabelEdit;
    }
}
