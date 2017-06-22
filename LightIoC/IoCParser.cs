using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace LightIoC
{
    public class IoCParser
    {
        /// <summary>
        /// 类型名称,是指接口类
        /// </summary>
        private string _typename;
        public string Typename
        {
            get { return _typename; }
            set { _typename = value; }
        }

        /// <summary>
        /// 实例化的类型所在的命名空间
        /// </summary>
        private string _tNameSpace;
        public string TNameSpace
        {
            get { return _tNameSpace; }
            set { _tNameSpace = value; }
        }

        /// <summary>
        /// 实例化的类型的名称
        /// </summary>
        private string _tClassName;
        public string TClassName
        {
            get { return _tClassName; }
            set { _tClassName = value; }
        }

        /// <summary>
        /// 实例所在程序集名称
        /// </summary>
        private string _tassemblyName;
        public string TassemblyName
        {
            get { return _tassemblyName; }
            set { _tassemblyName = value; }
        }
        /// <summary>
        /// 构造函数，根据类型名称构造
        /// </summary>
        /// <param name="typename"></param>
        public IoCParser(string typename)
        {
            this._typename = typename;
        }
        /// <summary>
        /// 从xml中加载所有参数
        /// </summary>
        /// <returns></returns>
        public bool deserialize()
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(Properties.Settings.Default.IoCFile);
            }
            catch
            {
                return false;
            }

            XmlNode root = doc.SelectSingleNode("objects");
            XmlNodeList xns = root.SelectNodes("instance");
            if (xns!=null && xns.Count >= 1)
            {
                XmlNode xn = xns[0];
                XmlElement xe = (XmlElement)xn;
                this._tNameSpace = xe.GetAttribute("tnamespace").ToString();
                this._tClassName = xe.GetAttribute("tclassname").ToString();
                this._tassemblyName = xe.GetAttribute("tassemblyname").ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
