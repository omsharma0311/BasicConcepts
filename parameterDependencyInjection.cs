using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace oopsExample
{
    public interface Imobile
    {
        void call();
    }
    public class BSNLCall : Imobile
    {
        public void call()
        {
            Console.WriteLine("Call using BSNL Number");
        }
    }
    public class JIOCall : Imobile
    {
        public void call()
        {
            Console.WriteLine("Call using Jio Number");
        }
    }
    class parameterDependencyInjection
    {
        public Imobile mobile { get; set; }
        public void makeCall()
        {
            Console.WriteLine("Calling ");
            mobile.call();
        }
    }
    public class program
    {
        public static void Main()
        {
            parameterDependencyInjection pdiObj1 = new parameterDependencyInjection();
            pdiObj1.mobile = new JIOCall();
            pdiObj1.makeCall();

            parameterDependencyInjection pdiObj2 = new parameterDependencyInjection();
            pdiObj2.mobile = new BSNLCall();
            pdiObj2.makeCall();
            
        }
    }   
}
*/