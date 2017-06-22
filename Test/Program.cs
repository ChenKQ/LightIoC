using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LightIoC;
using TemplateCore;
using System.Threading;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                GC.Collect();
                Thread.Sleep(1000);
                object[] tparams = new object[2];
                tparams[0] = "Wang Wang!!!";
                tparams[1] = 200;
                IShut animal = (IShut)Instance.createInstance("IShut",tparams);
                if (animal == null)
                    continue;
                animal.shut();

            }

        }
    }
}
