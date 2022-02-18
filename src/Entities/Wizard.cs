namespace RPG_Dio.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string herotype)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = herotype;
        }
        public override string Attack(){

            return this.Name + " atacou com uma magia";
        }
    }
}