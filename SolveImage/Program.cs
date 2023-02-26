// See https://aka.ms/new-console-template for more information


using System;

Console.WriteLine("Hello, World!");

class Image
{
    public static int[] Solve(int imageWidth, int imageHeight, string[] image, int patternWidth, int patternHeight, string[] pattern)
    {
        for (int y = 0; y <= imageHeight - patternHeight; y++)
        {
            for (int x = 0; x <= imageWidth - patternWidth; x++)
            {
                // Vérifier si le motif correspond à l'image à cette position
                bool match = true;
                for (int i = 0; i < patternHeight && match; i++)
                {
                    for (int j = 0; j < patternWidth && match; j++)
                    {
                        if (pattern[i][j] != image[y + i][x + j])
                        {
                            match = false;
                        }
                    }
                }
                if (match)
                {
                    // Si le motif correspond, retourner les coordonnées de son coin supérieur gauche
                    return new int[] { x, y };
                }
            }
        }
        // Si le motif n'est pas présent dans l'image, retourner [-1, -1]
        return new int[] { -1, -1 };
    }
}