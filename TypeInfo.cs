using System;
using System.Reflection;

namespace ReflectionTask
{
    public class TypeInfo
    {
        private string infoString;
        
        public string GetInterfaceInfo(Type myType)
        {
            infoString = "\nInterfaces:\n";
            foreach (var interfaceInfo in myType.GetInterfaces())
            {
                infoString += interfaceInfo.Name + "; ";
            }
            return infoString;
        }

        public string GetMethodsInfo(Type myType)
        {
            infoString = "\nPublic instance declared only methods:\n";
            foreach (var methodInfo in myType.GetMethods(BindingFlags.Public|BindingFlags.Instance|BindingFlags.DeclaredOnly))
            {
                String parameterString = "";
                ParameterInfo[] parameterInfos = methodInfo.GetParameters();

                for (int i = 0; i < parameterInfos.Length; i++)
                {
                    parameterString += parameterInfos[i].ParameterType.Name + " " + parameterInfos[i].Name;
                    if (parameterInfos.Length > i+1)
                    {
                        parameterString += " , ";
                    }
                }
                
                infoString += methodInfo.ReturnType.Name + " " +methodInfo.Name + "("+ parameterString + ");\n";
                
            }
            return infoString;
        }


        public string GetConstructorsInfo(Type myType)
        {
            infoString = "\nAll constructors:\n";
            foreach (var constructorInfo in myType.GetConstructors())
            {
                string constrInfoString = "";

                ParameterInfo[] constructorInfos = constructorInfo.GetParameters();

                for (int i = 0; i < constructorInfos.Length; i++)
                {
                    constrInfoString += constructorInfos[i].ParameterType.Name + " " + constructorInfos[i].Name;
                    if (constructorInfos.Length > i+1)
                    {
                        constrInfoString += ";";
                    }
                   
                }

                infoString += myType.Name + "(" + constrInfoString + ");\n";

            }
            return infoString;
        }


        public string GetFieldsInfo(Type myType)
        {
            infoString = "\nAll fields:\n";
            foreach (var fieldInfo in myType.GetFields())
            {
                infoString += fieldInfo.FieldType.Name + " " + fieldInfo.Name + ";";
            }
            return infoString;
        }

        public string GetPropertiesInfo(Type myType)
        {
            infoString = "\nInstance non public properties:\n";
            foreach (var propInfo in myType.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic))
            {
                infoString += propInfo.PropertyType.Name + " " + propInfo.Name + ";\n";
            }
            return infoString;
        }
        
    }
}