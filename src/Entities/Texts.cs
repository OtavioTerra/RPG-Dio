namespace RPG_Dio.src.Entities
{
    public class Texts
    {
        public Texts(){}

        public void StartFight(){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Iniciando a batalha");
            Console.ResetColor();
        }
        public void OpponentStatus(Enemies Enemy){
            Console.WriteLine(Enemy.ToString());
        }

        public void PlayerStatus(Characters Player){
            Console.WriteLine(Player.ToString());
        }
        public void EndGame(){
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Fim de jogo");
            Console.ResetColor();
        }

        public void NewLine(){
            Console.WriteLine("");
        }

        public void DamageHero(int Damage){
            Console.Write("Dano total em voce: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Damage);
            Console.ResetColor();
        }
        public void DamageEnemy(int Damage){
            Console.Write("Dano total no inimigo:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Damage);
            Console.ResetColor();
        }

        public void HeroData(){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Dados do seu personagem:");
            Console.ResetColor();
        }

        public void StartGame(){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bem vindo ao RPG-DIO");
            Console.ResetColor();
        }

        public void PrintRounds(int Rounds){
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Round {Rounds}");
            Console.ResetColor();
            Console.WriteLine("-----------------------------------");
        }

        public void YouLose(){
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Voce morreu, o inimigo venceu a batalha");
            Console.ResetColor();
        }
        public void YouWin(){
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Voce venceu a batalha e derrotou seu oponente");
            Console.ResetColor();
        }

        public void Tutorial(){

        }

    }
}