using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Konusarak_ogren.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Konusarak_ogren.Controllers
{
    public class TeacherController : Controller
    {
        Db_Language_CourseContext db = new Db_Language_CourseContext();
        public IActionResult Index()
        {
            var dgr = db.TblArticles.ToList();
            return View(dgr);
        }

        public IActionResult listExam()
        {
            var exam = db.TblExams.ToList();
            return View(exam);

        }
        public IActionResult deleteExam(int id)
        {
            var deleteExam = db.TblExams.Find(id);
            var deleteQuestion = db.TblQuestions.Where(x => x.ExamId == id).FirstOrDefault();

            db.TblExams.Remove(deleteExam);
            db.TblQuestions.Remove(deleteQuestion);

            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult detail(int id)
        {
            TeacherDetailModel teacherDateyModel = new TeacherDetailModel();

            teacherDateyModel.tblArticle = db.TblArticles.Find(id);

            List<QuestionChosesModel> choseList = new List<QuestionChosesModel>();
            QuestionChosesModel choseItem1 = new QuestionChosesModel();
            choseItem1.chooseKey = "A";
            choseItem1.chooseValue = "A";

            QuestionChosesModel choseItem2 = new QuestionChosesModel();
            choseItem2.chooseKey = "B";
            choseItem2.chooseValue = "B";


            QuestionChosesModel choseItem3 = new QuestionChosesModel();
            choseItem3.chooseKey = "C";
            choseItem3.chooseValue = "C";


            QuestionChosesModel choseItem4 = new QuestionChosesModel();
            choseItem4.chooseKey = "D";
            choseItem4.chooseValue = "D";

            choseList.Add(choseItem1);
            choseList.Add(choseItem2);
            choseList.Add(choseItem3);
            choseList.Add(choseItem4);


            ViewBag.choseList = new SelectList(choseList, "chooseKey", "chooseValue");

            return View(teacherDateyModel);


        }
        public IActionResult createExam(TeacherDetailModel teacherDetailModel)
        {
            TblExam tblExam = new TblExam();
            tblExam.ExamDate = DateTime.Now.ToLongDateString();
            tblExam.ArticleId = teacherDetailModel.tblArticle.Id;
            tblExam.ArticleTitle = teacherDetailModel.tblArticle.ArticleTitle;
            tblExam.Status = true;

            db.TblExams.Add(tblExam);
            db.SaveChanges();

            var exam = db.TblExams.OrderByDescending(u => u.Id).FirstOrDefault();

            TblQuestion question = new TblQuestion();
            question.Status = true;
            question.ExamId = exam.Id;


            question.Question1Text = teacherDetailModel.question.Question1Text;
            question.Option1A = teacherDetailModel.question.Option1A;
            question.Option1B = teacherDetailModel.question.Option1B;
            question.Option1C = teacherDetailModel.question.Option1C;
            question.Option1D = teacherDetailModel.question.Option1D;
            question.CorrectAnswer1 = teacherDetailModel.question.CorrectAnswer1;


            question.Question2Text = teacherDetailModel.question.Question2Text;
            question.Option2A = teacherDetailModel.question.Option2A;
            question.Option2B = teacherDetailModel.question.Option2B;
            question.Option2C = teacherDetailModel.question.Option2C;
            question.Option2D = teacherDetailModel.question.Option2D;
            question.CorrectAnswer2 = teacherDetailModel.question.CorrectAnswer2;


            question.Question3Text = teacherDetailModel.question.Question3Text;
            question.Option3A = teacherDetailModel.question.Option3A;
            question.Option3B = teacherDetailModel.question.Option3B;
            question.Option3C = teacherDetailModel.question.Option3C;
            question.Option3D = teacherDetailModel.question.Option3D;
            question.CorrectAnswer3 = teacherDetailModel.question.CorrectAnswer3;


            question.Question4Text = teacherDetailModel.question.Question4Text;
            question.Option4A = teacherDetailModel.question.Option4A;
            question.Option4B = teacherDetailModel.question.Option4B;
            question.Option4C = teacherDetailModel.question.Option4C;
            question.Option4D = teacherDetailModel.question.Option4D;
            question.CorrectAnswer4 = teacherDetailModel.question.CorrectAnswer4;

            db.TblQuestions.Add(question);
            db.SaveChanges();

            return RedirectToAction("detail");


        }

        public IActionResult creatQuestion(TblQuestion tblQuestion)
        {
            TblQuestion question = new TblQuestion();
            question.Status = true;

            question.Question1Text = tblQuestion.Question1Text;
            question.Option1A = tblQuestion.Option1A;
            question.Option1B = tblQuestion.Option1B;
            question.Option1C = tblQuestion.Option1C;
            question.Option1D = tblQuestion.Option1D;
            question.CorrectAnswer1 = tblQuestion.CorrectAnswer1;


            question.Question2Text = tblQuestion.Question2Text;
            question.Option2A = tblQuestion.Option2A;
            question.Option2B = tblQuestion.Option2B;
            question.Option2C = tblQuestion.Option2C;
            question.Option2D = tblQuestion.Option2D;
            question.CorrectAnswer2 = tblQuestion.CorrectAnswer2;


            question.Question3Text = tblQuestion.Question3Text;
            question.Option3A = tblQuestion.Option3A;
            question.Option3B = tblQuestion.Option3B;
            question.Option3C = tblQuestion.Option3C;
            question.Option3D = tblQuestion.Option3D;
            question.CorrectAnswer3 = tblQuestion.CorrectAnswer3;


            question.Question4Text = tblQuestion.Question4Text;
            question.Option4A = tblQuestion.Option4A;
            question.Option4B = tblQuestion.Option4B;
            question.Option4C = tblQuestion.Option4C;
            question.Option4D = tblQuestion.Option4D;
            question.CorrectAnswer4 = tblQuestion.CorrectAnswer4;

            db.TblQuestions.Add(tblQuestion);
            db.SaveChanges();

            return RedirectToAction("detail");
        }
    }
}
