using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.MVVM.Patterns.Interfaces
{
    public interface IReceiver
    {
        public void Receive(ICommand command);
    }
    public interface IInvoker
    {
        public void SetCommand(ICommand command);   
        public void ForwardCommand();
        
        ///<summary> RESTORE IN FUTURE (ForwardCommand) </summary>
        //public void ForwardCommand(ICommand command);
    }
}
