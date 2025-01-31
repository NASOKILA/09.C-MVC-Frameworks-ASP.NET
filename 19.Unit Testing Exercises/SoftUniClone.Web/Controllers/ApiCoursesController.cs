﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SoftUniClone.Models;
using SoftUniClone.Web.Models;

namespace SoftUniClone.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiCoursesController : Controller
    {
        private readonly List<Course> Courses;

        public ApiCoursesController()
        {
            this.Courses = new List<Course>()
            {
               new Course(){  Id = 1, Name = "Course 1"},
               new Course(){  Id = 2, Name = "Course 2"},
               new Course(){  Id = 3, Name = "Course 3"},
               new Course(){  Id = 4, Name = "Course 4"},
            };
        }

        [HttpGet("")]
        public IActionResult GetAllCourses()
        {
            return Ok(this.Courses); 
        }

        [HttpGet("{id}")]
        public IActionResult GetCourseById(int id)
        {
            Course course = this.Courses.FirstOrDefault(c => c.Id == id);

            if(course == null)
                return NotFound(new { Message = "Course not found with id " + id + "."}); // 404

            return Ok(course); 
            
        }

        [HttpPost("")]
        public IActionResult CreateCourse([FromBody]CourseCreationModel course)
        {

            if (!this.ModelState.IsValid)
                return BadRequest();

            Course courseAdd = new Course()
            {
                Id = course.Id,
                Name = course.Name
            };

            this.Courses.Add(courseAdd);

            return Created("", course); 
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCourse(int id, [FromBody]CourseCreationModel course)
        {
            if (!this.ModelState.IsValid)
                return BadRequest();

            var coursetoReplace = this.Courses.FirstOrDefault(c => c.Id == id);

            if (coursetoReplace == null)
                return NotFound(new { Message = "The id " + id + " does not match!"});
            
            foreach (var c in this.Courses) {
                if (c.Id == id) {
                    c.Id = course.Id;
                    c.Name = course.Name;

                    return Accepted("Updted Successfully", c); //202 
                }
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCourse(int id)
        {
            if (!this.ModelState.IsValid)
                return BadRequest();
            
            var courseToRemove = this.Courses.FirstOrDefault(c => c.Id == id);

            if (courseToRemove == null)
                return NotFound(new { Message = "The id " + id + " does not match!" });

            this.Courses.Remove(courseToRemove);

            return Accepted(new { Message = "The course with id " + id + " was deleted !" });
        }
    }
}
