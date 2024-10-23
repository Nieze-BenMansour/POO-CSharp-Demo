namespace EnumDemo
{
    public class Humain : IEtreViavant, IMouvement
    {
        public static string Slogan = "We are humain";

        public Humain(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public int Age { get; set; }

        public string Name { get; set; }

        public int Energie { get; set; }

        public static string DireSlogan()
        {
            return Slogan;
        }

        public bool IsEnergieUtiliser()
        {
            if (this.Energie > 0) 
            { 
                return true;
            }

            return false;
        }

        public void Sauter()
        {
            throw new NotImplementedException();
        }

        public string Marcher()
        {
            return "Je marche";
        }
    }
}
