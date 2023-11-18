using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetMVC.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; } 
    }
}