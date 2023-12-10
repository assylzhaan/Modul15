using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modul15HW
{

    public class MyClass
    {
        public int MyProperty1 { get; set; }
        public string MyProperty2 { get; set; }
    }

    class Program
    {
        static void Main()
        {
            ListConsoleMethods();
            ReflectObjectProperties();
            InvokeSubstringMethod();
            ListListConstructors();
        }

        static void ListConsoleMethods()
        {
            Console.WriteLine("Methods in Console class:");
            Type consoleType = typeof(Console);
            MethodInfo[] methods = consoleType.GetMethods();

            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }

            Console.WriteLine("\n-----------------------------------\n");
        }

        static void ReflectObjectProperties()
        {
            Console.WriteLine("Properties and values of MyClass object:");
            MyClass myObj = new MyClass { MyProperty1 = 35, MyProperty2 = "Hi!" };

            Type myType = myObj.GetType();
            PropertyInfo[] properties = myType.GetProperties();

            foreach (var property in properties)
            {
                Console.WriteLine($"{property.Name} = {property.GetValue(myObj)}");
            }

            Console.WriteLine("\n-----------------------------------\n");
        }

        static void InvokeSubstringMethod()
        {
            Console.WriteLine("Invoke Substring method on a string:");
            string str = "Hi,My name is Assyl!";
            Type stringType = str.GetType();
            MethodInfo substringMethod = stringType.GetMethod("Substring", new[] { typeof(int), typeof(int) });

            object result = substringMethod.Invoke(str, new object[] { 7, 5 });
            Console.WriteLine(result);

            Console.WriteLine("\n-----------------------------------\n");
        }

        static void ListListConstructors()
        {
            Console.WriteLine("Constructors of List<int>:");
            Type listType = typeof(List<int>);
            ConstructorInfo[] constructors = listType.GetConstructors();

            foreach (var constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }

            Console.WriteLine("\n-----------------------------------\n");
        }
    }
}
