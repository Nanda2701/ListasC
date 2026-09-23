using System.ComponentModel;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exemplo
            //List<string> joias = new List<string>();
            //joias.Add("Colar");
            //joias.Add("Anel");
            //joias.Add("Relogio");
            //joias.Add("Pulseira");
            //joias.Add("Brincos");

            //foreach (string acessorios in joias)
            //{
            //    Console.WriteLine(acessorios);
            //}

            //Console.WriteLine("Imprimir como array");
            //Console.WriteLine(joias[0]);

            #endregion Exemplo

            #region Exercício 1 — Criar e mostrar

            ////1.Cria uma lista de string e usa Add para adicionar 5 nomes à tua escolha.
            //List<string> casa = new List<string>();
            //casa.Add("Mesa");
            //casa.Add("Sofa");
            //casa.Add("Tv");
            //casa.Add("Cama");
            //casa.Add("Pratos");

            ////2.Percorre a lista com um foreach e mostra cada nome no ecrã.
            //foreach (string mobilia in casa)
            //{ 
            //    Console.WriteLine(mobilia);
            //}

            ////3.Usa Count para mostrar a frase: "A lista tem X nomes." 

            //Console.WriteLine($"A lista tem {casa.Count} nomes");

            #endregion Exercício 1 — Criar e mostrar

            #region Exercício 2 — Soma dos números (Resolve à mão — sem métodos prontos (só ciclos, índices e Count).
            //1.Cria uma lista de int com os valores 10, 20, 30, 40 e 50.
            //List<int> valores = new List<int>();
            //valores.Add(10);
            //valores.Add(20);
            //valores.Add(30);
            //valores.Add(40);
            //valores.Add(50);

            ////2.Sem usar qualquer método pronto, percorre a lista com um ciclo 
            ////    e calcula a soma de todos os elementos.Mostra o resultado. 
            //int soma = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    soma = soma + valores[i];
            //}
            //Console.WriteLine($"Soma dos valores são: {soma}");

            #endregion Exercício 2 — Soma dos números

            #region Exercício 3 — Adicionar, inserir e remover

            //1.Cria uma lista de string com 4 frutas(usa Add).

            //List<string> frutas = new List<string>();
            //frutas.Add("manga");
            //frutas.Add("goiaba");
            //frutas.Add("acerola");
            //frutas.Add("graviola");
            //frutas.Add("caja");

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{frutas[i]} \n");
            //}

            //////2.Usa Insert para colocar uma fruta na 2.ª posição e RemoveAt para remover a primeira.

            //frutas.Insert(1, "Jambre");
            //frutas.RemoveAt(0);

            //foreach (string fruta in frutas) 
            //{

            // Console.WriteLine($"{fruta} \n");

            //}

            ////3.Usa Remove para apagar uma fruta pelo nome e mostra a lista final com foreach.

            //frutas.Remove("Caja");

            //foreach(string frut in frutas)
            //{

            //    Console.WriteLine(frut);
            //}

            #endregion Exercício 3 — Adicionar, inserir e remover


            #region Exercício 4 — Encontrar o maior

            ////1.Cria uma lista de int com 6 números à tua escolha.
            //List<int> num = new List<int>();
            //num.Add(10);
            //num.Add(15);
            //num.Add(9);
            //num.Add(16);
            //num.Add(5);
            //num.Add(20);

            ////2.Sem usar funções prontas(nada de Max), percorre a lista e descobre qual é o maior valor. Mostra - o no ecrã.
            ////3.Dica: começa por assumir que o primeiro elemento é o maior e vai comparando
            //int maior = 0;

            //for (int i = 0; i < num.Count; i++)
            //{
            //    if (num[i] > maior)
            //    {
            //        maior = num[i];
            //    }
            //}
            //Console.WriteLine(maior);


            #endregion Exercício 4 — Encontrar o maior

            #region Exercício 5 — Ordenar a lista

            //1.Cria uma lista de int com 6 números desordenados.

            //List<int> numero = new List<int>();

            //numero.Add(586);
            //numero.Add(256);
            //numero.Add(136);
            //numero.Add(419);
            //numero.Add(182);
            //numero.Add(484);

            ////2.Usa o método Sort para a ordenar.
            //numero.Sort();

            ////3.Mostra a lista ordenada com um foreach. 
            //foreach (int sorteado in numero) 
            //{

            //    Console.WriteLine(sorteado);

            //}

            #endregion Exercício 5 — Ordenar a lista

            #region Exercício 6 — Contar os pares

            //1.Cria uma lista com 10 números inteiros.
            //List<int> pares = new List<int> { 12,1,2,8,4,16,15,20,18,11};
            
            ////2.Sem métodos prontos, percorre a lista e conta quantos são pares(usa o operador %).Mostra o total no fim. 
            //int contadorpar = 0;

            //foreach (int par in pares) 
            //{
             
            //  if (par % 2 == 0 ) 
            //  {

            //        contadorpar++;
                
            //  }

            
            //}
            //Console.WriteLine($"Numeros pares: {contadorpar}");

            #endregion Exercício 6 — Contar os pares

            #region Exercício 7 — Procurar um nome

            ////1.Cria uma lista com vários nomes.
            //List<string> nomes = new List<string> {"kellvem","fernanda","jamylle","isabel","juliana","francisco"};

            ////2.Pede um nome ao utilizador e usa Contains para verificar se já existe na lista.
            ////3.Se existir, usa IndexOf para mostrar em que posição está; caso contrário, mostra "Não existe.". 

            //Console.WriteLine($"Digite um nome para pesquisar?");
            //string nomeprocu = Console.ReadLine();

            //if (nomes.Contains(nomeprocu)) 
            //{
            //    int posi = nomes.IndexOf(nomeprocu);
            //    Console.WriteLine($"O nome existe e estar na lista posição (indice): {posi}");
            
            //}
            //else 
            //{
            //    Console.WriteLine("Não Existe.");
            
            //}
            


            #endregion Exercício 7 — Procurar um nome

            #region Exercício 8 — Inverter a apresentação

            //1.Cria uma lista de int com 5 valores.
            List<int> aleat = new List<int>{ 58 , 22 , 90 , 10 , 15};


            //2.Sem usar Reverse, usa um ciclo for para mostrar os elementos por ordem inversa
            //(do último para o primeiro), sem alterar a lista

            for (int i = 4; i > -1 ; i--)
            {
                Console.WriteLine(aleat[i]);
            }

            //Dica: começa o ciclo em lista.Count - 1 e decrementa até 0.
            #endregion Exercício 8 — Inverter a apresentação








        }
    }
}
