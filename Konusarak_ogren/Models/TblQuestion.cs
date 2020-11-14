using System;
using System.Collections.Generic;

#nullable disable

namespace Konusarak_ogren.Models
{
    public partial class TblQuestion
    {
        public int Id { get; set; }
        public int? ExamId { get; set; }
        public bool? Status { get; set; }
        public string Question1Text { get; set; }
        public string Option1A { get; set; }
        public string Option1B { get; set; }
        public string Option1C { get; set; }
        public string Option1D { get; set; }
        public string CorrectAnswer1 { get; set; }
        public string Question2Text { get; set; }
        public string Option2A { get; set; }
        public string Option2B { get; set; }
        public string Option2C { get; set; }
        public string Option2D { get; set; }
        public string CorrectAnswer2 { get; set; }
        public string Question3Text { get; set; }
        public string Option3A { get; set; }
        public string Option3B { get; set; }
        public string Option3C { get; set; }
        public string Option3D { get; set; }
        public string CorrectAnswer3 { get; set; }
        public string Question4Text { get; set; }
        public string Option4A { get; set; }
        public string Option4B { get; set; }
        public string Option4C { get; set; }
        public string Option4D { get; set; }
        public string CorrectAnswer4 { get; set; }

        public virtual TblExam Exam { get; set; }
    }
}
