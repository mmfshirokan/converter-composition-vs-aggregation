using System;
using ConverterDictionaryComposition;

namespace RussianDictionaryFactory
{
    /// <summary>
    /// Presents the factory of the dictionary of the char correspondences of the number to their word analogs in russian.
    /// </summary>
    public class RussianCharsDictionaryFactory : ICharsDictionaryFactory
    {
        /// <inheritdoc cref="ICharsDictionaryFactory.CreateDictionary"/>
        public CharsDictionary CreateDictionary() => new ()
        {
            Dictionary = new Dictionary<Сharacter, string>
            {
                [Сharacter.Zero] = "ноль",
                [Сharacter.One] = "один",
                [Сharacter.Two] = "два",
                [Сharacter.Three] = "три",
                [Сharacter.Four] = "четыре",
                [Сharacter.Five] = "пять",
                [Сharacter.Six] = "шесть",
                [Сharacter.Seven] = "семь",
                [Сharacter.Eight] = "восемь",
                [Сharacter.Nine] = "девять",
                [Сharacter.Minus] = "минус",
                [Сharacter.Plus] = "плюс",
                [Сharacter.Point] = "точка",
                [Сharacter.Comma] = "запятая",
                [Сharacter.Exponent] = "экспонента",
                [Сharacter.Epsilon] = "эпсилон",
                [Сharacter.NegativeInfinity] = "отрицательная бесконечность",
                [Сharacter.PositiveInfinity] = "положительная бесконечность",
                [Сharacter.NaN] = "не число",
            },
            CultureName = "Ru-Ru",
        };
    }
}
