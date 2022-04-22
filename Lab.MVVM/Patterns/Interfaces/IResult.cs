using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.MVVM.Patterns.Interfaces
{
    public interface IOperationResult
    {
        bool IsSuccess { get; }
        string ErrorText { get; }
    }
    public interface IRequestResult<T> : IOperationResult
    {
        public T Result { get; }    
    }
}
