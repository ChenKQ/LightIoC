ʹ�ÿ��Ʒ�ת�ķ������£�
1. �� LightIoC.dll ��LightIoC.dll.config��������Ŀ��ִ���ļ�Ŀ¼�£�����LightIoC.dll.config�е�IoCFile�е�ֵ����ֵָ����Ҫ��ȡ�Ŀ��Ʒ�ת���á�
2. ��д���Ʒ�ת�ļ���ʾ����ioc/example.xml
   typename��ָ��������߽ӿڣ�tnamespaceΪ��Ҫʵ�����������ڵ������ռ䣬tclassname��Ҫʵ������������ƣ�tassemblyname��Ҫʵ�����������ڵĳ��򼯣�����Ҫ��׺������Ҫ·����
3. ���������app.conf�м�������ض�̬���·�������£���̬����Ҫ��������Ŀ¼����Ŀ¼�С�
  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <probing privatePath="plugins;Template"/>
    </assemblyBinding>
  </runtime>
4. ʹ�����ӣ�
    while (true)
    {
        IShut animal = (IShut)Instance.createInstance("IShut");
        animal.shut();
        Thread.Sleep(1000);
    }

���ԣ�
	1. �ÿ��֧�ֳ�������ʱ�޸Ķ�̬�⣬�޸�����
	2. �ÿ�������ǳ��ᣬֻ�д�Լ�����У���������С����Ŀ��