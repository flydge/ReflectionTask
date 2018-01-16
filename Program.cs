using System;
using System.Collections.Generic;
using System.Reflection;


namespace ReflectionTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Type myType = typeof(string);
            TypeInfo typeInfo = new TypeInfo();
            Console.WriteLine(typeInfo.GetInterfaceInfo(myType));
            Console.WriteLine(typeInfo.GetMethodsInfo(myType));
            Console.WriteLine(typeInfo.GetConstructorsInfo(myType));
            Console.WriteLine(typeInfo.GetFieldsInfo(myType));
            Console.WriteLine(typeInfo.GetPropertiesInfo(myType));
            
        }
    }
}