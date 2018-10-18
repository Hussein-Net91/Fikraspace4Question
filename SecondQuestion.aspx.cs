using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FirstQuestion
{
    class person //خلق كلاس خاص الممثلين يحتوي على ايدي والاسم والعمر وكم مرة فاز بالاوسكار
    {
        public int id;
        public string Name;
        public int age;
        public int NumberofOscar = 0;
        public void Add(int addid, string addname, int addage)// دالة الاضافة المعلومات
        {
            id = addid;
            Name = addname;
            age = addage;
        }
        public void EditNumberofOscar()//دالة تقوم بزيادة كل مرة فاز الممثل بالاوسكار
        {
            NumberofOscar++;
        }


    }
    class Film//كلاس خاص الافلام يحتوي على معلومات الفلم واسم الممثل 
    {
        public int id;
        public string actorName;
        public string name;
        public int year;
        public void Add(int addid, string addactorname, string filmname, int addyear)//دالة الاضافة
        {
            id = addid;
            actorName = addactorname;
            name = filmname;
            year = addyear;

        }

    }
    public partial class SecondQuestion : System.Web.UI.Page 
    {
        string delimiter = ",";//رمز الفصل داخل السطر المستدعى من الملف حيث كل سطر يحتوي على معلومات يفصل بينهما فارزة نستخدم الفارزه لحصول على المعلومات صحيحة
        person[] actors = new person[89];//كلاس بعدد الممثلين
        Film[] films = new Film[89];// كلاس بعدد الافلام 
        int count = 0;
        protected void Page_Load(object sender, EventArgs e)//دالة الرئيسية
        {
            string filename = (@"C:\Users\HUSSEIN\Downloads\oscar1.csv");//الباث الخاص بالملف

            StreamReader sr = new StreamReader(filename);//تحميل الملف الى ستريم لحصول على كل البايتات الممكنة
            string allData = sr.ReadToEnd();//قراءة الملف على شكل تيكست حيث 
            string[] rows = allData.Split("\r".ToCharArray());//فصل كل سطر عن الاخر 
            for (int j = 0; j < 89; j++)//لوب يمر على كل الاسطر الممكنة
            {
                if (!string.IsNullOrEmpty(rows[j]))//يجب على السطر ان يكون فارغ او يحتوي قمية غير محددة
                {

                    string[] items = rows[j].Split(',');//فصل كل سطر الى المعلومات الصحيحة
                    Film F = new Film();//انشاء كلاس مؤقت  لاباضافة معلومات الفلم
                    F.Add(int.Parse(items[0]), items[3], items[4], int.Parse(items[1]));
                    films[j] = F;//اضافة الكلاس المؤقت الى اري كلاس فلم
                    int check = 0;//متغير يدل على ان الممثل قد سبق الحصول على اوسكار قديم
                    int index = 0;//متغير يشير الى الايدي مال الممثل
                    for (int i = 0; i < count; i++)//لوب من اجل الفحص هل سبق للممثل ان فار بالاوسكار
                    {
                        if (actors[i].Name == items[3])//اذا تكرر الاسم معنا قد فاز من قبل
                        {
                            actors[i].EditNumberofOscar();// نزيد عدد الاوسكار بمقدار 1
                            check = 1;
                            index = i;
                        }
                    }
                    if (check == 0)//هنا الممثل لم يسبق ان فار بالاوسكار وتكون الاضافة اعتيادية للملاس 
                    {
                        person s = new person();
                        s.Add(int.Parse(items[0]), items[3], int.Parse(items[2]));
                        s.EditNumberofOscar();
                        actors[count] = s;
                        count++;
                    }
                    else  //الممثل حصل على الاوسكار من قبل نضيف الممثل ونضيف عدد الذي فاز به 
                    {
                        person s = new person();
                        s.Add(int.Parse(items[0]), items[3], int.Parse(items[2]));
                        s.NumberofOscar = actors[index].NumberofOscar;
                        actors[count] = s;
                        count++;
                    }


                }
            }

        }


        String[] row = new string[6];
        protected void Button1_Click(object sender, EventArgs e)// حساب اعلى ممثل فار بالاوسكار وكم مرة فارز
        {
            DataSet dataset = new DataSet();//قاعدة بيانات موقتة لغرض عرض النتائج قي كرد فيو
            DataTable dt = new DataTable();// تيبل يحفض النتائج
            dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("age", typeof(string));
            dt.Columns.Add("year", typeof(string));// الاعمدة داخل التيبل
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Film", typeof(string));
            dt.Columns.Add("NumberofOscar", typeof(string));

            int MaxWinOscarid = 0;// متغير ابتدائي 
            int index = 0;//متغير يشر الى الممثل الذي فاز بع\\ اكثر من الاوسكار 
            for (int i = 0; i < count; i++)//لوب الايجاد الممثل الذي يملك اكثر عدد من الاوسكار
            {
                if (MaxWinOscarid < actors[i].NumberofOscar)
                {
                    MaxWinOscarid = actors[i].NumberofOscar;
                    index = i;
                }

            }
            row[0] = actors[index].id.ToString();
            row[1] = actors[index].age.ToString();
            row[2] = films[index].year.ToString();//حصول على معلومات الممثل والفلم من خلال متغير الانديكس وحفظها الى التيبل على شكل سطر 
            row[3] = actors[index].Name.ToString();
            row[4] = films[index].name.ToString();
            row[5] = actors[index].NumberofOscar.ToString();
            dt.Rows.Add(row);//اضافة السطر الى التيبل
            dataset.Tables.Add(dt);//اضافة التيبل الى قاعدة بيانات الموقتة
            GridView1.DataSource = dataset;//تحميل قاعدة بيانات المؤقتة الى كرد فيو
            GridView1.DataBind();//عرض البيانات
        }

        protected void Button2_Click(object sender, EventArgs e)//ايجاد اكبر ممثل نفس الفكرة السابقة فقط الاختلاف هنالك عدد مرات الاوسكار هنا عمر الممثل
        {
            DataSet dataset = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("age", typeof(string));
            dt.Columns.Add("year", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Film", typeof(string));
            dt.Columns.Add("NumberofOscar", typeof(string));
            int index = 0;
            int oldest = 0;

            for (int i = 0; i < count; i++)//لوب الايجاد اكبر ممثل او ممثلة فازت بالاوسكار 
            {
                if (oldest < actors[i].age)
                {
                    oldest = actors[i].age;
                    index = i;

                }


            }
            row[0] = actors[index].id.ToString();
            row[1] = actors[index].age.ToString();
            row[2] = films[index].year.ToString();
            row[3] = actors[index].Name.ToString();
            row[4] = films[index].name.ToString();
            row[5] = actors[index].NumberofOscar.ToString();
            dt.Rows.Add(row);
            dataset.Tables.Add(dt);
            GridView1.DataSource = dataset;
            GridView1.DataBind();

        }

        protected void Button3_Click(object sender, EventArgs e)//ايجاد الممثلين الذين فازو باكثر من اوسكار
        {
            DataSet dataset = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("age", typeof(string));
            dt.Columns.Add("year", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Film", typeof(string));
            dt.Columns.Add("NumberofOscar", typeof(string));
            for (int i = 0; i < count; i++)//نفس الفكرة الاولى لكن هنا عندما يكون عدد الاوسكار اكبر من وحد مباشرة يضاف الى التيبل 
            {
                if (actors[i].NumberofOscar > 1)
                {
                    row[0] = actors[i].id.ToString();
                    row[1] = actors[i].age.ToString();
                    row[2] = films[i].year.ToString();
                    row[3] = actors[i].Name.ToString();//تكون الاضافة المعلومات مباشرة داخل اللوب ومن دون الاحتفاظ بمتغير خارجي يشير الى ممثل معين
                    row[4] = films[i].name.ToString();
                    row[5] = actors[i].NumberofOscar.ToString();
                    dt.Rows.Add(row);

                }


            }

            dataset.Tables.Add(dt);
            GridView1.DataSource = dataset;
            GridView1.DataBind();

        }
    }
}