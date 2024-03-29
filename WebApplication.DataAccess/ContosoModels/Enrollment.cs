﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.DataAccess.ContosoModels
{
    [Index("CourseId", Name = "IX_CourseID")]
    [Index("StudentId", Name = "IX_StudentID")]
    public partial class Enrollment
    {
        [Key]
        [Column("EnrollmentID")]
        public int EnrollmentId { get; set; }
        [Column("CourseID")]
        public int CourseId { get; set; }
        [Column("StudentID")]
        public int StudentId { get; set; }
        public int? Grade { get; set; }

        [ForeignKey("CourseId")]
        [InverseProperty("Enrollment")]
        public virtual Course Course { get; set; }
        [ForeignKey("StudentId")]
        [InverseProperty("Enrollment")]
        public virtual Person Student { get; set; }
    }
}