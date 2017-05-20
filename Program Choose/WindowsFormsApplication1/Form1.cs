using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Form1 F1;
        ComboBox[] box=new ComboBox[30];
        ComboBox aa;
        string[] Grind = new string[10];
        string[] Dress = new string[10];
        string[] Tool = new string[10];
        string[] filepath=new string[2];
        string sourcepath;
        string aimpath;
        string path0="sourcepath.ini";
        int num;


        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
#region 读取上次选择的源程序，作为本次默认程序库
            if ((System.IO.File.Exists(path0)))  //读取上次选择的源程序，作为本次默认程序库
            {
                FileInfo sou = new FileInfo(path0);
                if (sou.Length <= 0)
                {
                    MessageBox.Show("请添加源程序！");
                }
                else
                {
                    StreamReader souread = new StreamReader(path0, Encoding.UTF8, true);
                    sourcepath = souread.ReadLine();
                    souread.Close();
                }

            }
#endregion
        }

        private void 选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
                {
                    sourcepath=folder.SelectedPath;
                    StreamWriter writerpath0 = new StreamWriter(path0, false, Encoding.UTF8, 1024);//写入路径
                    writerpath0.WriteLine(sourcepath);
                    writerpath0.Close();
                    
                }
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if ((!System.IO.File.Exists(path0)))  //user.ini 如果不存在创建
            {
                System.IO.File.Create(path0).Close();

            }
            else
            {
                FileInfo sou = new FileInfo(path0);
                if (sou.Length <= 0)
                {
                    MessageBox.Show("请添加源程序！");
                }
                else
                {
                    StreamReader souread = new StreamReader(path0, Encoding.UTF8, true);
                    string ss = souread.ReadLine();
                    MessageBox.Show(ss);
                }

            }

        }

        private void change(string path, ComboBox box1, ComboBox box2)
        {
            if (box1.Text != null)
            {
                DirectoryInfo folder = new DirectoryInfo(path);
                DirectoryInfo[] chldFolders = folder.GetDirectories();
                //MessageBox.Show(chldFolders[0].ToString());
                if (chldFolders.Length <= 0)
                {
                    box2.Text = null;
                    box2.Visible = false;
                }
                else
                {
                    box2.Visible = true;
                }
                box2.DataSource = chldFolders;
            }
            else
            {
                box2.Text = null;
                box2.Visible = false;
            }
        }
