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

        static Enemies CreateEnemy(){
            Enemies Enemy = new Enemies("Esqueleto", 1, "Inimigo");
            return Enemy;
        }
        static string PlayerName(){
            Console.Write("Digite o nome do seu personagem: ");
            string Name = Console.ReadLine();
            return Name;
        }

        static void Play(Characters Player){
            int Damage, Rounds = 1;
            Texts Text = new Texts();
            
            var Enemy = CreateEnemy();
            Text.HeroData();
            Text.PlayerStatus(Player);
            Text.NewLine();
            Text.StartFight();
            Text.OpponentStatus(Enemy);
            Text.PlayerStatus(Player);
            Text.NewLine();
            
            while(true){
                Text.PrintRounds(Rounds);
                Damage = Player.Attack();
                Text.DamageEnemy(Damage);
                Enemy.TakeDamage(Damage);
                Text.OpponentStatus(Enemy);
                Text.NewLine();

                Damage = Enemy.Attack();
                Text.DamageHero(Damage);
                Player.TakeDamage(Damage);
                Text.PlayerStatus(Player);
                Text.NewLine();
                
                if(Enemy.HealthPoints <= 0) 
                {   
                    Text.YouWin();
                    Text.EndGame();
                    break;
                }
                else if(Player.HealthPoints <=0){
                    Text.YouLose();
                    Text.EndGame();
                    break;
                }
                Rounds++;
                Console.ReadLine();
            }
        }

        static void Main(string[] args){

            Texts Text = new Texts();
            Text.StartGame();
            Text.Tutorial();
            Text.NewLine();
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
                Play(PlayerWizard);
            }
            else {
                Knight PlayerKnight = new Knight(Name,1, "Knight");
                Play(PlayerKnight);
            }

            

        }
    }
}