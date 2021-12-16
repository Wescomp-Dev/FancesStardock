namespace NoFences
{
    partial class FenceWindow
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
            this.components = new System.ComponentModel.Container();
            this.appContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newFenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.txtTitu = new System.Windows.Forms.TextBox();
            this.appContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // appContextMenu
            // 
            this.appContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteItemToolStripMenuItem,
            this.lockedToolStripMenuItem,
            this.minifyToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.toolStripSeparator1,
            this.newFenceToolStripMenuItem});
            this.appContextMenu.Name = "contextMenuStrip1";
            this.appContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.appContextMenu.Size = new System.Drawing.Size(134, 120);
            this.appContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteItemToolStripMenuItem.Text = "Delear";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.DeleteItemToolStripMenuItem_Click);
            // 
            // lockedToolStripMenuItem
            // 
            this.lockedToolStripMenuItem.CheckOnClick = true;
            this.lockedToolStripMenuItem.Name = "lockedToolStripMenuItem";
            this.lockedToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.lockedToolStripMenuItem.Text = "Trancar";
            this.lockedToolStripMenuItem.Click += new System.EventHandler(this.LockedToolStripMenuItem_Click);
            // 
            // minifyToolStripMenuItem
            // 
            this.minifyToolStripMenuItem.CheckOnClick = true;
            this.minifyToolStripMenuItem.Name = "minifyToolStripMenuItem";
            this.minifyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.minifyToolStripMenuItem.Text = "Hide";
            this.minifyToolStripMenuItem.Click += new System.EventHandler(this.MinifyToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.renameToolStripMenuItem.Text = "Renomear";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.RenameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // newFenceToolStripMenuItem
            // 
            this.newFenceToolStripMenuItem.Name = "newFenceToolStripMenuItem";
            this.newFenceToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.newFenceToolStripMenuItem.Text = "Novo Dock";
            this.newFenceToolStripMenuItem.Click += new System.EventHandler(this.NewFenceToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::NoFences.Properties.Resources.btFechar1;
            this.pictureBox1.Location = new System.Drawing.Point(315, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // picMenu
            // 
            this.picMenu.Image = global::NoFences.Properties.Resources.btContexto;
            this.picMenu.Location = new System.Drawing.Point(12, 7);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(23, 23);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 2;
            this.picMenu.TabStop = false;
            this.picMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicMenu_MouseClick);
            // 
            // txtTitu
            // 
            this.txtTitu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitu.Location = new System.Drawing.Point(62, 12);
            this.txtTitu.Name = "txtTitu";
            this.txtTitu.Size = new System.Drawing.Size(230, 15);
            this.txtTitu.TabIndex = 4;
            this.txtTitu.Text = "Insira o título";
            this.txtTitu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTitu.Visible = false;
            this.txtTitu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTitu_KeyPress);
            // 
            // FenceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.ControlBox = false;
            this.Controls.Add(this.txtTitu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picMenu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FenceWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FenceWindow_FormClosed);
            this.LocationChanged += new System.EventHandler(this.FenceWindow_LocationChanged);
            this.Click += new System.EventHandler(this.FenceWindow_Click);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FenceWindow_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FenceWindow_DragEnter);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FenceWindow_Paint);
            this.DoubleClick += new System.EventHandler(this.FenceWindow_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.FenceWindow_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FenceWindow_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FenceWindow_MouseMove);
            this.Resize += new System.EventHandler(this.FenceWindow_Resize);
            this.appContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip appContextMenu;
        private System.Windows.Forms.ToolStripMenuItem lockedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem minifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFenceToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTitu;
    }
}

