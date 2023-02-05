using System;

namespace ConsoleApp8
{
  class Program
  {
    static void Main(string[] args)
    {
      // Инициализация массива строк
      string[] daysOfWeek = { "Sunday", "Monday", "Tuersday",
      "Wednesday", "Thirsday", "Friday", "Saturday" };

      // Вывод массива строк AS в цикле
      for (int i = 0; i < daysOfWeek.Length; i++)
        Console.WriteLine("AS[{0}] = {1}", i, daysOfWeek[i]);
      Console.ReadKey();
    }
  }
}