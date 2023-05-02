// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Collections.Generic;

var res = code.ComputeGameState("Bob", "Anna", new string[] { "Bob", "Anna", "Bob" });

Console.WriteLine(res);

public class code
{
    private static int player1Score = 0;
    private static int player2Score = 0;

    private static readonly Dictionary<int, string> scoreLookup = new Dictionary<int, string>
    {
        { 0, "0" },
        { 1, "15" },
        { 2, "30" },
        { 3, "40" }
    };

    private static readonly Dictionary<int, string> scoreLookupDeuce = new Dictionary<int, string>
    {
        { 0, "DEUCE" },
        { 1, "ADVANTAGE P1" },
        { -1, "ADVANTAGE P2" }  
    };

    public static string ComputeGameState(string nameP1, string nameP2, string[] wins)
    {
        foreach (string winner in wins)
        {
            if (winner == nameP1)
            {
                player1Score++;
            }
            else if (winner == nameP2)
            {
                player2Score++;
            }

            string score = GetScore();

            if (score.StartsWith("DEUCE"))
            {
                int scoreDiff = player1Score - player2Score;
                if (scoreLookupDeuce.TryGetValue(scoreDiff, out string? deuceState))
                {
                    return deuceState;
                }
            }
            else if (score.StartsWith("ADVANTAGE"))
            {
                int scoreDiff = player1Score - player2Score;
                if (scoreDiff == 0)
                {
                    return "DEUCE";
                }
                else if (scoreLookupDeuce.TryGetValue(scoreDiff, out string? advantageState))
                {
                    return advantageState;
                }
            }
            else if (score.StartsWith(nameP1 + " WINS"))
            {
                return "P1 WINS";
            }
            else if (score.StartsWith(nameP2 + " WINS"))
            {
                return "P2 WINS";
            }
        }

        return GetScore();
    }

    private static string GetScore()
    {
        if (player1Score >= 3 && player2Score >= 3 && player1Score == player2Score)
        {
            return "DEUCE";
        }
        // Ajouter par bassit***********************************************************
        if(player1Score >=3 && player2Score >=3 && player1Score - player2Score > 1)
        {
            return "P1 ADVANTAGE";
        }

        if (player2Score  >= 3 && player1Score >= 3 &&  player2Score - player1Score > 1)
        {
            return "P2 ADVANTAGE";
        }
        //******************************************************************************
        else if (player1Score >= 4 && player1Score - player2Score >= 2)
        {
            return "P1 WINS";
        }
        else if (player2Score >= 4 && player2Score - player1Score >= 2)
        {
            return "P2 WINS";
        }
        // Ajouter par bassit***********************************************************
        else if(player1Score == 1 && player2Score - player1Score == 0)
        {
            return "15a";
        }
        else if (player1Score == 2 && player2Score - player1Score == 0)
        {
            return "30a";
        }
        //******************************************************************************
        else if (scoreLookup.TryGetValue(player1Score, out string? p1ScoreText) && scoreLookup.TryGetValue(player2Score, out string? p2ScoreText))
        {
            return $"P1 {p1ScoreText} - P2 {p2ScoreText}";
        }
        else
        {
            return "";
        }
    }
}
