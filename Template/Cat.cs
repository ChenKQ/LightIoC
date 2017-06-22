using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemplateCore;

namespace Template
{
    public class Cat:IShut
    {
        public virtual string shut()
        {
            System.Console.WriteLine("Miao!");
            return "Miao!";
        }

        public virtual string shut(string content)
        {
            System.Console.WriteLine(content);
            return content;
        }

        public virtual string shut(string content, int idx)
        {
            System.Console.WriteLine(content + "  " + idx);
            return content + "  " + idx;
        }
    }
}
