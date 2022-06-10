using MarsRoverCore.Mars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCore.CommandCenter
{
    public class CreatePlateauCommand : ICommand
    {
        private IPlateau Plateau { get; set; }

        private string Command { get; set; }

        public CreatePlateauCommand(IPlateau plateau, string command)
        {
            Plateau = plateau;

            Command = command;
        }

        public void ExecuteCommand()
        {
            ParseCommand(Command, out var width, out var height);

            Plateau.Define(width, height);
        }

        private void ParseCommand(string command, out int width, out int height)
        {
            var splitCommand = command.Split(' ');

            width = int.Parse(splitCommand[0]);

            height = int.Parse(splitCommand[1]);
        }
    }
}
