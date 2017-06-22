using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateCore
{
    public interface IShut
    {
        string shut();
        string shut(string content);
        string shut(string conent, int idx);
    }
}
