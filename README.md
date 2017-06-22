# LightIoC
This is an extreme light library for the inverse of control.

# Usage Guide
## 1. import this lib
Copy "LightIoC.dll" and "LightIoC.dll.config" to the folder of exe。 Set the value of IoCFile in "LightIoC.dll.config" to figure out the file of IoC settings.
## 2. configure LightIoC
Modify the file of IoC settings. An example can be seen in ioc/example.xml
   "typename" is the Interface or base class. "tnamespace" figures out the namespace of instance. "tclassname" is the name of class of instance. "tassemblyname" is the assembly name.
## 3. configure app.conf
Add the folder of libs in app.conf as can seen following. This dynamic assembly should be in the main folder.
  &lt;runtime &gt; \
    &npsp;&lt;assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1"&gt; \
      &npsp;&npsp;&lt;probing privatePath="plugins;Template"/&gt; \
    &npsp;&lt;/assemblyBinding&gt; \
  &lt;/runtime&gt; 


# Example
  while (true) \
  { \
      &npsp;IShut animal = (IShut)Instance.createInstance("IShut"); \
      &npsp;animal.shut(); \
      &npsp;Thread.Sleep(1000); \
  } 
