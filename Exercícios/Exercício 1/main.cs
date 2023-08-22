using System;

class Program {
  public static void Main (string[] args) {
  // declaração de variáveis
    int opcao, MaiorNumero = 0, i = 0 ;
    int[] idades = new int[5];
    String[] nomes = new String[5];
    String[] resultado = new String[5];
    String parar = "N";

 // o comando while serve para controlar a execução do menu principal
    while (parar == "N") {
     Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Listar");
    Console.WriteLine("3 - Mais Velho");
    Console.WriteLine("4 - Sair");
    
      opcao = int.Parse(Console.ReadLine());
      switch (opcao) 
    {
 // caso 1 o sistema vai pegar os valores de nome e idade e jogar nas respectivas arrays nomes e idades. Além disso já defino uma Array de resultado que é a junção do nome com a idade cadastrada.     
    case 1  : 
    if (i < 5) {
      Console.WriteLine("Escreva um nome : ");
    nomes[i] = Console.ReadLine();
    Console.WriteLine("Escreva a idade: ");
    idades[i] = int.Parse(Console.ReadLine());
    resultado[i] = "nome: " + nomes[i] + " idade: " + idades[i];
    i = i + 1;
      } else {
      Console.WriteLine("Ultrapassou o tamanho máximo !");
      }
    break;
 // no segundo caso ele imprime todos os elementos da array reusltado
    case 2:
      for (int contador = 0; contador < 5; contador ++){
        Console.WriteLine(resultado[contador]);
      }      
      break;
// no terceiro caso o comando for vai achar o maior numero. Logo após isso pego o indice dele na array idades e como a array idades e Resultado vão possuir a mesma ordem, logo o indice servirá para a array resultado também    
    case 3:
      for (int cont = 0; cont < 5; cont ++){
        if (idades[cont] > MaiorNumero){
          MaiorNumero = idades[cont];
        } 
      }Console.WriteLine(resultado[Array.IndexOf(idades,MaiorNumero)]);
      break;
// No caso 4 ele para o comando while
    case 4:
      parar = "S";
      break;
    }}
    }
    }
  
