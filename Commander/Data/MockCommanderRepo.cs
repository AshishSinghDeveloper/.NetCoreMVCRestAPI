using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=1, HowTo="Prepare a cup of Tea", Line="Place Kettle in Stove", Platform="Kettle and Cup"},
                new Command{Id=2, HowTo="Prepare a glass of Juice", Line="Get Carrots", Platform="Juicer and glass"},
                new Command{Id=3, HowTo="Prepare a plate of Pakoda", Line="Cut Onions and chili", Platform="Pan and stove"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil Water", Platform="Kettle & Pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    } 
}