using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.Exo16
{
    class Exo_16
    {

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
