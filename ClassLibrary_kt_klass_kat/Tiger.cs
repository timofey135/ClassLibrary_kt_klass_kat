using ClassLibrary_kt_klass_kat;
using System;
using System.Collections.Generic;

namespace ClassLibrary_kt_klass_kat
{
    public class Tiger : Cat
    {
        private readonly double _weight;
        private readonly int _fluffiness;

        public override int Fluffiness => _fluffiness;

        public double Weight => _weight;

        public Tiger(double weight, int fluffiness = 50)
        {
            List<string> errors = new List<string>();

            if (weight < 75.0 || weight > 140.0)
            {
                errors.Add($"Unable to create a tiger with weight: {weight}");
            }

            if (fluffiness < 0 || fluffiness > 100)
            {
                errors.Add($"Unable to create a tiger with fluffiness {fluffiness}");
            }

            if (errors.Count > 0)
            {
                throw new CatException(string.Join(Environment.NewLine, errors));
            }

            _weight = weight;
            _fluffiness = fluffiness;
        }

        public override string FluffinessCheck()
        {
            return "Kycb!";
        }

        public override string ToString()
        {
            return $"A tiger with weight: {Weight} fluffiness: {Fluffiness}";
        }
    }
}