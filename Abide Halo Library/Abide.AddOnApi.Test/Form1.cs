﻿using Abide.HaloLibrary;
using Abide.HaloLibrary.Halo2Map;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Abide.AddOnApi.Test
{
    public partial class Form1 : Form, IHost
    {
        public MapFile Map
        {
            get { return map; }
        }
        public IndexEntry SelectedEntry
        {
            get { return selectedEntry; }
            set { OnIndexEntryChanged(value); }
        }

        private readonly MapFile map = new MapFile();
        private readonly List<IHaloAddOn<MapFile, IndexEntry>> addOns = new List<IHaloAddOn<MapFile, IndexEntry>>();
        private IndexEntry selectedEntry = null;

        public Form1()
        {
            InitializeComponent();
            tagTreeView.TreeViewNodeSorter = new CustomSorter();
        }

        public object Request(IAddOn sender, string request, params object[] args)
        {
            switch (request)
            {
                case "SelectedEntry": return selectedEntry;
                case "Map": return map;

                default: return null;
            }
        }

        protected void OnIndexEntryChanged(IndexEntry entry)
        {
            //Set
            selectedEntry = entry;

            //Trigger Updates
            addOns.ForEach(a => a.OnSelectedEntryChanged());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Prepare
            string fileName = string.Empty;
            bool open = false;

            //Initialize
            using (OpenFileDialog openDlg = new OpenFileDialog())
            {
                //Setup
                openDlg.Filter = "Map Files (*.map)|*.map";
                openDlg.Title = "Open File...";
                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    fileName = openDlg.FileName;
                    open = true;
                }
            }

            //Check
            if (open)
            {
                //Load...
                map.Load(fileName);

                //Begin
                tagTreeView.BeginUpdate();
                tagTreeView.Nodes.Clear();

                //Loop
                foreach (IndexEntry entry in map.IndexEntries)
                {
                    //Split
                    string[] parts = entry.Filename.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);

                    //Loop Through...
                    TreeNodeCollection currentCollection = tagTreeView.Nodes;
                    for (int i = 0; i < parts.Length - 1; i++)
                    {
                        if (currentCollection.ContainsKey(parts[i])) currentCollection = currentCollection[parts[i]].Nodes;
                        else currentCollection = currentCollection.Add(parts[i], parts[i]).Nodes;
                    }

                    //Get Name
                    string name = $"{parts[parts.Length - 1]}.{entry.Root}";

                    //Create
                    TreeNode node = new TreeNode(name)
                    {
                        Tag = entry.Id,
                        Name = name
                    };

                    //Add
                    currentCollection.Add(node);
                }

                //Sort
                tagTreeView.Sort();

                //End
                tagTreeView.EndUpdate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void tagTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is TagId selectedId)
                selectedEntry = map.IndexEntries[selectedId];
            else selectedEntry = null;
        }

        private class CustomSorter : IComparer
        {
            public int Compare(object x, object y)
            {
                if (x is TreeNode && y is TreeNode)
                    return CompareNodes((TreeNode)x, (TreeNode)y);
                else return 0;
            }

            private int CompareNodes(TreeNode x, TreeNode y)
            {
                if (x.Tag is TagId && y.Tag == null)
                    return 1;
                else if (x.Tag == null && y.Tag is TagId)
                    return -1;
                else
                {
                    return x.Name.CompareTo(y.Name);
                }
            }
        }
    }
}
