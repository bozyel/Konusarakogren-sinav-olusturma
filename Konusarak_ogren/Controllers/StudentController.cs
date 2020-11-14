using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Konusarak_ogren.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Konusarak_ogren.Controllers
{
    public class StudentController : Controller
    {
        Db_Language_CourseContext db = new Db_Language_CourseContext();
        public IActionResult Index()
        {
            TeacherDetailModel teacherDateyModel = new TeacherDetailModel();

            var lastExam = db.TblExams.OrderByDescending(m => m.Id).FirstOrDefault();
            teacherDateyModel.tblArticle = db.TblArticles.Where(m=> m.Id==lastExam.ArticleId).FirstOrDefault();
            teacherDateyModel.question = db.TblQuestions.Where(m => m.ExamId == lastExam.Id).FirstOrDefault();

            return View(teacherDateyModel);
        }
    }
}
