namespace Scribbles
{
    partial class frmHome
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.buttonLoadNewer = new System.Windows.Forms.Button();
            this.buttonLoadOlder = new System.Windows.Forms.Button();
            this.menuStripBottomMenu = new System.Windows.Forms.MenuStrip();
            this.exitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanelPostExcerpts = new System.Windows.Forms.FlowLayoutPanel();
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
            this.headerMenu.TabIndex = 0;
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
            // buttonLoadNewer
            // 
            this.buttonLoadNewer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLoadNewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.buttonLoadNewer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadNewer.ForeColor = System.Drawing.Color.White;
            this.buttonLoadNewer.Location = new System.Drawing.Point(308, 775);
            this.buttonLoadNewer.Name = "buttonLoadNewer";
            this.buttonLoadNewer.Size = new System.Drawing.Size(88, 34);
            this.buttonLoadNewer.TabIndex = 7;
            this.buttonLoadNewer.Text = "< Newer";
            this.buttonLoadNewer.UseVisualStyleBackColor = false;
            this.buttonLoadNewer.Click += new System.EventHandler(this.buttonLoadNewer_Click);
            // 
            // buttonLoadOlder
            // 
            this.buttonLoadOlder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLoadOlder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.buttonLoadOlder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadOlder.ForeColor = System.Drawing.Color.White;
            this.buttonLoadOlder.Location = new System.Drawing.Point(413, 775);
            this.buttonLoadOlder.Name = "buttonLoadOlder";
            this.buttonLoadOlder.Size = new System.Drawing.Size(88, 34);
            this.buttonLoadOlder.TabIndex = 8;
            this.buttonLoadOlder.Text = "Older >";
            this.buttonLoadOlder.UseVisualStyleBackColor = false;
            this.buttonLoadOlder.Click += new System.EventHandler(this.buttonLoadOlder_Click);
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
            this.menuStripBottomMenu.TabIndex = 5;
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
            this.homeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(685, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Edit";
            // 
            // flowLayoutPanelPostExcerpts
            // 
            this.flowLayoutPanelPostExcerpts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelPostExcerpts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(67)))), ((int)(((byte)(101)))));
            this.flowLayoutPanelPostExcerpts.Location = new System.Drawing.Point(48, 50);
            this.flowLayoutPanelPostExcerpts.Name = "flowLayoutPanelPostExcerpts";
            this.flowLayoutPanelPostExcerpts.Size = new System.Drawing.Size(710, 719);
            this.flowLayoutPanelPostExcerpts.TabIndex = 10;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(804, 861);
            this.Controls.Add(this.flowLayoutPanelPostExcerpts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLoadOlder);
            this.Controls.Add(this.buttonLoadNewer);
            this.Controls.Add(this.headerMenu);
            this.Controls.Add(this.menuStripBottomMenu);
            this.MainMenuStrip = this.headerMenu;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scribbles | Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmHome_Activated);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.headerMenu.ResumeLayout(false);
            this.headerMenu.PerformLayout();
            this.menuStripBottomMenu.ResumeLayout(false);
            this.menuStripBottomMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip headerMenu;
        private System.Windows.Forms.ToolStripMenuItem newPostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button buttonLoadNewer;
        private System.Windows.Forms.Button buttonLoadOlder;
        private System.Windows.Forms.MenuStrip menuStripBottomMenu;
        private System.Windows.Forms.ToolStripMenuItem exitAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPostExcerpts;
    }
}

