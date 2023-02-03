// See https://aka.ms/new-console-template for more information

var res = Solution.FindNetworkEndPoint(1, new int[] { 1, 7, 3, 4, 6, 2, 9 }, new int[] { 3, 3, 4, 6, 9, 6, 5 });

Console.WriteLine("Hello, World!");

class Solution
{

    public static int FindNetworkEndPoint(int startNodeId, int[] fromIds, int[] toIds)
    {
        int currNode = startNodeId;
        List<int> routesVec = new List<int>();
        routesVec.Add(currNode);
        int nexNode;
        bool isAtTheEnd = false;

        while(!isAtTheEnd)
        {
            for(int i = 0; i < fromIds.Length; i++)
            {
                if (fromIds[i] == currNode)
                {
                    nexNode = toIds[i];

                    for(int it = 0; it < routesVec.Count; it++)
                    {
                        if(it == nexNode)
                        {
                            return currNode;
                        }
                    }

                    currNode = nexNode;

                    routesVec.Add(currNode);

                    break;
                }
                else if ((fromIds[i] != currNode) && (i == (fromIds.Length-1))) 
                {
                    isAtTheEnd= true;
                }
            }
        }
        return currNode;
    }
}