using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MyStack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var numbers = new int[8];

            //var res = numbers.Length;

            //numbers[9] = 3;

            //return;

            MyStack stack = new MyStack(10000);

            Console.WriteLine("Memory Use {approx.}: " +(GC.GetTotalMemory(true)/1024 ) + " KBytes");

            for (int i = 0; i < 10000; i++) // fill the stack
                stack.Push("a large, large, large, large, string " + i);

            for (int i = 0; i < 10000; i++) // fill the stack
                stack.Pop();

            Console.WriteLine("Memory Use {approx.}: " + (GC.GetTotalMemory(true) / 1024) + " KBytes");
        }
    }

    // Cette pile a une fuite de mémoire. Trouvez la cause et appliquez un correctif
    class Myst
    {
        private Object[] element;
        private int size = 0;

        public Myst(int initialCapacity)
        {
            element= new Object[initialCapacity];
        }

        public void Push(object o)
        {
            EnsureCapacity();
            element[size++] = o;
        }

        public object Pop()
        {
            if(size == 0) 
            {
                throw new InvalidOperationException();
            }
            return element[--size];
        }

        private void EnsureCapacity()
        {
            if(element.Length == size)
            {
                object[] old = element;
                element = new Object[2*size+1];
                old.CopyTo(element, 0);
            }
        }
    }


    /*
    La fuite de mémoire dans cette classe est causée par la méthode EnsureCapacity().
    Cette méthode double la taille de la pile chaque fois que la taille maximale est atteinte,
    mais elle ne supprime pas les éléments qui ont été retirés de la pile. 
    Cela signifie que les anciens objets de la pile continuent d'occuper de l'espace mémoire même s'ils ne sont plus utilisés.

    La solution consiste à supprimer les objets qui ont été retirés de la pile lors de l'expansion 
    de la pile dans EnsureCapacity(). Vous pouvez le faire en copiant seulement les éléments valides 
    de l'ancien tableau dans le nouveau tableau. Voici la version corrigée de la classe MyStack : 
     
    */
    class MyStack
    {
        private Object[] element;
        private int size = 0;

        public MyStack(int initialCapacity)
        {
            element = new Object[initialCapacity];
        }

        public void Push(object o)
        {
            //EnsureCapacity();
            element[size++] = o;
        }

        public object Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            object result = element[--size];
            element[size] = null; // Supprimer la référence à l'objet retiré
            return result;
        }

        private void EnsureCapacity()
        {
            if (element.Length == size)
            {
                object[] old = element;
                element = new Object[2 * size + 1];
                Array.Copy(old, element, size); // Copier seulement les éléments valides
               
            }
        }
    }

}
