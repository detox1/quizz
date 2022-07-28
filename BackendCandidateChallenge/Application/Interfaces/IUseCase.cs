using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUseCase<T_in, T_out> : IDisposable where T_in : class
    {
        Task<T_out> Execute(T_in input);
    }
}
