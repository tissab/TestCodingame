using System;
using System.Collections.Generic;

namespace FindNetWorkEndPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = FindNetworkEndpoint(1, new int[] { 1, 7, 3, 4, 2, 6, 9 }, new int[] { 3, 3, 4, 6, 6, 9, 5 });

            //var numbers = new int[] { 1, 2, 3, 4, 5, 6 };  // => {456}

            //var treeNumbers_0 = numbers[^3..^0]; // => {456}
            //var treeNumbers_1 = numbers[^0..^3];
            //var treeNumbers_2 = numbers[3..0];
            //var treeNumbers_3 = numbers[-3..-0];
            //var treeNumbers_4 = numbers[-4..-1];
            //var treeNumbers_5 = numbers[^4..^1];
            

            //ref var element = (variable1 != null ? ref variable2[x] : ref variable3[x])
            //ref var variable1 = ref (variable1 != null ? variable2[x] : variable3[x])
            //var element =   ref (variable1 != null ? ref variable2[x] : ref variable3[x]) - Faux
            //ref var element = (variable1 != null ? variable2[x] : variable3[x]) - Faux
            //ref var element = ref (variable1 != null ? ref variable2[x] : ref variable3[x]) - Faux


            Console.WriteLine("Hello World!");
        }

        private static int browseArray(List<int> visitedNode, int startNodeId, int[] fromIds, int[] toIds)
        {
            int startNodePosition = Array.IndexOf(fromIds,startNodeId);

            if (startNodePosition == -1)
            {
                return startNodeId;
            }

            int nextNodeId = toIds[startNodePosition];

            if (visitedNode.Contains(nextNodeId))
            {
                return startNodeId;
            }

            visitedNode.Add(startNodeId);

            return browseArray(visitedNode, nextNodeId, fromIds, toIds);
        }

        private static int FindNetworkEndpoint(int startNodeId, int[] fromIds, int[] toIds)
        {
            List<int> visitedNode = new List<int>();

            return browseArray(visitedNode, startNodeId, fromIds, toIds);
        }

        private int Multiply(object obj)
        {
            int result = 0;
            //if (obj as int multiplyBy)
            //    result *= multiplyBy;

            //if (int multiply from obj)
            //    result *= multiply;
            
            if (obj is int multiply)
                result *= multiply;
            
            //if (int multiply = (int)obj)
            //    result *= multiply;
            

            return result;
        }

    }
}
