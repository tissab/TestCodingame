using System;

namespace ExceptionNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /*
         
        Quelle(s) exceptions(s) fait parti de l' API .NET pour le C#

                - IndexOutOfRangeException *
                - NullReferenceException *
                - NullPointerException
         
         */
        public void Test1()
        {
            try
            {

            }
            catch (IndexOutOfRangeException)
            {

                throw;
            }
        }

        public void Test2()
        {
            try
            {

            }
            catch (NullReferenceException)
            {

                throw;
            }
        }

        public void Test3()
        {
            //try
            //{

            //}
            //catch (NullPointerException)
            //{

            //    throw;
            //}
        }

    }
}
