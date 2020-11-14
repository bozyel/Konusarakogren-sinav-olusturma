using System;
using System.Collections.Generic;

#nullable disable

namespace Konusarak_ogren.Models
{
    public partial class TblExam
    {
        public TblExam()
        {
            TblQuestions = new HashSet<TblQuestion>();
        }

        public int Id { get; set; }
        public string ExamDate { get; set; }
        public int? ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public bool? Status { get; set; }

        public virtual TblArticle Article { get; set; }
        public virtual ICollection<TblQuestion> TblQuestions { get; set; }
    }
}
