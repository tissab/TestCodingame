using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ComputeFinalPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = ComputeFinalPosition(5, 4, new int[] { 0, 0 }, new int[] { 1, 1 }, new int[] { 2, 3 }, "DRR");
            Console.WriteLine("Hello World!");
        }

        static int[] ComputeFinalPosition(int width, int height, int[] position, int[] portalA, int[] portalB, string moves)
        {
            if (width < 0 || width > 20) throw new InvalidOperationException("");
            if (height < 0 || height > 20) throw new InvalidOperationException("");
            if (moves == null || moves.Length == 0) throw new InvalidOperationException("");

            char[] strMoves = moves.ToCharArray();

            var dicMoveY = new Dictionary<char, int>()
            {
                {'U',-1},
                {'D', 1},
            }; 
            
            var dicMoveX = new Dictionary<char, int>()
            {
                {'R', 1},
                {'L',-1}
            };

            bool positionATrouve = false;

            char[] rest = moves.ToCharArray();

            int x = position[0], y = position[1];

            for(int i = 0; i <= strMoves.Length; i++)
            {
                if (dicMoveY.TryGetValue(strMoves[i], out int yC))
                {
                    y = y + yC;
                    rest = rest.Where((_,index) => index != i).ToArray();
                }

                if (dicMoveX.TryGetValue(strMoves[i], out int xC))
                {
                    x = x + xC;
                    rest = rest.Where((_,index) => index != i).ToArray();
                }

                if (portalA.SequenceEqual(new int[] { x, y }))
                {
                    positionATrouve = true;
                    
                    break;
                }
            }

            bool extremiteTrouvee = false;
            if (positionATrouve )
            {
                x = portalB[0]; y = portalB[1];

                foreach (var c in rest)
                {
                    if (dicMoveY.TryGetValue(c, out int yC))
                    {
                        y = y + yC;
                    }

                    if (dicMoveX.TryGetValue(c, out int xC))
                    {
                        x = x + xC;
                    }

                    if(y > height || x > width)
                    {
                        extremiteTrouvee = true;
                        break;
                    }
                }
            }

            if(extremiteTrouvee)
            {
                return position;
            }

            return new[] {x,y} ;
        }
    }
}
