using System;
using RPG_Dio.src.Entities;


namespace RPGDio
{
    class Program
    {   

        static string ClassChoice(){
            Console.WriteLine("Escolha sua classe:");
            Console.Write("Wizard ou Knight--->  ");
            string ClassPlayer = Console.ReadLine();
            return ClassPlayer.ToUpper();
        }
        static string PlayerName(){
            Console.Write("Digite o nome do seu personagem: ");
            string Name = Console.ReadLine();
            return Name;
            
        }

        static void PlayAsWizard(Wizard Player){
            Console.WriteLine("Dados do seu personagem:");
            Console.WriteLine(Player.ToString());
        }

        static void PlayAsKnight(Knight Player){
            Console.WriteLine("Dados do seu personagem:");
            Console.WriteLine(Player.ToString());
        }


        static void Main(string[] args){
            Console.WriteLine("Bem vindo ao Jogo\n");

            string ClassPlayer = ClassChoice();
            string Name = PlayerName();

            bool Control = true;

            while(Control){
                switch(ClassPlayer){
                    case "WIZARD":
                        Control = false;
                        break;
                    case "KNIGHT":
                        Control = false;
                        break;
                    default:
                        Console.WriteLine("Classe Invalida");
                        ClassPlayer = ClassChoice();
                        break;
                }
            }

            if(ClassPlayer == "WIZARD"){
                Wizard PlayerWizard = new Wizard(Name, 1, "Wizard");
                PlayAsWizard(PlayerWizard);
            }
            else {
                Knight PlayerKnight = new Knight(Name,1, "Knight");
                PlayAsKnight(PlayerKnight);
            }

            

        }
    }
}