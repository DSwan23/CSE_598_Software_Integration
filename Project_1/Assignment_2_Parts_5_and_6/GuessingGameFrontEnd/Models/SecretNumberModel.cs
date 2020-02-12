using System;

namespace GuessingGameFrontEnd.Models
{
    public class SecretNumberModel
    {
        public int LowerBound { get; set; }
        public int UpperBound { get; set; }
        public int SecretNumber { get; set; }
        public string CodeResponse { get; set; }
        public int UserGuess { get; set; }
    }
}
