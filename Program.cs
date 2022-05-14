using System;

namespace Banco
{
    internal class LetsCash
    {
        static void Main(string[] args)
        {

            int senha = 5190;
            int tentativa = 1;
            bool check;

            Console.WriteLine("******************************************************");
            Console.WriteLine("**************** Banco LetsCash **********************");
            Console.WriteLine("******************************************************\n");
            Console.WriteLine("Você tem três chances para entrar em sua conta!\n");

            do
            {
                Console.Write("Digite a senha para entrar: ");
                check = (int.TryParse(Console.ReadLine(), out int inputSenha) && inputSenha > 0);

                if (tentativa == 3)
                {
                    Console.WriteLine($"Senha bloqueada!");
                    break;
                }
                else if (inputSenha != senha)
                {
                    Console.WriteLine($"Senha incorreta!\nVocê está na {tentativa + 1}ª chance!");
                }
                else
                {
                    Console.WriteLine("Senha correta!");
                    break;
                }
                tentativa++;
            } while (check == false || tentativa <= 3);
        }
    }
}