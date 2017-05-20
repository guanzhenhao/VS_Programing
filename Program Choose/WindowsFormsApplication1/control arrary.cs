using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class control_arrary
    {
        public ComboBox[] box=new ComboBox[30];
        public control_arrary(Form1 aa)
        {
            foreach (Control oCon in aa.Controls)//遍历选定窗口所有控件
            {

                if (oCon.GetType().ToString() == "System.Windows.Forms.ComboBox")//选出combobox控件
                {
                    int lNameLength = oCon.Name.Length;//控件名字长度
                    int numlength = lNameLength - 8;
                    int i = Convert.ToInt16(oCon.Name.Substring(8, numlength))-1;//获取comboBox控件后缀编号
                    box[i] = (ComboBox)oCon;
                    //MessageBox.Show(i.ToString());
                    //MessageBox.Show(box[i].Name);
                }
            }
        }
    }
}
