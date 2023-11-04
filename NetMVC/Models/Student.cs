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
        public required string StudentID { get; set; }
        public required string Fullname { get; set; }
        public required int Age { get; set; }
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }
        public required string Address { get; set; }
        [DataType(DataType.DateTime)]
        public required DateTime birthDay { get; set; }
        
        public required bool isActive { get; set; }
    }
}