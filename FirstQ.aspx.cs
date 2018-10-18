using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Threading.Tasks;
using RestSharp;// استدعاء  هذه المكتبة تعامل مع صفحات اجتتبي كلاينت 
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;

namespace FirstQuestion
{
    class Comment
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; } //  بناء كلاس بنفس الحقول الموجود معلومات كومنت الماخوذة من صفحة الجيسون
        public string email { get; set; }
        public string body { get; set; }
    }
    class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }//               بناء كلاس بنفس الحقول الموجود معلومات البوست الماخوذة من صفحة الجيسون
        public string body { get; set; }
    }
    class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }//               بناء كلاس بنفس الحقول الموجود معلومات اليوزر الماخوذة من صفحة الجيسون
        public string email { get; set; }
        public string phone { get; set; }
        public string website { get; set; }

    }
    public partial class FirstQ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) //  تعمل عند بدء تحميل الصفحة وذالك لكي تقوم بتحميل اليوزرز ايدي المتوفرة
        {
            if (!Page.IsPostBack)
            {

                var client = new RestClient   // خلق كلاينت لمسك الجيسون اوبجكت
                {
                    BaseUrl = new Uri("https://jsonplaceholder.typicode.com").ToString()//تحميل الرابط
                };
                var request = new RestRequest("users", Method.GET);//تنفيذ الطلب مع اعطاء اسم للداتا ونوع التنفيذ هل هو كيت لو بوست 
                var Response = client.Execute<List<User>>(request);//تنفيذ الطلب يكون على شكل الكلاس يوزر 
                var ResponseData = Response.Data;//تحميل الداتا

                foreach (User user in ResponseData)//اخذ فقط اليوزر ايدي وتحميله الى دروب داون لست لكي يسهل اختيار الاايدي المطلوب
                    UserId.Items.Add(user.id.ToString());
            }
               

        
    }

        protected void UserId_SelectedIndexChanged(object sender, EventArgs e)//عند اختيار الايدي المطلوب نقوم بتحميل  البوستات
        {
            var client = new RestClient// خلق كلاينت تحميل الجيسون اوبجكت
            {
                BaseUrl = new Uri("https://jsonplaceholder.typicode.com").ToString()//تحميل الرابط
            };
            var request = new RestRequest("posts", Method.GET);//نقوم بختيار البوستات
            var Response = client.Execute<List<Post>>(request);//تنفيذ الطلب يكون على شكل الكلاس بوست 
            var ResponseData = Response.Data;//تحميل الديتا

            DataSet dataset = new DataSet();//قاعدة بيانات موقتة لغرض عرض النتائج قي كرد فيو
            DataTable dt = new DataTable();// تيبل يحفض النتائج
            dt.Columns.Add("userId", typeof(string));
            dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("title", typeof(string));// الاعمدة داخل التيبل
            dt.Columns.Add("body", typeof(string));
            String[] row = new string[4];//انشاء سطر 
            foreach (Post post in ResponseData)//لوب يمر على كل جايسون اوبجكت الموجودة في الريسبونس ديتا
            {if (post.userId.ToString() == UserId.Text)//نقوم بتحميل البوستات الخاصة باليوزر ايدي فقط
                {
                    row[0] = post.userId.ToString();
                    row[1] = post.id.ToString();
                    row[2] = post.title.ToString();//حصول على معلومات البوست من خلال متغير  وحفظها الى التيبل على شكل سطر 
                    row[3] = post.body.ToString();
                    dt.Rows.Add(row);//اضافة السطر الى التيبل
                }
            }
            dataset.Tables.Add(dt);//اضافة التيبل الى قاعدة بيانات الموقتة
            GridView1.DataSource = dataset;//تحميل قاعدة بيانات المؤقتة الى كرد فيو
            GridView1.DataBind();//عرض البيانات
        

    }

        protected void UserId_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)//عند الضغط على الرز الخاص بعرض التعليقات 
        {
            if (e.CommandName == "1")//الكود المرسل عند اختيار البوست من الداتا كرد فيو رقم 1
            {
                int index = Convert.ToInt32(e.CommandArgument);//نحدد اي سطر تم اختياره لتحديد اي بوست
                GridViewRow Gridrow = GridView1.Rows[index];
                String PostID = GridView1.Rows[index].Cells[2].Text;//نختار البوست ايدي
                var client = new RestClient// خلق كلاينت لمسك الجيسون اوبجكت
                {
                    BaseUrl = new Uri("https://jsonplaceholder.typicode.com").ToString()//تحميل الرابط
                };
                var request = new RestRequest("comments", Method.GET);//نقوم بختيار التعليقات
                var Response = client.Execute<List<Comment>>(request);
                var ResponseData = Response.Data;
                DataSet dataset = new DataSet();//قاعدة بيانات موقتة لغرض عرض النتائج قي كرد فيو
                DataTable dt = new DataTable();// تيبل يحفض النتائج
                dt.Columns.Add("postId", typeof(string));
                dt.Columns.Add("id", typeof(string));
                dt.Columns.Add("name", typeof(string));// الاعمدة داخل التيبل
                dt.Columns.Add("email", typeof(string));
                dt.Columns.Add("body", typeof(string));
                String[] row = new string[5];//انشاء سطر 
                foreach (Comment comentt in ResponseData)//لوب يمر على كل جايسون اوبجكت الموجودة في الريسبونس ديتا
                {
                    if (comentt.postId.ToString() == PostID)//نقوم بتحميل البوستات الخاصة بوست ايدي فقط
                    {
                       
                        row[0] = comentt.postId.ToString();
                        row[1] = comentt.id.ToString();
                        row[2] = comentt.name.ToString();//حصول على معلومات البوست من خلال متغير  وحفظها الى التيبل على شكل سطر 
                        row[3] = comentt.email.ToString();
                        row[3] = comentt.body.ToString();
                        dt.Rows.Add(row);//اضافة السطر الى التيبل
                    }

                }
                dataset.Tables.Add(dt);//اضافة التيبل الى قاعدة بيانات الموقتة
                GridView2.DataSource = dataset;//تحميل قاعدة بيانات المؤقتة الى كرد فيو
                GridView2.DataBind();//عرض البيانات
            }
        }
    }
}