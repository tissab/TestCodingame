// See https://aka.ms/new-console-template for more information

var res = code.MagicStone(new string[] { "1", "2", "1" });

Console.WriteLine($"Hello, World! {res}");

class code
{
    /// <summary>
    /// Le but de cet exercice est de renvoyer Le nombre Magic Specifiations :
    /// </summary>
    /// <param name="stones[]"></param>
    /// <returns>string</returns>
    public static string MagicStone(string[] stones)
    {
        var cacheDict = new Dictionary<int, int>();

        for (int i = 0; i < stones.Length; i++)
        {
            int level = int.Parse(stones[i]);

            int count = 0;
            bool hasCount = cacheDict.TryGetValue(level, out count);
            if (!hasCount)
            {
                cacheDict.Add(level, count);
            }
            cacheDict[level] = cacheDict[level] + 1;
        }

        var sortedPairs = cacheDict.OrderBy(pair => pair.Key).ToList();

        var currentIndex = 0;
        var keepGoing = true;

        while (keepGoing)
        {
            var thePair = sortedPairs[currentIndex];
            var currentTier = thePair.Key;
            var nextTier = thePair.Key + 1;
            var combinedCount = thePair.Value / 2;
            var remainingCount = thePair.Value % 2;

            sortedPairs[currentIndex] = new KeyValuePair<int, int>(currentTier, remainingCount);
            var hasNextTier = sortedPairs.Exists(sp => sp.Key == nextTier);
            if (hasNextTier)
            {
                var nextTierIndex = sortedPairs.FindIndex(sp => sp.Key == nextTier);
                sortedPairs[nextTierIndex] = new KeyValuePair<int, int>(nextTier, sortedPairs[nextTierIndex].Value + combinedCount);
            }
            else
            {
                sortedPairs.Add(new KeyValuePair<int, int>(nextTier, combinedCount));
                sortedPairs = sortedPairs.OrderBy(sp => sp.Key).ToList();
            }

            ++currentIndex;
            if (currentIndex >= sortedPairs.Count)
            {
                keepGoing = false;
            }
            else
            {
                keepGoing = (sortedPairs[currentIndex].Value != 0);
            }
        }

        var afterCombinedCount = sortedPairs.Where(sp => sp.Value != 0).ToList();
        return afterCombinedCount.Count.ToString();
    }
}