using System.IO.Pipes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetMVC.Models;
using System.Reflection.Metadata.Ecma335;

namespace NetMVC.Controllers
{
    public class PersonController : Controller
    {
        List<Person> psList = new List<Person>();
        private List<Person> CreatePersonList(){
            psList.Add(new Person{PersonID = "PS01", FullName = "Nguyen Van A", Address = "Ha Noi"});
            psList.Add(new Person{PersonID = "PS02", FullName = "Nguyen Van B", Address = "Hai Phong"});
            psList.Add(new Person{PersonID = "PS03", FullName = "Nguyen Van C", Address = "Binh Duong"});
            psList.Add(new Person{PersonID = "PS04", FullName = "Nguyen Van D", Address = "Binh Dinh"});
            psList.Add(new Person{PersonID = "PS05", FullName = "Nguyen Van E", Address = "Hue"});
            psList.Add(new Person{PersonID = "PS06", FullName = "Nguyen Van F", Address = "Vinh"});
            psList.Add(new Person{PersonID = "PS07", FullName = "Nguyen Van G", Address = "Thanh Hoa"});
            psList.Add(new Person{PersonID = "PS08", FullName = "Nguyen Van H", Address = "Yen Bai"});
            psList.Add(new Person{PersonID = "PS09", FullName = "Nguyen Van I", Address = "Nam Dinh"});
            return psList;
        }
        
        public IActionResult Index(){
            CreatePersonList();
            var PersonInfo = psList.ToList();
            return View(PersonInfo);
        }
        [HttpPost]
        public IActionResult Index(Person p){
            ViewBag.KetQua = p.PersonID  + " - " + p.FullName + " - " + p.Address;
            return View();
        }
    }
}