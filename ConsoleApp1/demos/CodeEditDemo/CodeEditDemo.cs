using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;

namespace ConsoleApp1.demos.CodeEditDemo
{
    public class CodeEditDemo
    {
        public static void UseStrToCode(string str)
        {
            CompilerParameters compilerParameters = new CompilerParameters();
            compilerParameters.GenerateExecutable = false;
            compilerParameters.GenerateInMemory = true;
            compilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            StringBuilder source = new StringBuilder();
            source.AppendLine(" using System.Windows.Forms; ");
            source.AppendLine(" public class Temp ");
            source.AppendLine(" { ");
            source.AppendLine(" public int Test() ");
            source.AppendLine(" { ");
            source.AppendLine(" int sum = 0; ");
            source.AppendLine(" for( int i = 0; i< 1000; i++) ");
            source.AppendLine(" { ");
            source.AppendLine(" sum += i; ");
            source.AppendLine(" } ");
            source.AppendLine(" return sum; ");
            source.AppendLine(" } ");
            source.AppendLine(" } ");
            CompilerResults compilerResults = CodeDomProvider.CreateProvider("CSharp").CompileAssemblyFromSource(compilerParameters, source.ToString());
            Assembly assembly = compilerResults.CompiledAssembly;
            object temp = assembly.CreateInstance("Temp");
            MethodInfo test = temp.GetType().GetMethod("Test");
            test.Invoke(temp, null);
        }

    }
}
