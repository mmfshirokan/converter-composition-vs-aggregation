using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Text;

namespace ConverterDictionaryAggregation
{
    /// <summary>
    /// Converts a real number to string.
    /// </summary>
    public class Converter
    {
        private readonly CharsDictionary dictionary;

        /// <summary>
        /// Initializes a new instance of the <see cref="Converter"/> class.
        /// </summary>
        /// <param name="charsDictionary">The dictionary with rules of converting.</param>
        /// <exception cref="System.ArgumentNullException">Thrown when dictionary is null.</exception>
        /// <exception cref="System.ArgumentException">Thrown when charsDictionary.Dictionary is empty.</exception>
        public Converter(CharsDictionary? charsDictionary)
        {
            if (charsDictionary is null)
            {
                throw new ArgumentNullException(nameof(charsDictionary));
            }

            if (charsDictionary.Dictionary.Count == 0)
            {
                throw new ArgumentException("Dictionary is empty.", nameof(charsDictionary));
            }

            this.dictionary = charsDictionary;
        }

        /// <summary>
        /// Converts double number into string.
        /// </summary>
        /// <param name="number">Double number to convert.</param>
        /// <returns>A number string representation.</returns>
        public string Convert(double number)
        {
            return number switch
            {
                double.NaN => dictionary.Dictionary[Сharacter.NaN],
                double.NegativeInfinity => dictionary.Dictionary[Сharacter.NegativeInfinity],
                double.PositiveInfinity => dictionary.Dictionary[Сharacter.PositiveInfinity],
                double.Epsilon => dictionary.Dictionary[Сharacter.Epsilon],
                _ => this.NumberToWord(number),
            };
        }

        private string NumberToWord(double number)
        {
            var numberStr = number.ToString(CultureInfo.GetCultureInfo(this.dictionary.CultureName));
            StringBuilder result = new StringBuilder();
            uint cunter = 0;
            foreach (char ch in numberStr)
            {
                if (cunter == 0)
                {
                    result.Append(CharToStr(ch));
                }
                else
                {
                    result.Append(" " + CharToStr(ch));
                }

                cunter++;
            }

            return result.ToString();

            string CharToStr(char ch) => ch switch
            {
                '0' => dictionary.Dictionary[Сharacter.Zero],
                '1' => dictionary.Dictionary[Сharacter.One],
                '2' => dictionary.Dictionary[Сharacter.Two],
                '3' => dictionary.Dictionary[Сharacter.Three],
                '4' => dictionary.Dictionary[Сharacter.Four],
                '5' => dictionary.Dictionary[Сharacter.Five],
                '6' => dictionary.Dictionary[Сharacter.Six],
                '7' => dictionary.Dictionary[Сharacter.Seven],
                '8' => dictionary.Dictionary[Сharacter.Eight],
                '9' => dictionary.Dictionary[Сharacter.Nine],
                ',' => dictionary.Dictionary[Сharacter.Comma],
                '.' => dictionary.Dictionary[Сharacter.Point],
                '-' => dictionary.Dictionary[Сharacter.Minus],
                '+' => dictionary.Dictionary[Сharacter.Plus],
                'E' => dictionary.Dictionary[Сharacter.Exponent],
                _ => throw new ArgumentException("Unexpected Error Uccured")
            };
        }
    }
}
