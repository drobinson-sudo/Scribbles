namespace Scribbles
{
    partial class Help
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
            this.radioButtonHelpAbout = new System.Windows.Forms.RadioButton();
            this.groupBoxHelpTopics = new System.Windows.Forms.GroupBox();
            this.radioButtonHelpDev = new System.Windows.Forms.RadioButton();
            this.radioButtonHelpClose = new System.Windows.Forms.RadioButton();
            this.radioButtonHelpEditPost = new System.Windows.Forms.RadioButton();
            this.radioButtonSinglePost = new System.Windows.Forms.RadioButton();
            this.radioButtonHelpHelp = new System.Windows.Forms.RadioButton();
            this.radioButtonHelpSettings = new System.Windows.Forms.RadioButton();
            this.radioButtonHelpNewPost = new System.Windows.Forms.RadioButton();
            this.radioButtonHelpHome = new System.Windows.Forms.RadioButton();
            this.radioButtonHelpNavigating = new System.Windows.Forms.RadioButton();
            this.groupBoxHelpDisplay = new System.Windows.Forms.GroupBox();
            this.textBoxHelpTopic = new System.Windows.Forms.TextBox();
            this.headerMenu = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripBottomMenu = new System.Windows.Forms.MenuStrip();
            this.exitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxHelpTopics.SuspendLayout();
            this.groupBoxHelpDisplay.SuspendLayout();
            this.headerMenu.SuspendLayout();
            this.menuStripBottomMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonHelpAbout
            // 
            this.radioButtonHelpAbout.AutoSize = true;
            this.radioButtonHelpAbout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHelpAbout.Location = new System.Drawing.Point(17, 44);
            this.radioButtonHelpAbout.Name = "radioButtonHelpAbout";
            this.radioButtonHelpAbout.Size = new System.Drawing.Size(150, 25);
            this.radioButtonHelpAbout.TabIndex = 0;
            this.radioButtonHelpAbout.TabStop = true;
            this.radioButtonHelpAbout.Text = "About Scribbles";
            this.radioButtonHelpAbout.UseVisualStyleBackColor = true;
            this.radioButtonHelpAbout.CheckedChanged += new System.EventHandler(this.radioButtonHelpAbout_CheckedChanged);
            // 
            // groupBoxHelpTopics
            // 
            this.groupBoxHelpTopics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxHelpTopics.Controls.Add(this.radioButtonHelpDev);
            this.groupBoxHelpTopics.Controls.Add(this.radioButtonHelpClose);
            this.groupBoxHelpTopics.Controls.Add(this.radioButtonHelpEditPost);
            this.groupBoxHelpTopics.Controls.Add(this.radioButtonSinglePost);
            this.groupBoxHelpTopics.Controls.Add(this.radioButtonHelpHelp);
            this.groupBoxHelpTopics.Controls.Add(this.radioButtonHelpSettings);
            this.groupBoxHelpTopics.Controls.Add(this.radioButtonHelpNewPost);
            this.groupBoxHelpTopics.Controls.Add(this.radioButtonHelpHome);
            this.groupBoxHelpTopics.Controls.Add(this.radioButtonHelpNavigating);
            this.groupBoxHelpTopics.Controls.Add(this.radioButtonHelpAbout);
            this.groupBoxHelpTopics.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHelpTopics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.groupBoxHelpTopics.Location = new System.Drawing.Point(44, 70);
            this.groupBoxHelpTopics.Name = "groupBoxHelpTopics";
            this.groupBoxHelpTopics.Size = new System.Drawing.Size(251, 653);
            this.groupBoxHelpTopics.TabIndex = 1;
            this.groupBoxHelpTopics.TabStop = false;
            this.groupBoxHelpTopics.Text = "Help Topics";
            // 
            // radioButtonHelpDev
            // 
            this.radioButtonHelpDev.AutoSize = true;
            this.radioButtonHelpDev.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHelpDev.Location = new System.Drawing.Point(17, 326);
            this.radioButtonHelpDev.Name = "radioButtonHelpDev";
            this.radioButtonHelpDev.Size = new System.Drawing.Size(109, 25);
            this.radioButtonHelpDev.TabIndex = 9;
            this.radioButtonHelpDev.TabStop = true;
            this.radioButtonHelpDev.Text = "Dev Notes";
            this.radioButtonHelpDev.UseVisualStyleBackColor = true;
            this.radioButtonHelpDev.CheckedChanged += new System.EventHandler(this.radioButtonHelpDev_CheckedChanged);
            // 
            // radioButtonHelpClose
            // 
            this.radioButtonHelpClose.AutoSize = true;
            this.radioButtonHelpClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHelpClose.Location = new System.Drawing.Point(17, 294);
            this.radioButtonHelpClose.Name = "radioButtonHelpClose";
            this.radioButtonHelpClose.Size = new System.Drawing.Size(201, 25);
            this.radioButtonHelpClose.TabIndex = 8;
            this.radioButtonHelpClose.TabStop = true;
            this.radioButtonHelpClose.Text = "How to Close Scribbles";
            this.radioButtonHelpClose.UseVisualStyleBackColor = true;
            this.radioButtonHelpClose.CheckedChanged += new System.EventHandler(this.radioButtonHelpClose_CheckedChanged);
            // 
            // radioButtonHelpEditPost
            // 
            this.radioButtonHelpEditPost.AutoSize = true;
            this.radioButtonHelpEditPost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHelpEditPost.Location = new System.Drawing.Point(17, 262);
            this.radioButtonHelpEditPost.Name = "radioButtonHelpEditPost";
            this.radioButtonHelpEditPost.Size = new System.Drawing.Size(109, 25);
            this.radioButtonHelpEditPost.TabIndex = 7;
            this.radioButtonHelpEditPost.TabStop = true;
            this.radioButtonHelpEditPost.Text = "Edit a Post";
            this.radioButtonHelpEditPost.UseVisualStyleBackColor = true;
            this.radioButtonHelpEditPost.CheckedChanged += new System.EventHandler(this.radioButtonHelpEditPost_CheckedChanged);
            // 
            // radioButtonSinglePost
            // 
            this.radioButtonSinglePost.AutoSize = true;
            this.radioButtonSinglePost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSinglePost.Location = new System.Drawing.Point(17, 230);
            this.radioButtonSinglePost.Name = "radioButtonSinglePost";
            this.radioButtonSinglePost.Size = new System.Drawing.Size(166, 25);
            this.radioButtonSinglePost.TabIndex = 6;
            this.radioButtonSinglePost.TabStop = true;
            this.radioButtonSinglePost.Text = "Single Post Screen";
            this.radioButtonSinglePost.UseVisualStyleBackColor = true;
            this.radioButtonSinglePost.CheckedChanged += new System.EventHandler(this.radioButtonSinglePost_CheckedChanged);
            // 
            // radioButtonHelpHelp
            // 
            this.radioButtonHelpHelp.AutoSize = true;
            this.radioButtonHelpHelp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHelpHelp.Location = new System.Drawing.Point(17, 199);
            this.radioButtonHelpHelp.Name = "radioButtonHelpHelp";
            this.radioButtonHelpHelp.Size = new System.Drawing.Size(120, 25);
            this.radioButtonHelpHelp.TabIndex = 5;
            this.radioButtonHelpHelp.TabStop = true;
            this.radioButtonHelpHelp.Text = "Help Screen";
            this.radioButtonHelpHelp.UseVisualStyleBackColor = true;
            this.radioButtonHelpHelp.CheckedChanged += new System.EventHandler(this.radioButtonHelpHelp_CheckedChanged);
            // 
            // radioButtonHelpSettings
            // 
            this.radioButtonHelpSettings.AutoSize = true;
            this.radioButtonHelpSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHelpSettings.Location = new System.Drawing.Point(17, 168);
            this.radioButtonHelpSettings.Name = "radioButtonHelpSettings";
            this.radioButtonHelpSettings.Size = new System.Drawing.Size(147, 25);
            this.radioButtonHelpSettings.TabIndex = 4;
            this.radioButtonHelpSettings.TabStop = true;
            this.radioButtonHelpSettings.Text = "Settings Screen";
            this.radioButtonHelpSettings.UseVisualStyleBackColor = true;
            this.radioButtonHelpSettings.CheckedChanged += new System.EventHandler(this.radioButtonHelpSettings_CheckedChanged);
            // 
            // radioButtonHelpNewPost
            // 
            this.radioButtonHelpNewPost.AutoSize = true;
            this.radioButtonHelpNewPost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHelpNewPost.Location = new System.Drawing.Point(17, 137);
            this.radioButtonHelpNewPost.Name = "radioButtonHelpNewPost";
            this.radioButtonHelpNewPost.Size = new System.Drawing.Size(160, 25);
            this.radioButtonHelpNewPost.TabIndex = 3;
            this.radioButtonHelpNewPost.TabStop = true;
            this.radioButtonHelpNewPost.Text = "Create New Post";
            this.radioButtonHelpNewPost.UseVisualStyleBackColor = true;
            this.radioButtonHelpNewPost.CheckedChanged += new System.EventHandler(this.radioButtonHelpNewPost_CheckedChanged);
            // 
            // radioButtonHelpHome
            // 
            this.radioButtonHelpHome.AutoSize = true;
            this.radioButtonHelpHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHelpHome.Location = new System.Drawing.Point(17, 106);
            this.radioButtonHelpHome.Name = "radioButtonHelpHome";
            this.radioButtonHelpHome.Size = new System.Drawing.Size(131, 25);
            this.radioButtonHelpHome.TabIndex = 2;
            this.radioButtonHelpHome.TabStop = true;
            this.radioButtonHelpHome.Text = "Home Screen";
            this.radioButtonHelpHome.UseVisualStyleBackColor = true;
            this.radioButtonHelpHome.CheckedChanged += new System.EventHandler(this.radioButtonHelpHome_CheckedChanged);
            // 
            // radioButtonHelpNavigating
            // 
            this.radioButtonHelpNavigating.AutoSize = true;
            this.radioButtonHelpNavigating.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHelpNavigating.Location = new System.Drawing.Point(17, 75);
            this.radioButtonHelpNavigating.Name = "radioButtonHelpNavigating";
            this.radioButtonHelpNavigating.Size = new System.Drawing.Size(188, 25);
            this.radioButtonHelpNavigating.TabIndex = 1;
            this.radioButtonHelpNavigating.TabStop = true;
            this.radioButtonHelpNavigating.Text = "Navigating The App";
            this.radioButtonHelpNavigating.UseVisualStyleBackColor = true;
            this.radioButtonHelpNavigating.CheckedChanged += new System.EventHandler(this.radioButtonHelpNavigating_CheckedChanged);
            // 
            // groupBoxHelpDisplay
            // 
            this.groupBoxHelpDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxHelpDisplay.Controls.Add(this.textBoxHelpTopic);
            this.groupBoxHelpDisplay.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHelpDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.groupBoxHelpDisplay.Location = new System.Drawing.Point(342, 70);
            this.groupBoxHelpDisplay.Name = "groupBoxHelpDisplay";
            this.groupBoxHelpDisplay.Size = new System.Drawing.Size(390, 653);
            this.groupBoxHelpDisplay.TabIndex = 2;
            this.groupBoxHelpDisplay.TabStop = false;
            this.groupBoxHelpDisplay.Text = "Topic";
            // 
            // textBoxHelpTopic
            // 
            this.textBoxHelpTopic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHelpTopic.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHelpTopic.Location = new System.Drawing.Point(23, 44);
            this.textBoxHelpTopic.Multiline = true;
            this.textBoxHelpTopic.Name = "textBoxHelpTopic";
            this.textBoxHelpTopic.ReadOnly = true;
            this.textBoxHelpTopic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHelpTopic.Size = new System.Drawing.Size(346, 576);
            this.textBoxHelpTopic.TabIndex = 1;
            this.textBoxHelpTopic.TabStop = false;
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
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 25);
            this.helpToolStripMenuItem.Text = "Help";
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
            this.menuStripBottomMenu.TabIndex = 13;
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
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(804, 861);
            this.Controls.Add(this.menuStripBottomMenu);
            this.Controls.Add(this.headerMenu);
            this.Controls.Add(this.groupBoxHelpDisplay);
            this.Controls.Add(this.groupBoxHelpTopics);
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Help_Load);
            this.groupBoxHelpTopics.ResumeLayout(false);
            this.groupBoxHelpTopics.PerformLayout();
            this.groupBoxHelpDisplay.ResumeLayout(false);
            this.groupBoxHelpDisplay.PerformLayout();
            this.headerMenu.ResumeLayout(false);
            this.headerMenu.PerformLayout();
            this.menuStripBottomMenu.ResumeLayout(false);
            this.menuStripBottomMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonHelpAbout;
        private System.Windows.Forms.GroupBox groupBoxHelpTopics;
        private System.Windows.Forms.RadioButton radioButtonSinglePost;
        private System.Windows.Forms.RadioButton radioButtonHelpHelp;
        private System.Windows.Forms.RadioButton radioButtonHelpSettings;
        private System.Windows.Forms.RadioButton radioButtonHelpNewPost;
        private System.Windows.Forms.RadioButton radioButtonHelpHome;
        private System.Windows.Forms.RadioButton radioButtonHelpNavigating;
        private System.Windows.Forms.GroupBox groupBoxHelpDisplay;
        private System.Windows.Forms.MenuStrip headerMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPostToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripBottomMenu;
        private System.Windows.Forms.ToolStripMenuItem exitAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonHelpDev;
        private System.Windows.Forms.RadioButton radioButtonHelpClose;
        private System.Windows.Forms.RadioButton radioButtonHelpEditPost;
        private System.Windows.Forms.TextBox textBoxHelpTopic;
    }
}