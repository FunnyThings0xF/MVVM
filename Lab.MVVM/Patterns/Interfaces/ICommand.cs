using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lab.MVVM.Patterns.Enums;

namespace Lab.MVVM.Patterns.Interfaces
{
    public interface IOperation
    {
        TypeOperation Type { get; }
        object Sender { get; set; }
    }
    public interface ICommand : IOperation
    {
        void Execute();
    }
    public interface ICommandHandler : IReceiver
    {
        TypeOperation OperationManaged { get; }
        void Handle();
        void NextHandle(object sender); 
    }
}
