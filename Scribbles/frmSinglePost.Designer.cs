namespace Scribbles
{
    partial class frmSinglePost
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPostTitle = new System.Windows.Forms.Label();
            this.labelPostDate = new System.Windows.Forms.Label();
            this.headerMenu = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripBottomMenu = new System.Windows.Forms.MenuStrip();
            this.exitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.richTextBoxPostContent = new System.Windows.Forms.RichTextBox();
            this.headerMenu.SuspendLayout();
            this.menuStripBottomMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPostTitle
            // 
            this.labelPostTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPostTitle.AutoSize = true;
            this.labelPostTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.labelPostTitle.Location = new System.Drawing.Point(74, 147);
            this.labelPostTitle.Name = "labelPostTitle";
            this.labelPostTitle.Size = new System.Drawing.Size(151, 30);
            this.labelPostTitle.TabIndex = 0;
            this.labelPostTitle.Text = "Title Of Post";
            // 
            // labelPostDate
            // 
            this.labelPostDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPostDate.AutoSize = true;
            this.labelPostDate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.labelPostDate.Location = new System.Drawing.Point(600, 127);
            this.labelPostDate.Name = "labelPostDate";
            this.labelPostDate.Size = new System.Drawing.Size(64, 16);
            this.labelPostDate.TabIndex = 2;
            this.labelPostDate.Text = "Jan 1,2019";
            // 
            // headerMenu
            // 
            this.headerMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.newPostToolStripMenuItem});
            this.headerMenu.Location = new System.Drawing.Point(0, 0);
            this.headerMenu.Name = "headerMenu";
            this.headerMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.headerMenu.Size = new System.Drawing.Size(804, 29);
            this.headerMenu.TabIndex = 3;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 25);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // newPostToolStripMenuItem
            // 
            this.newPostToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.newPostToolStripMenuItem.Name = "newPostToolStripMenuItem";
            this.newPostToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.newPostToolStripMenuItem.Text = "New Post";
            this.newPostToolStripMenuItem.Click += new System.EventHandler(this.newPostToolStripMenuItem_Click);
            // 
            // menuStripBottomMenu
            // 
            this.menuStripBottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStripBottomMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripBottomMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitAppToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStripBottomMenu.Location = new System.Drawing.Point(0, 832);
            this.menuStripBottomMenu.Name = "menuStripBottomMenu";
            this.menuStripBottomMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStripBottomMenu.Size = new System.Drawing.Size(804, 29);
            this.menuStripBottomMenu.TabIndex = 12;
            this.menuStripBottomMenu.Text = "menuStrip1";
            // 
            // exitAppToolStripMenuItem
            // 
            this.exitAppToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.exitAppToolStripMenuItem.Name = "exitAppToolStripMenuItem";
            this.exitAppToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.exitAppToolStripMenuItem.Text = "Exit App";
            this.exitAppToolStripMenuItem.Click += new System.EventHandler(this.exitAppToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.buttonPrevious.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevious.ForeColor = System.Drawing.Color.White;
            this.buttonPrevious.Location = new System.Drawing.Point(287, 751);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(102, 48);
            this.buttonPrevious.TabIndex = 1;
            this.buttonPrevious.Text = "< Previous";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.buttonNext.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(419, 751);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(102, 48);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Next >";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // richTextBoxPostContent
            // 
            this.richTextBoxPostContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxPostContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.richTextBoxPostContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxPostContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.richTextBoxPostContent.Location = new System.Drawing.Point(79, 206);
            this.richTextBoxPostContent.Name = "richTextBoxPostContent";
            this.richTextBoxPostContent.ReadOnly = true;
            this.richTextBoxPostContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxPostContent.Size = new System.Drawing.Size(585, 499);
            this.richTextBoxPostContent.TabIndex = 16;
            this.richTextBoxPostContent.TabStop = false;
            this.richTextBoxPostContent.Text = "";
            // 
            // frmSinglePost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(804, 861);
            this.Controls.Add(this.richTextBoxPostContent);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.menuStripBottomMenu);
            this.Controls.Add(this.headerMenu);
            this.Controls.Add(this.labelPostDate);
            this.Controls.Add(this.labelPostTitle);
            this.Name = "frmSinglePost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scribbles | Post Name";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.headerMenu.ResumeLayout(false);
            this.headerMenu.PerformLayout();
            this.menuStripBottomMenu.ResumeLayout(false);
            this.menuStripBottomMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip headerMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPostToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripBottomMenu;
        private System.Windows.Forms.ToolStripMenuItem exitAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.Label labelPostTitle;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        public System.Windows.Forms.RichTextBox richTextBoxPostContent;
        public System.Windows.Forms.Label labelPostDate;
    }
}