namespace RPG_Dio.src.Entities
{
    public class  Characters
    {
        public string Name;
        public int Level;
        public string HeroType;
        public int HealthPoints;
        public int MagicPoints;

        public Characters(string name, int level, string herotype){
            this.Name = name;
            this.Level = level;
            this.HeroType = herotype;
            this.HealthPoints = SetInitialHealthPoints();
            this.MagicPoints = SetMagicPoints();
        }
        public Characters(){}

        public virtual int SetInitialHealthPoints(){
            return 0;
        }
        public virtual int SetMagicPoints(){
            return 0;
        }
        public virtual int Attack(){
            return 0;
        }

        public override string ToString()
        {
            return $"Nome:{this.Name} Level:{this.Level} Tipo:{this.HeroType}  HP:{this.HealthPoints} MP:{this.MagicPoints}";
        }
    }
}