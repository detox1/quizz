using Core.Domain.Entity;
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
        Quiz GetById(int id);
    }
}
