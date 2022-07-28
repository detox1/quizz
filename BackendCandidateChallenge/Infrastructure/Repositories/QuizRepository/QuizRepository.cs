using Application.Interfaces.Repositories.QuizRepository;
using Core.Domain.Entity;
using Dapper;
using Domain.Dto;
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

        public IEnumerable<QuizDto> GetQuizDetails(int quizId)
        {
            var query = @"SELECT q.Id as QuizId, q.Title as QuizTitle, --quiz data
                                 qq.Id as QuestionId, qq.Text as QuestionText, qq.CorrectAnswerId as CorrectAnswerId, --question data
                                 a.Id as AnswerId, a.Text as AnswerText --answer data
                        FROM Quiz as q 
                        LEFT JOIN Question as qq on q.Id = qq.QuizId
                        LEFT JOIN Answer as a on qq.Id = a.QuestionId
                        WHERE q.Id = @QuizId";

            IEnumerable<QuizDto> dto = _connection.Query<QuizDto>(query, new { QuizId = quizId });

            
            return dto;
        }
    }
}