#region Grind
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 1;
            if (comboBox1.Text!=null)
            {
                Grind[num] = Grind[num - 1] + "//" + comboBox1.Text;
                change(Grind[num], comboBox1, comboBox2);
            } 
            else
            {
                Grind[num] = null;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 2;
            if (comboBox2.Text!=null)
            {
                Grind[num] = Grind[num - 1] + "//" + comboBox2.Text;
                change(Grind[num], comboBox2, comboBox3);
            } 
            else
            {
                Grind[num] = null;

            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 3;
            if (comboBox3.Text!=null)
            {
                Grind[num] = Grind[num - 1] + "//" + comboBox3.Text;
                change(Grind[num], comboBox3, comboBox4);
            }
            else
            {
                Grind[num] = null;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 4;
            if (comboBox4.Text != null)
            {
                Grind[num] = Grind[num - 1] + "//" + comboBox4.Text;
                change(Grind[num], comboBox4, comboBox5);
            }
            else
            {
                Grind[num] = null;
            }

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 5;
            if (comboBox5.Text != null)
            {
                Grind[num] = Grind[num - 1] + "//" + comboBox5.Text;
                change(Grind[num], comboBox5, comboBox6);
            }
            else
            {
                Grind[num] = null;
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 6;
            if (comboBox6.Text != null)
            {
                Grind[num] = Grind[num - 1] + "//" + comboBox6.Text;
                change(Grind[num], comboBox6, comboBox7);
            }
            else
            {
                Grind[num] = null;
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 7;
            if (comboBox7.Text != null)
            {
                Grind[num] = Grind[num - 1] + "//" + comboBox7.Text;
                change(Grind[num], comboBox7, comboBox8);
            }
            else
            {
                Grind[num] = null;
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 8;
            if (comboBox8.Text != null)
            {
                Grind[num] = Grind[num - 1] + "//" + comboBox8.Text;
                change(Grind[num], comboBox8, comboBox9);
            }
            else
            {
                Grind[num] = null;
            }

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 9;
            if (comboBox9.Text != null)
            {
                Grind[num] = Grind[num - 1] + "//" + comboBox9.Text;
                change(Grind[num], comboBox9, comboBox10);
            }
            else
            {
                Grind[num] = null;
            }

        }
#endregion

#region Dress

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 1;
            if (comboBox11.Text!=null)
            {
                Dress[num] = Dress[num - 1] + "//" + comboBox11.Text;
                change(Dress[num], comboBox11, comboBox12);
            }
            else
            {
                Dress[num] = null;
            }
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 2;
            if (comboBox12.Text != null)
            {
                Dress[num] = Dress[num - 1] + "//" + comboBox12.Text;
                change(Dress[num], comboBox12, comboBox13);
            }
            else
            {
                Dress[num] = null;
            }
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 3;
            if (comboBox13.Text != null)
            {
                Dress[num] = Dress[num - 1] + "//" + comboBox13.Text;
                change(Dress[num], comboBox13, comboBox14);
            }
            else
            {
                Dress[num] = null;
            }
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 4;
            if (comboBox14.Text != null)
            {
                Dress[num] = Dress[num - 1] + "//" + comboBox14.Text;
                change(Dress[num], comboBox14, comboBox15);
            }
            else
            {
                Dress[num] = null;
            }
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 5;
            if (comboBox15.Text != null)
            {
                Dress[num] = Dress[num - 1] + "//" + comboBox15.Text;
                change(Dress[num], comboBox15, comboBox16);
            }
            else
            {
                Dress[num] = null;
            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 6;
            if (comboBox16.Text != null)
            {
                Dress[num] = Dress[num - 1] + "//" + comboBox16.Text;
                change(Dress[num], comboBox16, comboBox17);
            }
            else
            {
                Dress[num] = null;
            }
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 7;
            if (comboBox17.Text != null)
            {
                Dress[num] = Dress[num - 1] + "//" + comboBox17.Text;
                change(Dress[num], comboBox17, comboBox18);
            }
            else
            {
                Dress[num] = null;
            }
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 8;
            if (comboBox18.Text != null)
            {
                Dress[num] = Dress[num - 1] + "//" + comboBox18.Text;
                change(Dress[num], comboBox18, comboBox19);
            }
            else
            {
                Dress[num] = null;
            }
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 9;
            if (comboBox19.Text != null)
            {
                Dress[num] = Dress[num - 1] + "//" + comboBox19.Text;
                change(Dress[num], comboBox19, comboBox20);
            }
            else
            {
                Dress[num] = null;
            }

        }

#endregion

#region Tool_set


        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 1;
            if (comboBox21.Text!=null)
            {
                Tool[num] = Tool[num - 1] + "//" + comboBox21.Text;
                change(Tool[num], comboBox21, comboBox22);
            }
            else
            {
                Tool[num] = null;
            }
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 2;
            if (comboBox22.Text != null)
            {
                Tool[num] = Tool[num - 1] + "//" + comboBox22.Text;
                change(Tool[num], comboBox22, comboBox23);
            }
            else
            {
                Tool[num] = null;
            }
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 3;
            if (comboBox23.Text != null)
            {
                Tool[num] = Tool[num - 1] + "//" + comboBox23.Text;
                change(Tool[num], comboBox23, comboBox24);
            }
            else
            {
                Tool[num] = null;
            }
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 4;
            if (comboBox24.Text != null)
            {
                Tool[num] = Tool[num - 1] + "//" + comboBox24.Text;
                change(Tool[num], comboBox24, comboBox25);
            }
            else
            {
                Tool[num] = null;
            }
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 5;
            if (comboBox25.Text != null)
            {
                Tool[num] = Tool[num - 1] + "//" + comboBox25.Text;
                change(Tool[num], comboBox25, comboBox26);
            }
            else
            {
                Tool[num] = null;
            }
        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 6;
            if (comboBox26.Text != null)
            {
                Tool[num] = Tool[num - 1] + "//" + comboBox26.Text;
                change(Tool[num], comboBox26, comboBox27);
            }
            else
            {
                Tool[num] = null;
            }
        }

        private void comboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 7;
            if (comboBox27.Text != null)
            {
                Tool[num] = Tool[num - 1] + "//" + comboBox27.Text;
                change(Tool[num], comboBox27, comboBox28);
            }
            else
            {
                Tool[num] = null;
            }
        }

        private void comboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 8;
            if (comboBox28.Text != null)
            {
                Tool[num] = Tool[num - 1] + "//" + comboBox28.Text;
                change(Tool[num], comboBox28, comboBox29);
            }
            else
            {
                Tool[num] = null;
            }
        }

        private void comboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 9;
            if (comboBox29.Text != null)
            {
                Tool[num] = Tool[num - 1] + "//" + comboBox29.Text;
                change(Tool[num], comboBox29, comboBox30);
            }
            else
            {
                Tool[num] = null;
            }
        }

#endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Grind[0] = sourcepath + "//" + "Soure_Library" + "//" + "CMA" + "//" + "Grind";
            comboBox1.Visible = true;
            DirectoryInfo folder = new DirectoryInfo(Grind[0]);
            DirectoryInfo[] chldFolders = folder.GetDirectories();
            comboBox1.DataSource = chldFolders;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dress[0] = sourcepath + "//" + "Soure_Library" + "//" + "CMA" + "//" + "Dress";
            comboBox11.Visible = true;
            DirectoryInfo folder = new DirectoryInfo(Dress[0]);
            DirectoryInfo[] chldFolders = folder.GetDirectories();
            comboBox11.DataSource = chldFolders;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tool[0] = sourcepath + "//" + "Soure_Library" + "//" + "CMA" + "//" + "Tool_Set";
            comboBox21.Visible = true;
            DirectoryInfo folder = new DirectoryInfo(Tool[0]);
            DirectoryInfo[] chldFolders = folder.GetDirectories();
            comboBox21.DataSource = chldFolders;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请选择程序存储位置！");
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                aimpath = folder.SelectedPath;
                
                for (int i = 0; i < 10;i++ )
                {
                    //MessageBox.Show(Grind[i]);
                    //MessageBox.Show(Dress[i]);
                    //MessageBox.Show(Tool[i]);
                    if (Grind[i]!=null)
                    {
                        copy(Grind[i], aimpath);
                    }
                    if (Dress[i]!=null)
                    {
                        copy(Dress[i], aimpath);
                    }
                    if (Tool[i]!=null)
                    {
                        copy(Tool[i], aimpath);
                    }
                }
                MessageBox.Show("新程序生成完成！");

            }
        }

        private void copy(string a,string b)
        {
            string[] chldFiles = Directory.GetFiles(a);
            if (chldFiles.Length > 0)
            {
                foreach (string file1 in chldFiles)
                {
                    FileInfo filename = new FileInfo(file1);
                    string bb = b + "//" + filename.Name;
                    File.Copy(file1, bb,true);
                }
            }
        }
    }
}
