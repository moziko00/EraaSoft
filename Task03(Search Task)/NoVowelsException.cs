using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Task
{
    public class NoVowelsException : Exception
    {
        public NoVowelsException(string message) : base(message)
        {
        }
    }
}
