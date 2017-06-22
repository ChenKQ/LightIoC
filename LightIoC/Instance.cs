using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightIoC
{
    public static class Instance
    {
        public static T createInstance<T>(string typename,object[] args=null)
        {
            IoCParser parser = new IoCParser(typename);
            parser.deserialize();
            return ReflectHelper.CreateInstance<T>(parser.TNameSpace, parser.TClassName,parser.TassemblyName,args);
        }

        public static object createInstance(string typename, object[] args = null)
        {
            IoCParser parser = new IoCParser(typename);
            parser.deserialize();
            return ReflectHelper.CreateInstance(parser.TNameSpace, parser.TClassName, parser.TassemblyName,args);
        }
    }
}
