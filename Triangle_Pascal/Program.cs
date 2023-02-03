// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


class code
{
    /// <summary>
    /// Trainge de pascla, retourne la valeur au croisement de la ligne l et la colonne c
    /// </summary>
    /// <param name="l">Ligne</param>
    /// <param name="c">Colonne</param>
    /// <returns></returns>
    public static Int64 TriangleDePascal(int l, int c)
    {
        Int64[,] res = new Int64[l + 1, l + 1];

        if (l == 0) res[0, 0] = 1;
        if (l == 1) res[1, 0] = 1;
        if (l == 1) res[1, 1] = 1;

        try
        {
            for (int ligne = 1; ligne <= l; ligne++)
            {
                Int64 calindice = 0;

                for (int col = 0; col <= ligne; col++)
                {
                    if (col == 0 || col == ligne)
                    {
                        calindice = 1;
                    }
                    else
                    {
                        calindice = res[ligne - 1, col - 1] + res[ligne - 1, col];
                    }

                    res[ligne, col] = calindice;

                    // Debug.Write($"res[{ligne}, {col}] = {res[ligne, col]}{Environment.NewLine}");
                }
            }
        }
        catch (Exception)
        {
            return 0;
        }

        return res[l, c];
    }
}

}