using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Web.Configuration;


namespace FirstQuestion
{
    public partial class LastQuestion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FirstListTextBox.Text.Length == SecondListTextBox.Text.Length)//للتاكد ان حجم اللست متساوي اما اذا كان غير متساوي هناك حل اخر 
            {
                char[] FirstList = FirstListTextBox.Text.ToString().Replace(",", "").ToCharArray();//حذف الفوارز 
                char[] SecondList = SecondListTextBox.Text.ToString().Replace(",", "").ToCharArray();//حذف الفوارز
                var Margelist = new List<char>();//ان شاء لست نوع كاركتير
                for (int i = 0; i < FirstList.Length; i++)//لوب لغرض الدمج بين الاثنين
                {
                    Margelist.Add(FirstList[i]);//اضافة سلسلة الاولى
                    Margelist.Add(',');//اضافة فارزة
                    Margelist.Add(SecondList[i]);//اضافة سلسلة الثانية
                    if (i != FirstList.Length - 1)//للتاكد ان لايضيف فارز لاخر حرف بالسلسلة
                        Margelist.Add(',');
                }
                foreach (char i in Margelist)
                {
                    FinalList.Text = FinalList.Text + i.ToString();//عرض السلسلة في التيكست بوكس

                }

            }

        }
    }
}