namespace RPG_Dio.src.Entities
{
    public class Texts
    {
        public Texts(){}

        public void StartFight(){
            Console.WriteLine("Iniciando a batalha");
        }
        public void OpponentStatus(Enemies Enemy){
            Console.WriteLine(Enemy.ToString());
        }

        public void PlayerStatus(Characters Player){
            Console.WriteLine(Player.ToString());
        }
        public void EndGame(){
            Console.WriteLine("Fim de jogo");
        }

        public void NewLine(){
            Console.WriteLine("");
        }

        public void DamageHero(int Damage){
            Console.WriteLine($"Dano total em voce: {Damage}");
        }
        public void DamageEnemy(int Damage){
            Console.WriteLine($"Dano total no inimigo: {Damage}");
        }

        public void HeroData(){
            Console.WriteLine("Dados do seu personagem:");
        }

    }
}