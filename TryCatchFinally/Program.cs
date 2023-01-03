using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

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
