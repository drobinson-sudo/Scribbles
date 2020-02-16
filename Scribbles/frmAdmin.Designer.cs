namespace Scribbles
{
    partial class frmAdmin
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
            this.headerMenu = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSettings = new System.Windows.Forms.Label();
            this.groupBoxTitleSettings = new System.Windows.Forms.GroupBox();
            this.textBoxTitleSample = new System.Windows.Forms.TextBox();
            this.textBoxTitleFont = new System.Windows.Forms.TextBox();
            this.textBoxTitleFontSize = new System.Windows.Forms.TextBox();
            this.buttonChangeTitleFont = new System.Windows.Forms.Button();
            this.labelFont = new System.Windows.Forms.Label();
            this.labelTitleFontSize = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBoxContentSettings = new System.Windows.Forms.GroupBox();
            this.textBoxContentSample = new System.Windows.Forms.TextBox();
            this.textBoxContentFontName = new System.Windows.Forms.TextBox();
            this.textBoxContentFontSize = new System.Windows.Forms.TextBox();
            this.buttonChangeContentFont = new System.Windows.Forms.Button();
            this.labelContentFontName = new System.Windows.Forms.Label();
            this.labelContentFontSize = new System.Windows.Forms.Label();
            this.checkBoxShowDates = new System.Windows.Forms.CheckBox();
            this.groupBoxOtherSettings = new System.Windows.Forms.GroupBox();
            this.buttonSaveSettingsChanges = new System.Windows.Forms.Button();
            this.menuStripBottomMenu = new System.Windows.Forms.MenuStrip();
            this.exitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headerMenu.SuspendLayout();
            this.groupBoxTitleSettings.SuspendLayout();
            this.groupBoxContentSettings.SuspendLayout();
            this.groupBoxOtherSettings.SuspendLayout();
            this.menuStripBottomMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.headerMenu.TabIndex = 5;
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
            // labelSettings
            // 
            this.labelSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSettings.AutoSize = true;
            this.labelSettings.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.labelSettings.Location = new System.Drawing.Point(51, 82);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(104, 30);
            this.labelSettings.TabIndex = 3;
            this.labelSettings.Text = "Settings";
            // 
            // groupBoxTitleSettings
            // 
            this.groupBoxTitleSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxTitleSettings.Controls.Add(this.textBoxTitleSample);
            this.groupBoxTitleSettings.Controls.Add(this.textBoxTitleFont);
            this.groupBoxTitleSettings.Controls.Add(this.textBoxTitleFontSize);
            this.groupBoxTitleSettings.Controls.Add(this.buttonChangeTitleFont);
            this.groupBoxTitleSettings.Controls.Add(this.labelFont);
            this.groupBoxTitleSettings.Controls.Add(this.labelTitleFontSize);
            this.groupBoxTitleSettings.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTitleSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.groupBoxTitleSettings.Location = new System.Drawing.Point(88, 146);
            this.groupBoxTitleSettings.Name = "groupBoxTitleSettings";
            this.groupBoxTitleSettings.Size = new System.Drawing.Size(590, 176);
            this.groupBoxTitleSettings.TabIndex = 5;
            this.groupBoxTitleSettings.TabStop = false;
            this.groupBoxTitleSettings.Text = "Titles";
            // 
            // textBoxTitleSample
            // 
            this.textBoxTitleSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.textBoxTitleSample.Location = new System.Drawing.Point(271, 67);
            this.textBoxTitleSample.Name = "textBoxTitleSample";
            this.textBoxTitleSample.ReadOnly = true;
            this.textBoxTitleSample.Size = new System.Drawing.Size(295, 33);
            this.textBoxTitleSample.TabIndex = 7;
            this.textBoxTitleSample.TabStop = false;
            this.textBoxTitleSample.Text = "Sample Title Font";
            // 
            // textBoxTitleFont
            // 
            this.textBoxTitleFont.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitleFont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.textBoxTitleFont.Location = new System.Drawing.Point(114, 73);
            this.textBoxTitleFont.Name = "textBoxTitleFont";
            this.textBoxTitleFont.ReadOnly = true;
            this.textBoxTitleFont.Size = new System.Drawing.Size(126, 27);
            this.textBoxTitleFont.TabIndex = 4;
            this.textBoxTitleFont.TabStop = false;
            // 
            // textBoxTitleFontSize
            // 
            this.textBoxTitleFontSize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitleFontSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.textBoxTitleFontSize.Location = new System.Drawing.Point(114, 36);
            this.textBoxTitleFontSize.Name = "textBoxTitleFontSize";
            this.textBoxTitleFontSize.ReadOnly = true;
            this.textBoxTitleFontSize.Size = new System.Drawing.Size(126, 27);
            this.textBoxTitleFontSize.TabIndex = 3;
            this.textBoxTitleFontSize.TabStop = false;
            // 
            // buttonChangeTitleFont
            // 
            this.buttonChangeTitleFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.buttonChangeTitleFont.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeTitleFont.ForeColor = System.Drawing.Color.White;
            this.buttonChangeTitleFont.Location = new System.Drawing.Point(130, 112);
            this.buttonChangeTitleFont.Name = "buttonChangeTitleFont";
            this.buttonChangeTitleFont.Size = new System.Drawing.Size(75, 46);
            this.buttonChangeTitleFont.TabIndex = 1;
            this.buttonChangeTitleFont.Text = "Change Font";
            this.buttonChangeTitleFont.UseVisualStyleBackColor = false;
            this.buttonChangeTitleFont.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFont.Location = new System.Drawing.Point(63, 79);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(45, 21);
            this.labelFont.TabIndex = 1;
            this.labelFont.Text = "Font";
            // 
            // labelTitleFontSize
            // 
            this.labelTitleFontSize.AutoSize = true;
            this.labelTitleFontSize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleFontSize.Location = new System.Drawing.Point(31, 42);
            this.labelTitleFontSize.Name = "labelTitleFontSize";
            this.labelTitleFontSize.Size = new System.Drawing.Size(77, 21);
            this.labelTitleFontSize.TabIndex = 0;
            this.labelTitleFontSize.Text = "Font Size";
            // 
            // groupBoxContentSettings
            // 
            this.groupBoxContentSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxContentSettings.Controls.Add(this.textBoxContentSample);
            this.groupBoxContentSettings.Controls.Add(this.textBoxContentFontName);
            this.groupBoxContentSettings.Controls.Add(this.textBoxContentFontSize);
            this.groupBoxContentSettings.Controls.Add(this.buttonChangeContentFont);
            this.groupBoxContentSettings.Controls.Add(this.labelContentFontName);
            this.groupBoxContentSettings.Controls.Add(this.labelContentFontSize);
            this.groupBoxContentSettings.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxContentSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.groupBoxContentSettings.Location = new System.Drawing.Point(88, 365);
            this.groupBoxContentSettings.Name = "groupBoxContentSettings";
            this.groupBoxContentSettings.Size = new System.Drawing.Size(590, 176);
            this.groupBoxContentSettings.TabIndex = 6;
            this.groupBoxContentSettings.TabStop = false;
            this.groupBoxContentSettings.Text = "Content";
            this.groupBoxContentSettings.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxContentSample
            // 
            this.textBoxContentSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.textBoxContentSample.Location = new System.Drawing.Point(271, 67);
            this.textBoxContentSample.Name = "textBoxContentSample";
            this.textBoxContentSample.ReadOnly = true;
            this.textBoxContentSample.Size = new System.Drawing.Size(295, 33);
            this.textBoxContentSample.TabIndex = 7;
            this.textBoxContentSample.TabStop = false;
            this.textBoxContentSample.Text = "Sample Content Font";
            // 
            // textBoxContentFontName
            // 
            this.textBoxContentFontName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContentFontName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.textBoxContentFontName.Location = new System.Drawing.Point(114, 73);
            this.textBoxContentFontName.Name = "textBoxContentFontName";
            this.textBoxContentFontName.ReadOnly = true;
            this.textBoxContentFontName.Size = new System.Drawing.Size(126, 27);
            this.textBoxContentFontName.TabIndex = 4;
            this.textBoxContentFontName.TabStop = false;
            // 
            // textBoxContentFontSize
            // 
            this.textBoxContentFontSize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContentFontSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.textBoxContentFontSize.Location = new System.Drawing.Point(114, 36);
            this.textBoxContentFontSize.Name = "textBoxContentFontSize";
            this.textBoxContentFontSize.ReadOnly = true;
            this.textBoxContentFontSize.Size = new System.Drawing.Size(126, 27);
            this.textBoxContentFontSize.TabIndex = 3;
            this.textBoxContentFontSize.TabStop = false;
            // 
            // buttonChangeContentFont
            // 
            this.buttonChangeContentFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.buttonChangeContentFont.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeContentFont.ForeColor = System.Drawing.Color.White;
            this.buttonChangeContentFont.Location = new System.Drawing.Point(130, 113);
            this.buttonChangeContentFont.Name = "buttonChangeContentFont";
            this.buttonChangeContentFont.Size = new System.Drawing.Size(75, 46);
            this.buttonChangeContentFont.TabIndex = 2;
            this.buttonChangeContentFont.Text = "Change Font";
            this.buttonChangeContentFont.UseVisualStyleBackColor = false;
            this.buttonChangeContentFont.Click += new System.EventHandler(this.buttonChangeContentFont_Click);
            // 
            // labelContentFontName
            // 
            this.labelContentFontName.AutoSize = true;
            this.labelContentFontName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContentFontName.Location = new System.Drawing.Point(63, 79);
            this.labelContentFontName.Name = "labelContentFontName";
            this.labelContentFontName.Size = new System.Drawing.Size(45, 21);
            this.labelContentFontName.TabIndex = 1;
            this.labelContentFontName.Text = "Font";
            // 
            // labelContentFontSize
            // 
            this.labelContentFontSize.AutoSize = true;
            this.labelContentFontSize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContentFontSize.Location = new System.Drawing.Point(31, 42);
            this.labelContentFontSize.Name = "labelContentFontSize";
            this.labelContentFontSize.Size = new System.Drawing.Size(77, 21);
            this.labelContentFontSize.TabIndex = 0;
            this.labelContentFontSize.Text = "Font Size";
            // 
            // checkBoxShowDates
            // 
            this.checkBoxShowDates.AutoSize = true;
            this.checkBoxShowDates.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowDates.Location = new System.Drawing.Point(35, 55);
            this.checkBoxShowDates.Name = "checkBoxShowDates";
            this.checkBoxShowDates.Size = new System.Drawing.Size(298, 28);
            this.checkBoxShowDates.TabIndex = 3;
            this.checkBoxShowDates.Text = "Display date on each post";
            this.checkBoxShowDates.UseVisualStyleBackColor = true;
            // 
            // groupBoxOtherSettings
            // 
            this.groupBoxOtherSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxOtherSettings.Controls.Add(this.checkBoxShowDates);
            this.groupBoxOtherSettings.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOtherSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.groupBoxOtherSettings.Location = new System.Drawing.Point(88, 600);
            this.groupBoxOtherSettings.Name = "groupBoxOtherSettings";
            this.groupBoxOtherSettings.Size = new System.Drawing.Size(590, 123);
            this.groupBoxOtherSettings.TabIndex = 8;
            this.groupBoxOtherSettings.TabStop = false;
            this.groupBoxOtherSettings.Text = "Misc.";
            // 
            // buttonSaveSettingsChanges
            // 
            this.buttonSaveSettingsChanges.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSaveSettingsChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.buttonSaveSettingsChanges.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveSettingsChanges.ForeColor = System.Drawing.Color.White;
            this.buttonSaveSettingsChanges.Location = new System.Drawing.Point(88, 755);
            this.buttonSaveSettingsChanges.Name = "buttonSaveSettingsChanges";
            this.buttonSaveSettingsChanges.Size = new System.Drawing.Size(163, 63);
            this.buttonSaveSettingsChanges.TabIndex = 4;
            this.buttonSaveSettingsChanges.Text = "Save Changes";
            this.buttonSaveSettingsChanges.UseVisualStyleBackColor = false;
            this.buttonSaveSettingsChanges.Click += new System.EventHandler(this.buttonSaveSettingsChanges_Click);
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
            this.menuStripBottomMenu.TabIndex = 6;
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
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(804, 861);
            this.Controls.Add(this.menuStripBottomMenu);
            this.Controls.Add(this.buttonSaveSettingsChanges);
            this.Controls.Add(this.groupBoxOtherSettings);
            this.Controls.Add(this.groupBoxContentSettings);
            this.Controls.Add(this.groupBoxTitleSettings);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(this.headerMenu);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scribbles | Settings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.headerMenu.ResumeLayout(false);
            this.headerMenu.PerformLayout();
            this.groupBoxTitleSettings.ResumeLayout(false);
            this.groupBoxTitleSettings.PerformLayout();
            this.groupBoxContentSettings.ResumeLayout(false);
            this.groupBoxContentSettings.PerformLayout();
            this.groupBoxOtherSettings.ResumeLayout(false);
            this.groupBoxOtherSettings.PerformLayout();
            this.menuStripBottomMenu.ResumeLayout(false);
            this.menuStripBottomMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip headerMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPostToolStripMenuItem;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.GroupBox groupBoxTitleSettings;
        private System.Windows.Forms.Button buttonChangeTitleFont;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.Label labelTitleFontSize;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox textBoxTitleFont;
        private System.Windows.Forms.TextBox textBoxTitleFontSize;
        private System.Windows.Forms.TextBox textBoxTitleSample;
        private System.Windows.Forms.GroupBox groupBoxContentSettings;
        private System.Windows.Forms.TextBox textBoxContentSample;
        private System.Windows.Forms.TextBox textBoxContentFontName;
        private System.Windows.Forms.TextBox textBoxContentFontSize;
        private System.Windows.Forms.Button buttonChangeContentFont;
        private System.Windows.Forms.Label labelContentFontName;
        private System.Windows.Forms.Label labelContentFontSize;
        private System.Windows.Forms.CheckBox checkBoxShowDates;
        private System.Windows.Forms.GroupBox groupBoxOtherSettings;
        private System.Windows.Forms.Button buttonSaveSettingsChanges;
        private System.Windows.Forms.MenuStrip menuStripBottomMenu;
        private System.Windows.Forms.ToolStripMenuItem exitAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}