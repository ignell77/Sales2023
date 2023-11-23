﻿using Microsoft.AspNetCore.Mvc;
using System;
using SalesWebMvc1.Models;
using System.Collections.Generic;

namespace SalesWebMvc1.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department {Id = 1, Name = "Eletronics" });
            list.Add(new Department {Id = 2, Name = "Fashion" });
            
            
            
            return View(list);
        }
    }
}
