using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsExample
{
    class SingletonPattern
    {
        public static void Main()
        {
            Singleton object1 = Singleton.GetInstance;
            object1.PrintMessage("This is Object 1");

            Singleton object2 = Singleton.GetInstance;
            object2.PrintMessage("This is Object 2");

        }
    }
   // public class XYZ : Singleton { } // we get erroe here because of private ctor
    public sealed class Singleton// sealed class Sealed ensures the class being inherited and object instantiation is restricted in the derived class
    {
        private static int counter = 0;

        private static Singleton instance = null;// Private property initilized with null ensures that only one instance of the object is created based on the null condition - it helps in preventing external obejction creation

        public static Singleton GetInstance // public property is used to return only one instance of the class leveraging on the private property
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        private Singleton()///Private Constructor Declaration , it ensures that object is not instantiated other than with in the class itself
        {
            counter++;
            Console.WriteLine("Counter Value : "+counter);
        }
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
