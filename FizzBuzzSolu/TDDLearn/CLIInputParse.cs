using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDLearn
{
    public class CLIInputParse
    {
        public static string[] Parse(string inputText)
        {
            inputText = " " + inputText;
            return inputText.Split(" -").Where(o=>!string.IsNullOrEmpty(o)).ToArray();
        }
    }
}
