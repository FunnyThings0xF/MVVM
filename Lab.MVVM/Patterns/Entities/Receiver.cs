using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lab.MVVM.Patterns.Interfaces;

namespace Lab.MVVM.Patterns.Entities
{
    public class Receiver : IReceiver
    {
        private readonly ICommandHandler _handler;
        public Receiver(ICommandHandler commandHandler)
        {
            _handler = commandHandler;  
        }

        //Maybe call it Fowrard??
        public virtual void Receive(ICommand command) => _handler.Receive(command); 
    }
    public class Invoker : IInvoker
    {
        private readonly IReceiver? _receiver;
        private ICommand _command;

        public Invoker(IReceiver receiver)
        {
            _receiver = receiver;
            _command = null;
        }
        public virtual void ForwardCommand() => _receiver?.Receive(_command);
        public virtual void SetCommand(ICommand command) =>  _command = command;
    }
}
