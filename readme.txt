使用控制反转的方法如下：
1. 将 LightIoC.dll 和LightIoC.dll.config拷贝到项目可执行文件目录下，配置LightIoC.dll.config中的IoCFile中的值，该值指定需要读取的控制反转配置。
2. 编写控制反转文件，示例见ioc/example.xml
   typename是指抽象类或者接口，tnamespace为需要实例化的类所在的命名空间，tclassname需要实例化的类的名称，tassemblyname需要实例化的类所在的程序集，不需要后缀，不需要路径。
3. 在主程序的app.conf中加入待加载动态库的路径，如下，动态库需要在主程序目录或子目录中。
  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <probing privatePath="plugins;Template"/>
    </assemblyBinding>
  </runtime>
4. 使用例子：
    while (true)
    {
        IShut animal = (IShut)Instance.createInstance("IShut");
        animal.shut();
        Thread.Sleep(1000);
    }

特性：
	1. 该框架支持程序运行时修改动态库，修改配置
	2. 该框架量级非常轻，只有大约两百行，仅适用于小型项目。