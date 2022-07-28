using Core.Domain.Entity;
using Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories.QuizRepository
{
    public interface IQuizRepository : IRepository<Quiz>
    {
        IEnumerable<Quiz> GetAll();
        IEnumerable<QuizDto> GetQuizDetails(int quizId);
    }
}
