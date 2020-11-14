using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Konusarak_ogren.Models;

namespace Konusarak_ogren.Controllers
{
    public class LoginController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(TblUser modelUser)
        {
            Db_Language_CourseContext dbContext = new Db_Language_CourseContext();
            var allUsers = dbContext.TblUsers.ToList();

            var user = allUsers.Where(m => m.UserName == modelUser.UserName && m.Password == modelUser.Password).FirstOrDefault();

            if (user !=null)
            {
                if(user.Role==1)
                {
                    //öğretmen paneline git
                    return RedirectToAction("Index", "Teacher");
                }
                else if(user.Role==2)
                {
                    //öğrenci paneline git
                    return RedirectToAction("Index", "Student");
                }
                else
                {
                    return RedirectToAction("Login", "Login");
                    //login sayfasına git. 
                }
            }

            return View();

        }
    }
}
