﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ANDREICSLIB;

namespace DwarfFortressModMerger
{
    public static class controller
    {
        public delegate void ChangeStatusTextDel(String s);

        private static void ChangeStatusText(ChangeStatusTextDel f, String s)
        {
            if (f != null)
                f(s);
        }

        /// <summary>
        /// perform the merging of a vanilla df zip file, a mod zip file, an output dir, and whether to merge save and init dirs
        /// </summary>
        /// <param name="vanilla">vanilla df zip file</param>
        /// <param name="mod">mod df zip file</param>
        /// <param name="realoutput">output dir</param>
        /// <param name="mergesave">whether to persist save dir from orig output dir</param>
        /// <param name="mergeinit">whether to persist init dir from orig output dir</param>
        /// <param name="sf">a delegate to change status text</param>
        public static bool MergeOp(String vanilla, String mod, String realoutput, bool mergesave, bool mergeinit, ChangeStatusTextDel sf = null)
        {
            string vantemp = Directory.GetCurrentDirectory() + "\\vanillatemp";
            string modtemp = Directory.GetCurrentDirectory() + "\\modtemp";

            const string raw = "\\raw";
            const string art = "\\data\\art";
            const string init = "\\data\\init\\init.txt";
            const string initd = "\\data\\init\\d_init.txt";
            const string datainot = "\\data\\init";
            const string dsave = "\\data\\save";

            string outputtemp = Directory.GetCurrentDirectory() + "\\df";
            string outputtempsave = outputtemp + dsave;
            string outputtempinit = outputtemp + datainot;
            string outputinit = outputtemp + init;
            string outputdinit = outputtemp + initd;

            string realsavedir = realoutput + dsave;
            string realsaveinit = realoutput + datainot;

            string modinit = modtemp + init;
            string moddinit = modtemp + init;

            //delete temps if already exist
            FileUpdates.DeleteDirectory(vantemp);
            FileUpdates.DeleteDirectory(modtemp);
            FileUpdates.DeleteDirectory(outputtemp);

            ChangeStatusText(sf, Resources.start_exct_van_zip);
            try
            {
                //unpack vanilla
                Zip.ExtractZipFile(vanilla, vantemp);
                ChangeStatusText(sf, Resources.fin_exct_van_zip);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.error_van_zip + ex);
                return false;
            }

            try
            {
                //unpack mod
                Zip.ExtractZipFile(mod, modtemp);
                ChangeStatusText(sf, Resources.fin_exct_mod_zip);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.error_mod_zip + ex);
                return false;
            }

            try
            {
                //move vanilla
                FileUpdates.MergeDirectories(outputtemp, vantemp);

                //delete raw and art
                FileUpdates.DeleteDirectory(outputtemp + raw);
                FileUpdates.DeleteDirectory(outputtemp + art);

                //move mod raw and art
                FileUpdates.MergeDirectories(outputtemp + raw, modtemp + raw);
                FileUpdates.MergeDirectories(outputtemp + art, modtemp + art);
                //copy init/init.d
                if (File.Exists(modinit))
                    File.Copy(modinit, outputinit, true);
                if (File.Exists(moddinit))
                    File.Copy(moddinit, outputdinit, true);

                ChangeStatusText(sf, Resources.fin_merge);

                //get save games if required
                if (mergesave && Directory.Exists(realsavedir))
                {
                    FileUpdates.CreateDirectory(outputtempsave);
                    FileUpdates.MergeDirectories(outputtempsave, realsavedir);
                }

                //get init dir if required
                if (mergeinit && Directory.Exists(realsaveinit))
                {
                    FileUpdates.MergeDirectories(outputtempinit, realsaveinit);
                }

                //delete temps
                FileUpdates.DeleteDirectory(vantemp);
                FileUpdates.DeleteDirectory(modtemp);
                
                //move temp to real
                FileUpdates.DeleteDirectory(realoutput);
                FileUpdates.MergeDirectories(realoutput, outputtemp);

                FileUpdates.DeleteDirectory(outputtemp);
                ChangeStatusText(sf, Resources.ready);
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occured:" + ex);
                return false;
            }

            return true;
        }
    }
}