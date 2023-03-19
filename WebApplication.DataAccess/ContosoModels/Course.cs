﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebApplication1.DataAccess.ContosoModels
{
    public partial class Course
    {
        public Course()
        {
            Enrollment = new HashSet<Enrollment>();
            Instructor = new HashSet<Person>();
        }

        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Enrollment> Enrollment { get; set; }

        public virtual ICollection<Person> Instructor { get; set; }
    }
}