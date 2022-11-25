using System;
using ConverterDictionaryComposition;

namespace EnglishDictionaryFactory
{
    /// <summary>
    /// Presents the factory of the dictionary of the char correspondences of the number to their word analogs in english.
    /// </summary>
    public class EnglishCharsDictionaryFactory : ICharsDictionaryFactory
    {
        /// <inheritdoc cref="ICharsDictionaryFactory.CreateDictionary"/>
        public CharsDictionary CreateDictionary() => new ()
        {
            Dictionary = new Dictionary<Сharacter, string>
            {
                [Сharacter.Zero] = "zero",
                [Сharacter.One] = "one",
                [Сharacter.Two] = "two",
                [Сharacter.Three] = "three",
                [Сharacter.Four] = "four",
                [Сharacter.Five] = "five",
                [Сharacter.Six] = "six",
                [Сharacter.Seven] = "seven",
                [Сharacter.Eight] = "eight",
                [Сharacter.Nine] = "nine",
                [Сharacter.Minus] = "minus",
                [Сharacter.Plus] = "plus",
                [Сharacter.Point] = "point",
                [Сharacter.Comma] = "comma",
                [Сharacter.Exponent] = "exponent",
                [Сharacter.Epsilon] = "epsilon",
                [Сharacter.NegativeInfinity] = "negative infinity",
                [Сharacter.PositiveInfinity] = "positive infinity",
                [Сharacter.NaN] = "not a number",
            },
            CultureName = "en-us",
        };
    }
}
