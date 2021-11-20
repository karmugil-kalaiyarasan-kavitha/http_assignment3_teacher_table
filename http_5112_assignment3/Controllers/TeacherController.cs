using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using http_5112_assignment3.Models;

namespace http_5112_assignment3.Controllers
{
    public class TeacherController : Controller
    {

        /// <summary>
        /// Returns a list of Teachers in the system and allow us to search based on hiredate,salary,teacherfname,teacherlname and teacherfname teacherlname by providong it to view
        /// </summary>
        /// <param name="SearchKey">eg:cummings</param>
        /// <example>Teacher/List</example>
        /// <returns>
        /// A list of Teachers (teacherfname,teacherlname,teacherid,employeenumber,hiredate,salary)
        /// </returns>
        // GET: Teacher/List
        [HttpGet]
        public ActionResult List(string SearchKey)
        {


            //instanciate the datacontroller for teacher.
            TeacherDataController Controller = new TeacherDataController();

            //create teacher enumerable to store the list of teachers
            IEnumerable<Teacher> Teachers = Controller.ListTeachers(SearchKey);
            return View(Teachers);
        }


        /// <summary>
        /// Returns a Teacher in the system based on the teacher id to the view
        /// </summary>
        /// <param name="id">eg:1</param>
        /// <example>Teacher/Show/{id}</example>
        /// <returns>
        /// A Teacher (teacherfname,teacherlname,teacherid,employeenumber,hiredate,salary)
        /// </returns>

        //get: Teacher/Show/{id}
        [HttpGet]
        [Route("Teacher/Show/{id}")]
        public ActionResult Show(int id)
        {
            //instanciate the datacontroller for teacher.
            TeacherDataController Controller = new TeacherDataController();
            //create a variable to store the teacher data by id
            Teacher SelectedTeacher = Controller.FindTeacher(id);


            return View(SelectedTeacher);
        }

    }
}