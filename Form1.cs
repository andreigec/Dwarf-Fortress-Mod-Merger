using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ANDREICSLIB;
using ANDREICSLIB.Helpers;
using ANDREICSLIB.Licensing;
using DwarfFortressModMerger.Properties;

namespace DwarfFortressModMerger
{
    public partial class Form1 : Form
    {
        #region licensing
        private const String HelpString = "";

        private readonly String OtherText =
            @"©" + DateTime.Now.Year +
            @" Andrei Gec (http://www.andreigec.net)

Licensed under GNU LGPL (http://www.gnu.org/)

Zip Assets © SharpZipLib (http://www.sharpdevelop.net/OpenSource/SharpZipLib/)
";

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Licensing.LicensingForm(this, menuStrip1, HelpString, OtherText);

            LoadConfig();
            if (vanillaLB.Items.Count >= 1)
                vanillaLB.SelectedIndex = 0;

            if (modLB.Items.Count >= 1)
                modLB.SelectedIndex = 0;

            if (outputLB.Items.Count >= 1)
                outputLB.SelectedIndex = 0;

            //init clientside
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("");
        }
        
        private const string cfgpath = "DFMM.cfg";
        private void SaveConfig()
        {
            //save form config changes
            var lc = new List<Control>();
            lc.Add(vanillaLB);
            lc.Add(modLB);
            lc.Add(outputLB);
            lc.Add(mergesaveCB);
            lc.Add(opendirCB);
            lc.Add(mergeinitdirCB);
            FormConfigRestore.SaveConfig(this, cfgpath, lc);
        }

        private void LoadConfig()
        {
            //load config
            FormConfigRestore.LoadConfig(this, cfgpath);
            //only show items that actually exist
            EnsureExist(vanillaLB, true);
            EnsureExist(modLB, true);
            EnsureExist(outputLB, false);
        }

        private void EnsureExist(ListBox lb, bool isfile)
        {
            for (int a = 0; a < lb.Items.Count; a++)
            {
                String i = lb.Items[a].ToString();
                if (FileAllowed(i, isfile) == false)
                {
                    lb.Items.Remove(i);
                    a--;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }

        private void AddFiles(ListBox lb, string[] files)
        {
            foreach (var f in files)
            {
                if (lb.Items.Contains(f) == false)
                    lb.Items.Insert(0, f);
            }
        }

        private bool FileAllowed(String f, bool isfile)
        {
            if (string.IsNullOrEmpty(f))
                return false;

            return ((isfile && File.Exists(f) && f.EndsWith(".zip", StringComparison.CurrentCultureIgnoreCase)) ||
                    (isfile == false && Directory.Exists(f)));
        }

        private void ShowDrop(ListBox lb, DragEventArgs e, bool isfile)
        {
            if (e == null || lb == null || e.Data.GetDataPresent(DataFormats.FileDrop) == false)
                return;

            var files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files != null && files.Count() > 0)
            {
                if (files.Any(f => FileAllowed(f, isfile) == false))
                {
                    return;
                }
            }
            else
                return;

            e.Effect = DragDropEffects.Copy;
        }

        private void AddDropFiles(ListBox lb, DragEventArgs e)
        {
            //dont worry about comparing for value drop, we have already done on dropover
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files != null && files.Count() > 0)
                AddFiles(lb, files);

            if (lb.SelectedIndex == -1 && lb.Items.Count >= 1)
                lb.SelectedIndex = 0;
        }

        private void vanillaLB_DragDrop(object sender, DragEventArgs e)
        {
            AddDropFiles(sender as ListBox, e);
        }

        private void modLB_DragDrop(object sender, DragEventArgs e)
        {
            AddDropFiles(sender as ListBox, e);
        }

        private void outputLB_DragDrop(object sender, DragEventArgs e)
        {
            AddDropFiles(sender as ListBox, e);
        }

        private void vanillaLB_DragOver(object sender, DragEventArgs e)
        {
            ShowDrop(sender as ListBox, e, true);
        }

        private void modLB_DragOver(object sender, DragEventArgs e)
        {
            ShowDrop(sender as ListBox, e, true);
        }

        private void outputLB_DragOver(object sender, DragEventArgs e)
        {
            ShowDrop(sender as ListBox, e, false);
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vanillaLB.Items.Clear();
            modLB.Items.Clear();
            outputLB.Items.Clear();
        }

        public void ChangeStatusText(String s)
        {
            statustext.Text = s;
            Application.DoEvents();
        }

        private void startmergebutton_Click(object sender, EventArgs e)
        {
            if (vanillaLB.SelectedIndex == -1)
            {
                MessageBox.Show("Error:Add and select a vanilla DF zip file");
                return;
            }

            if (modLB.SelectedIndex == -1)
            {
                MessageBox.Show("Error:Add and select a mod DF zip file");
                return;
            }

            if (outputLB.SelectedIndex == -1)
            {
                MessageBox.Show("Error:Add and select an output directory for the merged files");
                return;
            }

            var v = vanillaLB.SelectedItem.ToString();
            var m = modLB.SelectedItem.ToString();
            var o = outputLB.SelectedItem.ToString();

            if (File.Exists(v) == false || v.EndsWith(".zip", StringComparison.CurrentCultureIgnoreCase) == false)
            {
                MessageBox.Show("Error:Vanilla file must be a zip and exist");
                return;
            }

            if (File.Exists(m) == false || m.EndsWith(".zip", StringComparison.CurrentCultureIgnoreCase) == false)
            {
                MessageBox.Show("Error:Mod file must be a zip and exist");
                return;
            }

            if (File.Exists(o) || Directory.Exists(o) == false)
            {
                MessageBox.Show("Error:Output directory must be a directory and exist");
                return;
            }

            try
            {
                startmergebutton.Enabled = false;
                var res = controller.MergeOp(v, m, o, mergesaveCB.Checked, mergeinitdirCB.Checked, ChangeStatusText);
                if (res == false)
                    return;

                if (opendirCB.Checked)
                    Process.Start(o);
            }
            finally
            {
                startmergebutton.Enabled = true;
            }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String t = @"--HELP--
Dwarf Fortress Mod Merger is a program designed to automate the merging of a graphical mod into a vanilla build of df.

Steps to use:
1. Drag a vanilla df zip file into the appropriate box
2. Drag a mod df zip into the appropriate box
3. Create or drag an existing df directory into the appropriate box
4. Select whether you want to keep the save and init directories from the existing df folder

Program will now merge the mod into the vanilla build, and keep the save/init dirs as required.
";

            MessageBox.Show(t);

        }
    }
}

