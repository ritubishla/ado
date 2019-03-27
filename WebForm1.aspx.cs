using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BALLayer;
using BELLayer;
namespace Client1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BAL bal = new BAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertCourse_Click(object sender, EventArgs e)
        {
            //Course c1 = new Course();
            //c1.CourseName = txtCourseName.Text;
            //c1.Credit [= 
            Course course = new Course() {  CourseName = txtCourseName.Text , Credit = Convert.ToInt32(txtCredit.Text)  , Semester = Convert.ToInt32(txtSemester.Text) };
            int flag = bal.InsertCourse(course);
             if (flag > 0)
            {
                lblMessage.Text = "Record inserted";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Course course = new Course() { CourseName = txtCourseName.Text, Credit = Convert.ToInt32(txtCredit.Text), Semester = Convert.ToInt32(txtSemester.Text) };

            int flag = bal.EditCourse(Convert.ToInt32(txtCourseId.Text) , course);
            if (flag > 0)
            {
                lblMessage.Text = "Record edited";
            }

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int flag = bal.DeleteCourse(Convert.ToInt32(txtCourseId.Text));
            if (flag > 0)
            {
                lblMessage.Text = "Record deleted";
            }

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
             Course course = bal.SearchCourse(txtCourseName.Text);
            if (course != null)
            {
                txtCourseName.Text = course.CourseName;
                txtCredit.Text = course.Credit.ToString();
                txtSemester.Text = course.Semester.ToString();
            }
            else {
                lblMessage.Text = "Such Course do not exist";
            }

        }
    }
}