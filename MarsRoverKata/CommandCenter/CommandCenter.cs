using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCore.CommandCenter
{
    public class CommandCenter
    {
        public void SendCommand(ICommand command)
        {
            command.ExecuteCommand();
        }
    }
}
