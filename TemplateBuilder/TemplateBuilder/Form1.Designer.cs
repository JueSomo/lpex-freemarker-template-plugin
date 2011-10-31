﻿namespace TemplateBuilder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.documentTree = new System.Windows.Forms.TreeView();
            this.editor_pg = new System.Windows.Forms.PropertyGrid();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addPromptGroup_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.templateTextTab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.templateEditor = new ICSharpCode.TextEditor.TextEditorControl();
            this.logText = new System.Windows.Forms.TextBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openFile_btn = new System.Windows.Forms.ToolStripButton();
            this.newFile_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar_progress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuPromptGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPromptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrompt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.templateTextTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuPromptGroup.SuspendLayout();
            this.menuPrompt.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "database_table.png");
            this.imageList1.Images.SetKeyName(1, "brick.png");
            this.imageList1.Images.SetKeyName(2, "chart_pie.png");
            this.imageList1.Images.SetKeyName(3, "clock.png");
            this.imageList1.Images.SetKeyName(4, "monitor.png");
            this.imageList1.Images.SetKeyName(5, "script.png");
            this.imageList1.Images.SetKeyName(6, "table_edit.png");
            this.imageList1.Images.SetKeyName(7, "table_gear.png");
            this.imageList1.Images.SetKeyName(8, "table_lightning.png");
            this.imageList1.Images.SetKeyName(9, "table_sort.png");
            this.imageList1.Images.SetKeyName(10, "database_add.png");
            this.imageList1.Images.SetKeyName(11, "folder_wrench.png");
            this.imageList1.Images.SetKeyName(12, "wrench.png");
            this.imageList1.Images.SetKeyName(13, "report.png");
            this.imageList1.Images.SetKeyName(14, "textfield.png");
            this.imageList1.Images.SetKeyName(15, "application_xp_terminal.png");
            this.imageList1.Images.SetKeyName(16, "image.png");
            this.imageList1.Images.SetKeyName(17, "images.png");
            this.imageList1.Images.SetKeyName(18, "database.png");
            this.imageList1.Images.SetKeyName(19, "textfield_delete.png");
            this.imageList1.Images.SetKeyName(20, "textfield_add.png");
            this.imageList1.Images.SetKeyName(21, "application_form.png");
            this.imageList1.Images.SetKeyName(22, "application_form_add.png");
            this.imageList1.Images.SetKeyName(23, "application_form_edit.png");
            this.imageList1.Images.SetKeyName(24, "application_form_delete.png");
            this.imageList1.Images.SetKeyName(25, "application_form_magnify.png");
            this.imageList1.Images.SetKeyName(26, "date.png");
            this.imageList1.Images.SetKeyName(27, "text_align_left.png");
            this.imageList1.Images.SetKeyName(28, "checkbox.png");
            this.imageList1.Images.SetKeyName(29, "checkbox.gif");
            this.imageList1.Images.SetKeyName(30, "application_cascade.png");
            this.imageList1.Images.SetKeyName(31, "page_white_code.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.logText);
            this.splitContainer1.Size = new System.Drawing.Size(768, 488);
            this.splitContainer1.SplitterDistance = 438;
            this.splitContainer1.TabIndex = 8;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.templateTextTab);
            this.splitContainer2.Size = new System.Drawing.Size(768, 438);
            this.splitContainer2.SplitterDistance = 207;
            this.splitContainer2.TabIndex = 5;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 25);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.documentTree);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.editor_pg);
            this.splitContainer3.Size = new System.Drawing.Size(207, 413);
            this.splitContainer3.SplitterDistance = 205;
            this.splitContainer3.TabIndex = 2;
            // 
            // documentTree
            // 
            this.documentTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentTree.ImageIndex = 14;
            this.documentTree.ImageList = this.imageList1;
            this.documentTree.Indent = 20;
            this.documentTree.ItemHeight = 18;
            this.documentTree.LineColor = System.Drawing.Color.LightGray;
            this.documentTree.Location = new System.Drawing.Point(0, 0);
            this.documentTree.Name = "documentTree";
            this.documentTree.SelectedImageIndex = 0;
            this.documentTree.Size = new System.Drawing.Size(207, 205);
            this.documentTree.TabIndex = 0;
            this.documentTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.documentTree_AfterSelect);
            this.documentTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.documentTree_MouseDown);
            this.documentTree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.documentTree_MouseUp);
            // 
            // editor_pg
            // 
            this.editor_pg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor_pg.Location = new System.Drawing.Point(0, 0);
            this.editor_pg.Name = "editor_pg";
            this.editor_pg.Size = new System.Drawing.Size(207, 204);
            this.editor_pg.TabIndex = 1;
            this.editor_pg.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.editor_pg_PropertyValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPromptGroup_btn,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(207, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addPromptGroup_btn
            // 
            this.addPromptGroup_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addPromptGroup_btn.Image = global::TemplateBuilder.Properties.Resources.application_form_add;
            this.addPromptGroup_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addPromptGroup_btn.Name = "addPromptGroup_btn";
            this.addPromptGroup_btn.Size = new System.Drawing.Size(23, 22);
            this.addPromptGroup_btn.Text = "Add Prompt Group";
            this.addPromptGroup_btn.Click += new System.EventHandler(this.addPromptGroup_btn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // templateTextTab
            // 
            this.templateTextTab.Controls.Add(this.tabPage2);
            this.templateTextTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateTextTab.ImageList = this.imageList1;
            this.templateTextTab.Location = new System.Drawing.Point(0, 0);
            this.templateTextTab.Name = "templateTextTab";
            this.templateTextTab.SelectedIndex = 0;
            this.templateTextTab.Size = new System.Drawing.Size(557, 438);
            this.templateTextTab.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.templateEditor);
            this.tabPage2.ImageIndex = 31;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(549, 411);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Template Editor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // templateEditor
            // 
            this.templateEditor.AllowDrop = true;
            this.templateEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateEditor.IsReadOnly = false;
            this.templateEditor.LineViewerStyle = ICSharpCode.TextEditor.Document.LineViewerStyle.FullRow;
            this.templateEditor.Location = new System.Drawing.Point(3, 3);
            this.templateEditor.Name = "templateEditor";
            this.templateEditor.Size = new System.Drawing.Size(543, 405);
            this.templateEditor.TabIndex = 0;
            // 
            // logText
            // 
            this.logText.BackColor = System.Drawing.SystemColors.Control;
            this.logText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logText.Location = new System.Drawing.Point(0, 0);
            this.logText.MaxLength = 5000;
            this.logText.Multiline = true;
            this.logText.Name = "logText";
            this.logText.ReadOnly = true;
            this.logText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logText.Size = new System.Drawing.Size(768, 46);
            this.logText.TabIndex = 0;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(126, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator10,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // saveFile_btn
            // 
            this.saveFile_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveFile_btn.Image = ((System.Drawing.Image)(resources.GetObject("saveFile_btn.Image")));
            this.saveFile_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFile_btn.Name = "saveFile_btn";
            this.saveFile_btn.Size = new System.Drawing.Size(23, 22);
            this.saveFile_btn.Text = "&Save";
            this.saveFile_btn.Click += new System.EventHandler(this.saveFile_btn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Enabled = false;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // openFile_btn
            // 
            this.openFile_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFile_btn.Image = ((System.Drawing.Image)(resources.GetObject("openFile_btn.Image")));
            this.openFile_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFile_btn.Name = "openFile_btn";
            this.openFile_btn.Size = new System.Drawing.Size(23, 22);
            this.openFile_btn.Text = "&Open";
            this.openFile_btn.Click += new System.EventHandler(this.openFile_btn_Click);
            // 
            // newFile_btn
            // 
            this.newFile_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newFile_btn.Image = ((System.Drawing.Image)(resources.GetObject("newFile_btn.Image")));
            this.newFile_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFile_btn.Name = "newFile_btn";
            this.newFile_btn.Size = new System.Drawing.Size(23, 22);
            this.newFile_btn.Text = "&New";
            this.newFile_btn.Click += new System.EventHandler(this.newFile_btn_Click);
            // 
            // toolStrip4
            // 
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFile_btn,
            this.openFile_btn,
            this.saveFile_btn,
            this.toolStripSeparator5,
            this.helpToolStripButton,
            this.toolStripSeparator1});
            this.toolStrip4.Location = new System.Drawing.Point(0, 24);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(768, 25);
            this.toolStrip4.TabIndex = 7;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Enabled = false;
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // statusBar_progress
            // 
            this.statusBar_progress.Name = "statusBar_progress";
            this.statusBar_progress.Size = new System.Drawing.Size(100, 16);
            this.statusBar_progress.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // statusBar_status
            // 
            this.statusBar_status.Name = "statusBar_status";
            this.statusBar_status.Size = new System.Drawing.Size(190, 17);
            this.statusBar_status.Text = "Please open a document to work with.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator7,
            this.recentFilesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(149, 6);
            // 
            // recentFilesToolStripMenuItem
            // 
            this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.recentFilesToolStripMenuItem.Text = "Recent Files";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar_progress,
            this.toolStripStatusLabel1,
            this.statusBar_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(768, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuPromptGroup
            // 
            this.menuPromptGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPromptToolStripMenuItem});
            this.menuPromptGroup.Name = "contextMenuStrip1";
            this.menuPromptGroup.Size = new System.Drawing.Size(142, 26);
            // 
            // addPromptToolStripMenuItem
            // 
            this.addPromptToolStripMenuItem.Name = "addPromptToolStripMenuItem";
            this.addPromptToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addPromptToolStripMenuItem.Text = "Add Prompt";
            this.addPromptToolStripMenuItem.Click += new System.EventHandler(this.addPromptToolStripMenuItem_Click);
            // 
            // menuPrompt
            // 
            this.menuPrompt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.menuPrompt.Name = "contextMenuStrip1";
            this.menuPrompt.Size = new System.Drawing.Size(201, 26);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 22);
            this.toolStripMenuItem2.Text = "Do something promptish";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 559);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "LPEX FreeMarker Template Builder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.templateTextTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuPromptGroup.ResumeLayout(false);
            this.menuPrompt.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView documentTree;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addPromptGroup_btn;
        private System.Windows.Forms.TabControl templateTextTab;
        private System.Windows.Forms.TextBox logText;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton saveFile_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripButton openFile_btn;
        private System.Windows.Forms.ToolStripButton newFile_btn;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar statusBar_progress;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_status;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.PropertyGrid editor_pg;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ContextMenuStrip menuPromptGroup;
        private System.Windows.Forms.ToolStripMenuItem addPromptToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menuPrompt;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TabPage tabPage2;
        private ICSharpCode.TextEditor.TextEditorControl templateEditor;


    }
}

