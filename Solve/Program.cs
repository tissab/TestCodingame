// See https://aka.ms/new-console-template for more information



// To debug: Console.Error.WriteLine("Debug messages...");


using System.Text;

Console.WriteLine("Hello, World!");
class Calc
{
    public static int Solve(int weight0, int weight1, int weight2)
    {
        
        int[] poids = { weight0, weight1, weight2 };

        int t = 0;
        int j = 0;

        for(int i = 0; i < poids.Length; i++)
        {
            if(t < poids[i])
            {
                t = poids[i];
                j = i;
            }
        }
        return j;
    }


    //By Hermann KIPRE
    public static string Solve(int width, int height, int length, int mass) {
	if(mass < 10 || mass> 1000)
	{
	throw new Exception ("Invalid mass");
	}

	if(width <10 || width > 1000)
	{
	throw new Exception ("Invalid width");
	}
	if(height <10 || height > 1000)
	{
	throw new Exception ("Invalid height");
	}

	if(length <10 || length > 1000)
	{
	throw new Exception ("Invalid length");
	}

	int encombrant = width * heigth * length;

	string strMessageEncombrant = string.Empty;
	string strMessageLourd = string.Empty;

	if (encombrant >= 1000000 || (width >= 150 || height >= 150 || length >= 150)
	{
		strMessageEncombrant = "Encombrant";
	}
	if (mass >= 20)
	{
		strMessageLourd = "Lourd";
	}

	if(strMessageEncombrant != "Encombrant" && strMessageLourd != "Lourd")
	{
		return "STANDARD"
	}
	if(strMessageEncombrant != "Encombrant" && strMessageLourd != "Lourd")
	{
		return "REJECTED"
	}
	if(strMessageEncombrant != "Encombrant" && strMessageLourd != "Lourd")
	{
		return "SPECIAL"
	}

	return "";
}

}
