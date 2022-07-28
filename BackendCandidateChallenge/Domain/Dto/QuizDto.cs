using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto
{
    public class QuizDto
    {
        public int QuizId { get; set; }
        public string QuizTitle { get; set; }

        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int CorrectAnswerId { get; set; }

        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
    }
}
