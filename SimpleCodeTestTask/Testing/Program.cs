using System;
class Program
{
    static void Main(string[] args)
    {
        string[] A = {
            "unlock.microvirus.md",
            "visitwar.com",
            "visitwar.de",
            "fruonline.co.uk",
            "australia.open.com",
            "credit.card.us"
        };
        string[] B = {
            "microvirus.md",
            "visitwar.de",
            "piratebay.co.uk",
            "list.stolen.credit.card.us"
        };

        int[] result = Solution.solution(A, B);

        Console.Write("Результат: [ ");
        foreach (int i in result)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("]");
    }
}
