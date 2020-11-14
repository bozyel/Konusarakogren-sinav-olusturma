using System;
using System.Collections.Generic;

#nullable disable

namespace Konusarak_ogren.Models
{
    public partial class TblArticle
    {
        public TblArticle()
        {
            TblExams = new HashSet<TblExam>();
        }

        public int Id { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public DateTime? ArticleDate { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<TblExam> TblExams { get; set; }
    }
}
