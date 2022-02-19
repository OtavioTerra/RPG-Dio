namespace RPG_Dio.src.Entities
{
    public class Wizard : Characters
    {
        public Wizard(string name, int level, string herotype)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = herotype;
            this.HealthPoints = SetInitialHealthPoints();
            this.MagicPoints = SetMagicPoints();
        }

        public override int SetInitialHealthPoints()
        {
            Engine StartEngine  = new Engine();
            return StartEngine.RandValue(8) + 2;
        }

        public override int SetMagicPoints()
        {
            Engine StartEngine = new Engine();
            return StartEngine.RandValue(10) + 2;
        }

        public override int Attack()
        {
            Engine StartEngine = new Engine();
            return StartEngine.RandValue(8);

        }

        public override void TakeDamage(int Damage)
        {
            this.HealthPoints = this.HealthPoints - Damage;
        }

    }
}