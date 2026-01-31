using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTerminal
{
    public class Command
    {
        public string CommandText { get; set; }
        public string[] Args { get; set; }

        public Command(string commandText, string[] args)
        {
            this.CommandText = commandText;
            this.Args = args;
        }

        public void ConvertToCommand(string input)
        {
            var parts = input.Split(' ');
            this.CommandText = parts[0];
            this.Args = [.. parts.Skip(1)];
        }
    }
}
