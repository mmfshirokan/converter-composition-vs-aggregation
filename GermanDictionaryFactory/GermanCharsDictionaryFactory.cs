using System;
using ConverterDictionaryComposition;

namespace GermanDictionaryFactory
{
    /// <summary>
    /// Presents the factory of the dictionary of the char correspondences of the number to their word analogs in german.
    /// </summary>
    public class GermanCharsDictionaryFactory : ICharsDictionaryFactory
    {
        /// <inheritdoc href="ConverterDictionaryComposition.CreateDictionary"/>
        public CharsDictionary CreateDictionary() => new ()
        {
            Dictionary = new Dictionary<Сharacter, string>
            {
                [Сharacter.Zero] = "null",
                [Сharacter.One] = "eins",
                [Сharacter.Two] = "zwei",
                [Сharacter.Three] = "drei",
                [Сharacter.Four] = "vier",
                [Сharacter.Five] = "fünf",
                [Сharacter.Six] = "sechs",
                [Сharacter.Seven] = "sieben",
                [Сharacter.Eight] = "acht",
                [Сharacter.Nine] = "neun",
                [Сharacter.Minus] = "minus",
                [Сharacter.Plus] = "plus",
                [Сharacter.Point] = "punkt",
                [Сharacter.Comma] = "komma",
                [Сharacter.Exponent] = "exponent",
                [Сharacter.Epsilon] = "epsilon",
                [Сharacter.NegativeInfinity] = "negative unendlichkeit",
                [Сharacter.PositiveInfinity] = "positive unendlichkeit",
                [Сharacter.NaN] = "keine zahl",
            },
            CultureName = "de-de",
        };
    }
}
