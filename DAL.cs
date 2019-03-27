using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BELLayer;

using System.Configuration;
namespace DALLayer
{
    public class DAL
    {
        SqlConnection con1;
        SqlCommand com;
        SqlConnection getConnection ()
        {
            con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
            //           return( new SqlConnection("data source =FREYA; initial catalog =gic; integrated security = true"));
            return con1;
        }
        public int InsertCourse(Course course)
        {
            int flag = 0;
            using (con1 = getConnection())
            {
                // string a = ConfigurationManager.AppSettings["V"].ToString();
                //  string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();

                {


                    using (com = new SqlCommand("Insert into course (course_name, credit, semester) values (@course_name, @credit, @semester)", con1))
                    {

                        com.Parameters.AddWithValue("@course_name", course.CourseName);
                        com.Parameters.AddWithValue("@credit", course.Credit);
                        com.Parameters.AddWithValue("@semester", course.Semester);
                        con1.Open();
                        flag = com.ExecuteNonQuery();
                        con1.Close();
                    }

                }
            }
            return flag;
           
        }


        public int EditCourse(int courseId, Course course)
        {
            con1 = getConnection(); // string a = ConfigurationManager.AppSettings["V"].ToString();
            //  string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();


            //  con1 = new SqlConnection(a);
            com = new SqlCommand("Update Course set credit = @credit , Semester = @semester where course_id = @courseid", con1);

            com.Parameters.AddWithValue("@course_name", course.CourseName);
            com.Parameters.AddWithValue("@credit", course.Credit);
            com.Parameters.AddWithValue("@semester", course.Semester);

            com.Parameters.AddWithValue("@courseid", courseId);
            con1.Open();
            int flag = com.ExecuteNonQuery();
            con1.Close();
            return flag;

        }
        public int DeleteCourse(int courseId)
        {
            int flag = 0;
            using (con1 = getConnection())
            // string a = ConfigurationManager.AppSettings["V"].ToString();
            //  string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();

            {
                //  con1 = new SqlConnection(a);
                using (com = new SqlCommand("Delete Course where course_id = @courseid", con1))
                {


                    com.Parameters.AddWithValue("@courseid", courseId);
                    con1.Open();
                      flag = com.ExecuteNonQuery();
                    con1.Close();
                }
            }
            return flag;

        }
        public Course SearchCourse(string CourseName)
        {
            Course course = null;
            using (con1 = getConnection())
            {
                // string a = ConfigurationManager.AppSettings["V"].ToString();
                //  string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString();


                //  con1 = new SqlConnection(a);
                using (com = new SqlCommand("Select * from Course where course_Name = @CourseName", con1))
                {

                    com.Parameters.AddWithValue("@CourseName", CourseName);
                    con1.Open();
                    SqlDataReader read = com.ExecuteReader();
                    if (read.HasRows)
                    {
                        read.Read();
                        course = new Course();
                        course.Credit = (int)read["credit"];
                        course.Semester = (int)read["semester"];

                    }
                    read.Close();
                    con1.Close();
                } }
            return course;
        }

    }
}
