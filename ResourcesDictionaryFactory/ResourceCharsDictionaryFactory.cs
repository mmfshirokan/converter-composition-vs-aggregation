﻿using System;
using System.Collections.Generic;
using System.Globalization;
using ConverterDictionaryComposition;
using ResourcesDictionaryFactory.Resources;

namespace ResourcesDictionaryFactory
{
    /// <summary>
    /// Presents the factory of the dictionary of the char correspondences of the number to their word analogs in given language.
    /// </summary>
    public class ResourceCharsDictionaryFactory : ICharsDictionaryFactory
    {
        private string? cultureName;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceCharsDictionaryFactory"/> class.
        /// </summary>
        /// <param name="cultureName">Name of the culture.</param>
        /// <exception cref="System.ArgumentException">Thrown when cultureName is null or empty.</exception>
        public ResourceCharsDictionaryFactory(string? cultureName)
        {
            Dictionary.Culture = cultureName is null
                ? throw new ArgumentException($"{nameof(cultureName)} cannot be null or empty.", nameof(cultureName))
                : new CultureInfo(cultureName);
            this.cultureName = cultureName;
        }

        /// <inheritdoc cref="ICharsDictionaryFactory.CreateDictionary"/>
        public CharsDictionary CreateDictionary()
        {
            return new CharsDictionary()
            {
                Dictionary = new Dictionary<Сharacter, string>
                {
                    [Сharacter.Zero] = Dictionary.Zero,
                    [Сharacter.One] = Dictionary.One,
                    [Сharacter.Two] = Dictionary.Two,
                    [Сharacter.Three] = Dictionary.Three,
                    [Сharacter.Four] = Dictionary.Four,
                    [Сharacter.Five] = Dictionary.Five,
                    [Сharacter.Six] = Dictionary.Six,
                    [Сharacter.Seven] = Dictionary.Seven,
                    [Сharacter.Eight] = Dictionary.Eight,
                    [Сharacter.Nine] = Dictionary.Nine,
                    [Сharacter.Minus] = Dictionary.Minus,
                    [Сharacter.Plus] = Dictionary.Plus,
                    [Сharacter.Point] = Dictionary.Point,
                    [Сharacter.Comma] = Dictionary.Comma,
                    [Сharacter.Exponent] = Dictionary.Exponent,
                    [Сharacter.Epsilon] = Dictionary.Epsilon,
                    [Сharacter.NegativeInfinity] = Dictionary.NegativeInfinity,
                    [Сharacter.PositiveInfinity] = Dictionary.PositiveInfinity,
                    [Сharacter.NaN] = Dictionary.NaN,
                },
                CultureName = this.cultureName,
            };
        }
    }
}
