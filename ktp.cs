using System;

class ktp
{
    static void Main()
    {
        Console.WriteLine("Masukkan umur: ");
        int umur = int.Parse(Console.ReadLine());
        int umurMinimal = 17;
        bool bisaMembuatKtp = umur >= umurMinimal;

        Console.Write("Apakah saya bisa bikin ktp? ");
        if (bisaMembuatKtp)
        {
            Console.Write("Bisa lah jing");
        } else
        {
            Console.Write("ga bisa lomgor");
        }
    }
}