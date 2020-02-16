namespace Scribbles
{
    partial class frmPostEditor
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
            this.buttonClearForm = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.labelPostContent = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.menuStripBottomMenu = new System.Windows.Forms.MenuStrip();
            this.exitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.headerMenu.SuspendLayout();
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
            this.headerMenu.TabIndex = 1;
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
            // buttonClearForm
            // 
            this.buttonClearForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClearForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.buttonClearForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearForm.ForeColor = System.Drawing.Color.White;
            this.buttonClearForm.Location = new System.Drawing.Point(487, 741);
            this.buttonClearForm.Name = "buttonClearForm";
            this.buttonClearForm.Size = new System.Drawing.Size(108, 41);
            this.buttonClearForm.TabIndex = 5;
            this.buttonClearForm.Text = "Clear Form";
            this.buttonClearForm.UseVisualStyleBackColor = false;
            this.buttonClearForm.Click += new System.EventHandler(this.buttonClearForm_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(74, 741);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(108, 41);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.AcceptsTab = true;
            this.richTextBoxContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxContent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.richTextBoxContent.Location = new System.Drawing.Point(74, 210);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.Size = new System.Drawing.Size(518, 471);
            this.richTextBoxContent.TabIndex = 3;
            this.richTextBoxContent.Text = "";
            // 
            // labelPostContent
            // 
            this.labelPostContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPostContent.AutoSize = true;
            this.labelPostContent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.labelPostContent.Location = new System.Drawing.Point(74, 190);
            this.labelPostContent.Name = "labelPostContent";
            this.labelPostContent.Size = new System.Drawing.Size(93, 17);
            this.labelPostContent.TabIndex = 10;
            this.labelPostContent.Text = "Post Content";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.labelTitle.Location = new System.Drawing.Point(71, 89);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(63, 17);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "Post Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.textBoxTitle.Location = new System.Drawing.Point(74, 109);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(521, 26);
            this.textBoxTitle.TabIndex = 2;
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
            this.menuStripBottomMenu.TabIndex = 17;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(395, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // frmPostEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(804, 861);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStripBottomMenu);
            this.Controls.Add(this.buttonClearForm);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.richTextBoxContent);
            this.Controls.Add(this.labelPostContent);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.headerMenu);
            this.Name = "frmPostEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scribbles | Post Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPostEditor_FormClosed);
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
        private System.Windows.Forms.Button buttonClearForm;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelPostContent;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.MenuStrip menuStripBottomMenu;
        private System.Windows.Forms.ToolStripMenuItem exitAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.RichTextBox richTextBoxContent;
        public System.Windows.Forms.TextBox textBoxTitle;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}