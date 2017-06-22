using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateCore
{
    public class Dog:IShut
    {
        private string content = string.Empty;
        public string Content
        {
          get { return content; }
          set { content = value; }
        }

        private int idx;
        public int Idx
        {
            get { return idx; }
            set { idx = value; }
        }

        public Dog()
        {
            this.content = "Wang Wang!";
            this.idx = 10;
        }

        public Dog(string content)
        {
            this.content = content;
            this.idx = 10;
        }

        public Dog(string content, int idx)
        {
            this.content = content;
            this.idx = idx;
        }

        public virtual string shut()
        {
            System.Console.WriteLine(this.content + "  "+this.idx);
            return this.content + "  "+this.idx;
        }

        public virtual string shut(string content)
        {
            System.Console.WriteLine(content);
            return content;
        }

        public virtual string shut(string content, int idx)
        {
            System.Console.WriteLine(content+"  "+ idx);
            return content + "  " + idx;
        }
    }
}
