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
    public partial class Question3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)// دالة تحول الرقم الى الاسم الرقم
        {
            string OutNumber = "";//الناتج النهائي على شكل سترينج
            foreach (char Number in InNumber.Text)//لوب يمر على كل الارقام الموجود في التيكست بوكس
            {
                switch (Number)//اداة تطابق اذا تطابق مع احد الشروط فانه يظيفه الى الناتج
                {
                    case '0':
                        OutNumber = OutNumber + "Zero ";
                        break;
                    case '1':
                        OutNumber = OutNumber + "One ";
                        break;
                    case '2':
                        OutNumber = OutNumber + "Two ";
                        break;
                    case '3':
                        OutNumber = OutNumber + "Three ";
                        break;
                    case '4':
                        OutNumber = OutNumber + "Four ";
                        break;
                    case '5':
                        OutNumber = OutNumber + "Five ";
                        break;
                    case '6':
                        OutNumber = OutNumber + "Six ";
                        break;
                    case '7':
                        OutNumber = OutNumber + "Seven ";
                        break;
                    case '8':
                        OutNumber = OutNumber + "Eight ";
                        break;
                    case '9':
                        OutNumber = OutNumber + "Nine ";
                        break;
                }

            }
            FinalNumber.Text = OutNumber;//النتيجة النهائية تضاف الى تيكست بوكس النهائي 
        }
    }
}