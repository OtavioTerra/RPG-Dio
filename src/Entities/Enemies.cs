namespace RPG_Dio.src.Entities
{
    public class Enemies:Characters
    {
        public Enemies(string name, int level, string herotype){
            this.Name = name;
            this.Level = level;
            this.HeroType = herotype;
            this.HealthPoints = SetInitialHealthPoints();
            this.MagicPoints = SetMagicPoints();
        }

        public override int SetInitialHealthPoints()
        {
            Engine StartEngine = new Engine();
            return StartEngine.RandValue(12) + 5;
        }

        public override int SetMagicPoints()
        {
            Engine StartEngine = new Engine();
            return StartEngine.RandValue(2) + 1;
        }
        public override int Attack()
        {
            Engine StartEngine = new Engine();
            return StartEngine.RandValue(4);

        }
    }
}