using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.Exo19
{
    class Exo_19
    {
        public void Run(Service s, Connection c)
        {
            s.SetConnection(c);

            try
            {
                s.Execute();
                c.Commit();

            }
            catch (Exception)
            {
                c.RollBack();
                throw;
            }
            finally
            {
                c.Close();
            }
        }

    }

    public interface Service
    {
        void Execute();
        void SetConnection(Connection c);
    }

    public interface Connection
    {
        void Commit();
        void RollBack();
        void Close();
    }
}
