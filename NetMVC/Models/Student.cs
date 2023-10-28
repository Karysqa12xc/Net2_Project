using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetMVC.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string FullName { get; set; }
    }
}