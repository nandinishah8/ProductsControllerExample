﻿using Microsoft.AspNetCore.Mvc;

namespace ProductcontrollerExample.Controllers
{
    public class ProductsController : Controller
    {
        public string Index()
        {
            return "This is the index action method....";
        }
        public string Details()
        {
            return "This is the detail action method......";
        }
        public string Create()
        {
            return "This is the create action method....";
        }

        public string Edit()
        {
            return "This is the edit action method....";
        }
        public string Delete()
        {
            return "This is the delete action method...";
        }
    }
}