namespace EnumDemo
{
    public class Animal : IMouvement, IEtreViavant
    {
        public int Age { get; set; }

        public string Name { get; set; }
        public int Energie { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsEnergieUtiliser()
        {
            throw new NotImplementedException();
        }

        public string Marcher()
        {
            throw new NotImplementedException();
        }

        public void Sauter()
        {
            throw new NotImplementedException();
        }
    }
}
