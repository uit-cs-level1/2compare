﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.IO;

namespace doan2compare
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(metroTabPage2);
           
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(metroTabPage3);
        }

        private void metroTile1_MouseMove(object sender, MouseEventArgs e)
        {
            metroTile1.Style = (MetroColorStyle)5;
        }

        private void metroTile1_MouseLeave(object sender, EventArgs e)
        {
            metroTile1.Style = (MetroColorStyle)0;
        }

        private void metroTile2_MouseLeave(object sender, EventArgs e)
        {
            metroTile2.Style = (MetroColorStyle)0;
        }

        private void metroTile2_MouseMove(object sender, MouseEventArgs e)
        {
            metroTile2.Style = (MetroColorStyle)5;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(metroButton1, new Point(0, metroButton1.Height));
        }

        private void metroContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroContextMenu2.Show(metroButton2, new Point(0, metroButton2.Height));
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (White.Checked == true)
            {
                this.Theme = MetroThemeStyle.Light;
                metroStyleManager.Theme = MetroThemeStyle.Light;
                metroUserControl1.BackColor = this.BackColor;
                metroTrackBar2.BackColor = this.BackColor;
                treeView1.BackColor = this.BackColor;
                treeView2.BackColor = this.BackColor;

            }
            else
            {
                this.Theme = MetroThemeStyle.Dark;
                metroStyleManager.Theme = MetroThemeStyle.Dark;
                metroUserControl1.BackColor = this.BackColor;
                metroTrackBar2.BackColor = this.BackColor;
                treeView1.BackColor = this.BackColor;
                treeView2.BackColor = this.BackColor;

            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Style = (MetroColorStyle)metroTrackBar2.Value;
            metroStyleManager.Style = (MetroColorStyle)metroTrackBar2.Value;
           
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroTabPage4_Click(object sender, EventArgs e)
        {

        }

        private void metroUserControl1_Load_1(object sender, EventArgs e)
        {

        }

 

        private void metroTrackBar2_ValueChanged(object sender, EventArgs e)
        {
            int valuecolor= metroTrackBar2.Value;
            if (valuecolor == 0)
                metroTrackBar2.BackColor = Color.Blue;
            else if(valuecolor == 1)
                metroTrackBar2.BackColor = Color.Black;
            else if (valuecolor == 2)
                metroTrackBar2.BackColor = Color.White;
            else if (valuecolor == 3)
                metroTrackBar2.BackColor = Color.Silver;
            else if (valuecolor == 4)
                metroTrackBar2.BackColor = Color.Blue;
            else if (valuecolor == 5)
                metroTrackBar2.BackColor = Color.Green;
            else if (valuecolor == 6)
                metroTrackBar2.BackColor = Color.Lime;
            else if (valuecolor == 7)
                metroTrackBar2.BackColor = Color.Teal;
            else if (valuecolor == 8)
                metroTrackBar2.BackColor = Color.Orange;
            else if (valuecolor == 9)
                metroTrackBar2.BackColor = Color.Brown;
            else if (valuecolor == 10)
                metroTrackBar2.BackColor = Color.Pink;
            else if (valuecolor == 11)
                metroTrackBar2.BackColor = Color.Magenta;
            else if (valuecolor == 12)
                metroTrackBar2.BackColor = Color.Purple;
            else
                metroTrackBar2.BackColor = Color.Red;
        }

        private void metroTrackBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

       

        private void addFolderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
        private void show_folder(string path,TreeNode node)//ham liet ket dic
        {
            DirectoryInfo direcinfo = new DirectoryInfo(path);
            DirectoryInfo[] dics = direcinfo.GetDirectories();
            int i = 0;
            foreach (DirectoryInfo dic in dics)
            {

                node.Nodes.Add(dic.Name);
                TreeNode nodes = node.Nodes[i];
                show_folder(path + '/' + dic.Name, nodes);
                i++;

            }
            FileInfo[] files = direcinfo.GetFiles();
            foreach (FileInfo file in files)
            {
                node.Nodes.Add(file.Name);
            }
        }
        private void show_treenode(TreeView x)
        {
            try
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    x.Nodes.Clear();
                    if (x == treeView1)
                    {
                        metroLabel3.Text = fd.SelectedPath;
                    }
                    else { metroLabel4.Text = fd.SelectedPath; }
                    DirectoryInfo direcinfo = new DirectoryInfo(fd.SelectedPath);
                    DirectoryInfo[] dics = direcinfo.GetDirectories();
                    int i = 0;
                    foreach (DirectoryInfo dic in dics)
                    {
                        x.Nodes.Add(dic.Name);
                        TreeNode node = x.Nodes[i];
                        show_folder(fd.SelectedPath + '/' + dic.Name, node);
                        i++;

                    }
                    FileInfo[] files = direcinfo.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        x.Nodes.Add(file.Name);
                    }
                }
            }
            catch
            {
                
            }
        }
        private void addFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count == 0)
            {
                show_treenode(treeView1);
            }
            else
                show_treenode(treeView2);
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroContextMenu2_Opening(object sender, CancelEventArgs e)
        {

        }
        int checkfile(string path)
        {
            int kq = 1;
            return kq;
        }
        private string listname(TreeNode node)
        {

            int k = 0;
            string name = "";
        nhaylai:
            try
            {

                while (k != 1)
                {
                    name = '\\' + name + node.Text + "\\";
                    node = node.NextNode;

                }
            }
            catch
            {
                k = 1;
                goto nhaylai;
            }
            return name;
        }
        private void tomau(TreeNode Node, TreeView xx)
        {
            string[] arrListStr = Node.FullPath.Split('\\');
            string t = arrListStr[0];
            TreeNode X;
            X = xx.Nodes[0];
            while (X.Text != t)
            {
                X = X.NextNode;
            }
            for (int i = 1; i <= arrListStr.Length - 1; i++)
            {
                X.ForeColor = Color.Red;
                X = X.Nodes[0];
                while (X.Text != arrListStr[i])
                {
                    X = X.NextNode;
                }
            }
        }
        private void kiemtradisc(TreeNode Node,TreeView x,TreeView y)
        {
            string[] arrListStr = Node.FullPath.Split('\\');
            string firstnode;
            firstnode = arrListStr[0];

            TreeNode Node2 = y.Nodes[0];
            while (firstnode != Node2.Text)
            {
                Node2 = Node2.NextNode;
            }
            Node = Node.Nodes[0];
            string nodetxt = Node.FullPath;


            int j = 0;
        trl:
            try
            {
                while (j != 1)
                {
                    for (int i = 0; i <= nodetxt.Length - 1; i++)
                    {
                        if (nodetxt[i] == '\\')
                        {
                            Node2 = Node2.Nodes[0];
                        }

                    }
                repeat:
                    string t1 = '\\' + Node.Text;
                    string t2 = Node.Text + '\\';
                    if ((listname(Node2).Contains(t1) == false) || (listname(Node2).Contains(t2) == false))
                    {
                        tomau(Node,x);
                        Node.ForeColor = Color.Blue;
                    }
                    else
                    {
                        string te;
                        if (x == treeView1)
                            te = metroLabel3.Text;
                        else
                            te = metroLabel4.Text;
                        FileAttributes attr = File.GetAttributes(te + '\\' + Node.FullPath);

                        //detect whether its a directory or file
                        if (attr.HasFlag(FileAttributes.Directory))
                        {
                            kiemtradisc(Node,x,y);
                        }
                        else
                        {

                            if (checkfile(Node.FullPath) == 1)
                            {
                                tomau(Node,x);
                                Node.ForeColor = Color.Red;
                            }
                        }

                    }
                    Node = Node.NextNode;
                    goto repeat;
                }
            }
            catch
            {
                j = 1;
                goto trl;
            }

        }
        private void compare(TreeView x,TreeView y)
        {
            int j = 0;
        trolai:
            try
            {
                TreeNode knode;
                knode = x.Nodes[0];
                while (j != 1)
                {

                    string t = knode.Text;
                    TreeNode knodes = y.Nodes[0];
                    if (listname(knodes).Contains(t) == false)
                        knode.ForeColor = Color.Blue;
                    else
                    {
                        string te;
                        if (x == treeView1)
                            te = metroLabel3.Text;
                        else
                            te = metroLabel4.Text;
                        FileAttributes attr = File.GetAttributes(te + '\\' + knode.FullPath);

                        //detect whether its a directory or file
                        if (attr.HasFlag(FileAttributes.Directory))
                        {
                            kiemtradisc(knode,x,y);
                        }
                        else
                        {

                            if (checkfile(knode.FullPath) == 1)
                            {
                                knode.ForeColor = Color.Red;
                            }
                        }
                    }

                    knode = knode.NextNode;
                }
            }
            catch
            {
                j = 1;
                goto trolai;
            }
        }
        private void compareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((treeView1.Nodes.Count == 0) || (treeView2.Nodes.Count == 0))
            {
                MetroMessageBox.Show(this, "Please Add Folder first.", "Folder Not Found", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {
                compare(treeView1, treeView2);
                compare(treeView2, treeView1);
            }
        }

        private void compareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
