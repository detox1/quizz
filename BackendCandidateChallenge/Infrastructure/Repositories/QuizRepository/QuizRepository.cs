using Application.Interfaces.Repositories.QuizRepository;
using Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.QuizRepository
{
    public class QuizRepository : Repository<Quiz>, IQuizRepository
    {
        private readonly IDbConnection _connection;
        public QuizRepository(IDbConnection connection) : base(connection, nameof(Quiz))
        {
            _connection = connection;
        }

        public IEnumerable<Quiz> GetAll()
        {
            return base.GetAll();
        }

        public Quiz GetById(int id)
        {
            return base.GetById(id);
        }
    }
}
