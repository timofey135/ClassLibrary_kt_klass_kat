namespace ClassLibrary_kt_klass_kat
{
    public class CuteCat : Cat
    {
        private readonly int _fluffiness;

        public override int Fluffiness => _fluffiness;

        public CuteCat(int fluffiness = 50)
        {
            if (fluffiness < 0 || fluffiness > 140)
            {
                throw new CatException(
                    $"Unable to create a cute cat with fluffiness: {fluffiness}");
            }

            _fluffiness = fluffiness;
        }

        public override string FluffinessCheck()
        {
            if (Fluffiness == 0)
                return "Sphynx";
            else if (Fluffiness <= 20)
                return "Slightly";
            else if (Fluffiness <= 50)
                return "Medium";
            else if (Fluffiness <= 75)
                return "Heavy";
            else
                return "OwO";
        }

        public override string ToString()
        {
            return $"A cute cat with fluffiness: {Fluffiness}";
        }
    }
}
