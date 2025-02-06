using System;

class Program
{
    static void Main()
    {
        Console.Write("Lütfen bir sayı giriniz: ");

        try
        {
            int number = Convert.ToInt32(Console.ReadLine());  // Kullanıcıdan giriş al ve sayıya çevir
            int square = number * number;  // Sayının karesini hesapla
            Console.WriteLine($"Girilen sayının karesi: {square}");
        }
        catch (FormatException)  // Geçersiz giriş hatasını yakala
        {
            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
        }
    }
}
