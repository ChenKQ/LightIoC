using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace LightIoC
{
    public static class ReflectHelper
    {
        /// <summary>
        /// 用反射生成本项目中的类的实例
        /// </summary>
        /// <typeparam name="T">需要反射生成的类</typeparam>
        /// <param name="tnamespace">命名空间</param>
        /// <param name="tclassname">类型名称</param>
        /// <returns></returns>
        public static T CreateInstance<T>(string tnamespace, string tclassname,object[] args=null)
        {
            Assembly assem = Assembly.GetExecutingAssembly();
            try
            {
                object obj = assem.CreateInstance(tnamespace+"."+tclassname,false,System.Reflection.BindingFlags.Default,null,args,null,null);
                return (T)obj;
            }
            catch
            {
                return default(T);
            }
        }

        /// <summary>
        /// 用反射生成动态库中的类的实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tnamespace"></param>
        /// <param name="tclassname"></param>
        /// <param name="tassemblyname"></param>
        /// <returns></returns>
        public static T CreateInstance<T>(string tnamespace, string tclassname, string tassemblyname,object[] args=null)
        {
            if (String.IsNullOrEmpty(tassemblyname))
            {

                return ReflectHelper.CreateInstance<T>(tnamespace, tclassname,args);
            }
            Assembly assem = null;
            try
            {
                assem = Assembly.Load(tassemblyname);
            }
            catch
            {
                return default(T);
            }
            
            try
            {
                object obj = assem.CreateInstance(tnamespace + "." + tclassname, false, System.Reflection.BindingFlags.Default, null, args, null, null);
                return (T)obj;
            }
            catch
            {
                return default(T);
            }
        }

        /// <summary>
        /// 用反射生成本项目中的类的实例
        /// </summary>
        /// <typeparam name="T">需要反射生成的类</typeparam>
        /// <param name="tnamespace">命名空间</param>
        /// <param name="tclassname">类型名称</param>
        /// <returns></returns>
        public static object CreateInstance(string tnamespace, string tclassname,object[] args=null)
        {
            Assembly assem = Assembly.GetExecutingAssembly();
            try
            {
                object obj = assem.CreateInstance(tnamespace + "." + tclassname, false, System.Reflection.BindingFlags.Default, null, args, null, null);
                return obj;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 用反射生成动态库中的类的实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tnamespace"></param>
        /// <param name="tclassname"></param>
        /// <param name="tassemblyname"></param>
        /// <returns></returns>
        public static object CreateInstance(string tnamespace, string tclassname, string tassemblyname,object[] args=null)
        {
            if (String.IsNullOrEmpty(tassemblyname))
            {

                return ReflectHelper.CreateInstance(tnamespace, tclassname,args);
            }
            Assembly assem = null;
            try
            {
                assem = Assembly.Load(tassemblyname);
            }
            catch
            {
                return null;
            }

            try
            {
                object obj = assem.CreateInstance(tnamespace + "." + tclassname,false,System.Reflection.BindingFlags.Default,null,args,null,null);
                return obj;
            }
            catch
            {
                return null;
            }
        }
    }
}
