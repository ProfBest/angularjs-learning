using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using  Dapper;
using TwoWayBindingDemo.Models;

namespace TwoWayBindingDemo.Controllers
{
    public class TodoController : Controller
    {
        
        public ActionResult Index()
        {

           

            return View();
        }


        [HttpPost]
        public JsonResult TodoList()
        {

            var conn = DataProvider.GetConnection();
            var todoItems = conn.Query<ToDo>("usp_getTodos");

            return Json(todoItems );
        }

    }
}