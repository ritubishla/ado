using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLayer;
using BELLayer;
namespace BALLayer
{
    public class BAL
    {
        DAL dal = new DAL();

        public int InsertCourse(Course course)
        {
            return (dal.InsertCourse(course));
        }

        public int EditCourse(int courseId, Course course)
        {
            return dal.EditCourse(courseId, course);
        }
        public int DeleteCourse(int courseId)
        {
            return dal.DeleteCourse(courseId);
        }
        public Course SearchCourse(string CourseName)
        {
            return dal.SearchCourse(CourseName);
        }
    }
}
