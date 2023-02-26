using System;
using System.Collections.Generic;

namespace FindNetWorkEndPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static int browseArray(List<int> visitedNode, int startNodeId, int[] fromIds, int[] toIds)
        {
            int startNodePosition = 0;
            while (startNodePosition < fromIds.Length && fromIds[startNodePosition] != startNodeId)
            {
                startNodePosition++;
            }

            if (startNodePosition == fromIds.Length)
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
    }
}
