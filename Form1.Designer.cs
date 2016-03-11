namespace DwarfFortressModMerger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vanillaLB = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.modLB = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.outputLB = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mergeinitdirCB = new System.Windows.Forms.CheckBox();
            this.opendirCB = new System.Windows.Forms.CheckBox();
            this.mergesaveCB = new System.Windows.Forms.CheckBox();
            this.startmergebutton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statustext = new System.Windows.Forms.ToolStripStatusLabel();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = global::DwarfFortressModMerger.Resources.file;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = global::DwarfFortressModMerger.Resources.exit;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearHistoryToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = global::DwarfFortressModMerger.Resources.options;
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.clearHistoryToolStripMenuItem.Text = global::DwarfFortressModMerger.Resources.clear_hist;
            this.clearHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearHistoryToolStripMenuItem_Click);
            // 
            // vanillaLB
            // 
            this.vanillaLB.AllowDrop = true;
            this.vanillaLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vanillaLB.FormattingEnabled = true;
            this.vanillaLB.HorizontalScrollbar = true;
            this.vanillaLB.Location = new System.Drawing.Point(3, 16);
            this.vanillaLB.Name = "vanillaLB";
            this.vanillaLB.ScrollAlwaysVisible = true;
            this.vanillaLB.Size = new System.Drawing.Size(537, 99);
            this.vanillaLB.TabIndex = 1;
            this.vanillaLB.DragDrop += new System.Windows.Forms.DragEventHandler(this.vanillaLB_DragDrop);
            this.vanillaLB.DragOver += new System.Windows.Forms.DragEventHandler(this.vanillaLB_DragOver);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.vanillaLB);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Dwarf Fortress Vanilla (Drag ZIP File Here)";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.modLB);
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 127);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Dwarf Fortress Mod (Drag ZIP File Here)";
            // 
            // modLB
            // 
            this.modLB.AllowDrop = true;
            this.modLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modLB.FormattingEnabled = true;
            this.modLB.HorizontalScrollbar = true;
            this.modLB.Location = new System.Drawing.Point(3, 16);
            this.modLB.Name = "modLB";
            this.modLB.ScrollAlwaysVisible = true;
            this.modLB.Size = new System.Drawing.Size(537, 108);
            this.modLB.TabIndex = 1;
            this.modLB.DragDrop += new System.Windows.Forms.DragEventHandler(this.modLB_DragDrop);
            this.modLB.DragOver += new System.Windows.Forms.DragEventHandler(this.modLB_DragOver);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.outputLB);
            this.groupBox3.Location = new System.Drawing.Point(12, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(543, 134);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose Output Directory (Drag Directory Here)";
            // 
            // outputLB
            // 
            this.outputLB.AllowDrop = true;
            this.outputLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputLB.FormattingEnabled = true;
            this.outputLB.HorizontalScrollbar = true;
            this.outputLB.Location = new System.Drawing.Point(3, 16);
            this.outputLB.Name = "outputLB";
            this.outputLB.ScrollAlwaysVisible = true;
            this.outputLB.Size = new System.Drawing.Size(537, 115);
            this.outputLB.TabIndex = 1;
            this.outputLB.DragDrop += new System.Windows.Forms.DragEventHandler(this.outputLB_DragDrop);
            this.outputLB.DragOver += new System.Windows.Forms.DragEventHandler(this.outputLB_DragOver);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.mergeinitdirCB);
            this.groupBox4.Controls.Add(this.opendirCB);
            this.groupBox4.Controls.Add(this.mergesaveCB);
            this.groupBox4.Location = new System.Drawing.Point(12, 434);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(362, 69);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options";
            // 
            // mergeinitdirCB
            // 
            this.mergeinitdirCB.AutoSize = true;
            this.mergeinitdirCB.Checked = true;
            this.mergeinitdirCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mergeinitdirCB.Location = new System.Drawing.Point(168, 42);
            this.mergeinitdirCB.Name = "mergeinitdirCB";
            this.mergeinitdirCB.Size = new System.Drawing.Size(179, 17);
            this.mergeinitdirCB.TabIndex = 3;
            this.mergeinitdirCB.Text = global::DwarfFortressModMerger.Resources.merge_ext_initdir;
            this.mergeinitdirCB.UseVisualStyleBackColor = true;
            // 
            // opendirCB
            // 
            this.opendirCB.AutoSize = true;
            this.opendirCB.Checked = true;
            this.opendirCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.opendirCB.Location = new System.Drawing.Point(6, 19);
            this.opendirCB.Name = "opendirCB";
            this.opendirCB.Size = new System.Drawing.Size(156, 17);
            this.opendirCB.TabIndex = 1;
            this.opendirCB.Text = global::DwarfFortressModMerger.Resources.open_dir_complete;
            this.opendirCB.UseVisualStyleBackColor = true;
            // 
            // mergesaveCB
            // 
            this.mergesaveCB.AutoSize = true;
            this.mergesaveCB.Checked = true;
            this.mergesaveCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mergesaveCB.Location = new System.Drawing.Point(168, 19);
            this.mergesaveCB.Name = "mergesaveCB";
            this.mergesaveCB.Size = new System.Drawing.Size(189, 17);
            this.mergesaveCB.TabIndex = 0;
            this.mergesaveCB.Text = global::DwarfFortressModMerger.Resources.merge_exist_savedir;
            this.mergesaveCB.UseVisualStyleBackColor = true;
            // 
            // startmergebutton
            // 
            this.startmergebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startmergebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startmergebutton.Location = new System.Drawing.Point(380, 434);
            this.startmergebutton.Name = "startmergebutton";
            this.startmergebutton.Size = new System.Drawing.Size(172, 69);
            this.startmergebutton.TabIndex = 8;
            this.startmergebutton.Text = global::DwarfFortressModMerger.Resources.start_merge;
            this.startmergebutton.UseVisualStyleBackColor = true;
            this.startmergebutton.Click += new System.EventHandler(this.startmergebutton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statustext});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(568, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = global::DwarfFortressModMerger.Resources.status;
            // 
            // statustext
            // 
            this.statustext.Name = "statustext";
            this.statustext.Size = new System.Drawing.Size(39, 17);
            this.statustext.Text = global::DwarfFortressModMerger.Resources.ready;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 539);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.startmergebutton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(584, 577);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox vanillaLB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox modLB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox outputLB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox opendirCB;
        private System.Windows.Forms.CheckBox mergesaveCB;
        private System.Windows.Forms.Button startmergebutton;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearHistoryToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statustext;
        private System.Windows.Forms.CheckBox mergeinitdirCB;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
    }
}

