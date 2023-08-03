using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace patient
{
    class program
    {
        static void Main(string[] args)
        {
            patient p = new patient();
            /*p is the object*/ p.Examine("lalah");

            child c = new child();
            c.Innoculated();



        }
        public class patient{

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int weight { get; set; }
        public long SSN { get; set; }


        public void Examine(string pname)
        {
            Console.WriteLine("Examination of " + pname + " completed");
        }
        public void Billing(long ssn)
        {
            Console.WriteLine("Billing completed...");
        }
    }
        public class child:patient
        {
            public void Innoculated()
            {
                Console.WriteLine("Child has been innoculated");
            }
        }
    }
}