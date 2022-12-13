using System;

namespace ConsoleApp8
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ввод строк с клавиатуры
      // и образование нового массива

      // 1. Объявление переменных
      string Text;
      string [] SelectedWords = {};
      // 2. Цикл ввода строк
      Console.WriteLine("Введите текст:");
    
      Text = Console.ReadLine();
      if (String.IsNullOrEmpty(Text))
        Console.WriteLine("Оставлено пустое поле");
      else{
      string[] words = Text.Split(' ');

       for (int i = 0; i <= words.Count(); i++)
        if (words[i].Length > 3)
            Console.Write(result);
        Console.ReadKey();
      }
     
  }
  }
}