// See https://aka.ms/new-console-template for more information

using MarsRoverCore.CommandCenter;
using MarsRoverCore.Mars;

namespace MarsRoverKata
{

    public class Program
    {
        public static void Main()
        {
            var plateau = new Plateau();

            var commandCenter = new CommandCenter();

            var createPlateauCommand = new CreatePlateauCommand(plateau, "5 5");
            commandCenter.SendCommand(createPlateauCommand);

                       
        }
    }
}
