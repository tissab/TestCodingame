// See https://aka.ms/new-console-template for more information


using System;

Console.WriteLine("Hello, World!");

class Image
{
    public static int[] Solve(int imageWidth, int imageHeight, string[] image, 
        int patternWidth, int patternHeight, string[] pattern)
    {
       int[] result = new int[2] { -1, -1 };

        if ((patternWidth >= 1) && (patternWidth <= 400) &&
            (patternHeight >= 1) && (patternHeight <= 400) &&
            (imageWidth >= 1) && (imageWidth <= 400) &&
            (imageHeight >= 1) && (imageHeight <= 400) &&
            (patternWidth <= imageWidth) && (patternHeight <= imageHeight))
        {

            int img_x, img_y, pattern_x, pattern_y;
            bool pattern_not_found, pattern_is_matching;

            pattern_not_found = true;

            for (img_x = 0; (pattern_not_found && (img_x <= (imageWidth - patternWidth))); ++img_x)
            { 
                for (img_y = 0; (pattern_not_found && (img_y <= (imageHeight - patternHeight))); ++img_y)
                { 
                    pattern_is_matching = true;

                    for (pattern_x = 0; (pattern_is_matching && (pattern_x < patternWidth)); ++pattern_x)
                    {
                        for (pattern_y = 0; (pattern_is_matching && (pattern_y < patternHeight)); ++pattern_y)
                        {
                            if (image[(img_x + pattern_x)][(img_y + pattern_y)] != pattern[pattern_x][pattern_y])
                            {
                                pattern_is_matching = false;
                            }
                        }
                    }

                    if (pattern_is_matching)
                    {
                        pattern_not_found = false;
                        result = new int[] { img_x, img_y};
                    }
                }
            }
        }
        else
        {
            //  XXX Error : preconditions
            //  result = ???
        }

        return result;
    }
}