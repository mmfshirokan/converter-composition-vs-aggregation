﻿using System;
using TransformerDictionaryComposition;

namespace RussianDictionaryProvider
{
    /// <summary>
    /// Presents the provider of the dictionary of symbols of the russian language.
    /// </summary>
    public class RussianSymbolsDictionaryProvider : ISymbolsDictionaryProvider
    {
        /// <inheritdoc cref="ISymbolsDictionaryProvider.CreateSymbolsDictionary"/>
        public SymbolsDictionary CreateSymbolsDictionary() => throw new NotImplementedException();
    }
}
