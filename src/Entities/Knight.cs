
namespace RPG_Dio.src.Entities
{
    public class Knight : Characters
    {
        public Knight(string name, int level, string herotype){
            this.Name = name;
            this.Level = level;
            this.HeroType = herotype;
            this.HealthPoints = SetInitialHealthPoints();
            this.MagicPoints = SetMagicPoints();
        }

        public override int SetInitialHealthPoints()
        {
            Engine StartEngine = new Engine();
            return StartEngine.RandValue(10) + 5;
        }

        public override int SetMagicPoints()
        {
            Engine StartEngine = new Engine();
            return StartEngine.RandValue(6) + 1;
        }

        public override int Attack()
        {
            Engine StartEngine = new Engine();
            return StartEngine.RandValue(6);
        }

        public void TakeDamage(int Damage, Knight Player)
        {
            Player.HealthPoints = Player.HealthPoints - Damage;
        }

    }
}