﻿using Abide.HaloLibrary.Halo2Map;
using System;
using System.Windows.Forms;

namespace Abide.Ifp.Demo
{
    public partial class Form1 : Form
    {
        private readonly MapFile map;
        private readonly IfpDocument document;

        public Form1()
        {
            InitializeComponent();
            map = new MapFile();
            document = new IfpDocument();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Prepare
            string filename = string.Empty;
            bool open = false;

            //Initialize
            using (OpenFileDialog openDlg = new OpenFileDialog())
            {
                //Setup
                openDlg.Filter = "All Files (*.*)|*.*";
                openDlg.Title = "Open File...";
                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    filename = openDlg.FileName;
                    open = true;
                }
            }

            //Check
            if (open)
            {
                //Load
                document.Load(filename);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Prepare
            string filename = string.Empty;
            bool open = false;

            //Initialize
            using (OpenFileDialog openDlg = new OpenFileDialog())
            {
                //Setup
                openDlg.Filter = "Map Files (*.map)|*.map";
                openDlg.Title = "Open Map...";
                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    filename = openDlg.FileName;
                    open = true;
                }
            }

            //Check
            if (open)
            {
                //Load Map
                map.Load(filename);
            }
        }
    }
}
