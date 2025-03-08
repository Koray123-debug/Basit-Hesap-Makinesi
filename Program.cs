using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basit Hesap Makinesi");
            Console.WriteLine("-------------------");

            while (true)
            {
                Console.WriteLine("\nİşlem seçin:");
                Console.WriteLine("1. Toplama");
                Console.WriteLine("2. Çıkarma");
                Console.WriteLine("3. Çarpma");
                Console.WriteLine("4. Bölme");
                Console.WriteLine("5. Çıkış");
                Console.Write("Seçiminiz (1-5): ");

                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    Console.WriteLine("Programdan çıkılıyor...");
                    break;
                }

                if (choice != "1" && choice != "2" && choice != "3" && choice != "4")
                {
                    Console.WriteLine("Geçersiz seçim! Lütfen 1-5 arasında bir sayı girin.");
                    continue;
                }

                Console.Write("Birinci sayıyı girin: ");
                double num1;
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.Write("Geçersiz giriş! Lütfen bir sayı girin: ");
                }

                Console.Write("İkinci sayıyı girin: ");
                double num2;
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.Write("Geçersiz giriş! Lütfen bir sayı girin: ");
                }

                double result = 0;
                switch (choice)
                {
                    case "1":
                        result = num1 + num2;
                        Console.WriteLine($"Sonuç: {num1} + {num2} = {result}");
                        break;
                    case "2":
                        result = num1 - num2;
                        Console.WriteLine($"Sonuç: {num1} - {num2} = {result}");
                        break;
                    case "3":
                        result = num1 * num2;
                        Console.WriteLine($"Sonuç: {num1} * {num2} = {result}");
                        break;
                    case "4":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Hata: Sıfıra bölme hatası!");
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Sonuç: {num1} / {num2} = {result}");
                        }
                        break;
                }
            }
        }
    }
}