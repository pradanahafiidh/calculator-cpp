using System;

public class calculator 
{
    static void Main(String[]args) 
    {
        Console.Title = "Aplikasi Calculator";
        Console.Write("Inputkan nilai a = ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Input nilai b = ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("1. Penambahan");
        Console.WriteLine("2. Pengurangan");
        Console.WriteLine("3. Perkalian");
        Console.WriteLine("4. Pembagian");
        Console.Write("Pilih menu operasi bilangan : ");
        int pil = Int32.Parse(Console.ReadLine());

        switch (pil)
        {
            case 1:
                Console.WriteLine("Hasil Penjumlahan " + a + " + " + b + " = " + penambahan(a, b));
                break;
            case 2:
                Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + pengurangan(a, b));
                break;
            case 3:
                Console.WriteLine("Hasil Perkalian " + a + " * " + b + " = " + perkalian(a, b));
                break;
            case 4:
                Console.WriteLine("Hasil Pembagian " + a + " / " + b + " = " + pembagian(a, b));
                break;
            case 5:
                Console.WriteLine("Maaf,pilihan tidak tersedia...");
                break;
            default:
                break;
        }
        
    Console.ReadKey();

    }
    static int Penambahan (int a, int b)
    {
        return a + b;
    }
    static int Pengurangan (int a , int b)
    {
        return a - b;
    }
     static int perkalian(int a, int b)
    {
        return a * b;
    }
    static int pembagian(int a, int b)
    {
        return a / b;
    }
}