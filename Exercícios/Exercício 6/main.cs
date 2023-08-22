using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Escreva o número inicial : ");
    int num_ini = int.Parse(Console.ReadLine());
    Console.WriteLine("Escreva o número Final: ");
    int num_fin = int.Parse(Console.ReadLine());

    while (num_ini <= num_fin){
      Console.WriteLine(num_ini);
      num_ini ++;
    }
  }
}