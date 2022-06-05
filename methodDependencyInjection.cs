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
    class methodDependencyInjection
    {
        public Imobile mobile;
        public void makeCall(Imobile sim)
        {
            this.mobile = sim;
            Console.WriteLine("Calling ");
            this.mobile.call();
        }
    }
    public class program
    {
        public static void Main()
        {
            methodDependencyInjection mdiObj = new methodDependencyInjection();
            mdiObj.makeCall(new JIOCall());
            mdiObj.makeCall(new BSNLCall());
        }
    }
}
*/