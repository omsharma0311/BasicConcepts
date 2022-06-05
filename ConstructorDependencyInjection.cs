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
    public class ConstructorDependencyInjection
    {
        private Imobile mobile;
        public ConstructorDependencyInjection(Imobile phone)
        {
            this.mobile = phone;
        }
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
            ConstructorDependencyInjection cdiObj1 = new ConstructorDependencyInjection(new JIOCall());
            cdiObj1.makeCall();

            ConstructorDependencyInjection cdiObj2 = new ConstructorDependencyInjection(new BSNLCall());
            cdiObj2.makeCall();
        }
    }
}*/