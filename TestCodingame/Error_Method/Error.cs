using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.Error_Method
{
    class Error
    {
        public static void ErrorMethod()
        {
            try
            {
                throw new Exception("Error occurred");
            }
            catch (Exception ex) // ===> *
            {
                ExceptionDispatchInfo.Capture(ex).Throw();
            }
            //catch (Exception ex) // ===> *
            //{
            //    throw ex;
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("RETHROW", ex);
            //}
        }
    }
}
