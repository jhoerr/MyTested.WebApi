﻿// MyWebApi - ASP.NET Web API Fluent Testing Framework
// Copyright (C) 2015 Ivaylo Kenov.
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/.

namespace MyWebApi.Builders.Created
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http.Formatting;
    using Contracts.Created;

    /// <summary>
    /// Used for testing media type formatters in a created result.
    /// </summary>
    public class FormattersBuilder : IAndFormattersBuilder
    {
        private readonly ICollection<MediaTypeFormatter> mediaTypeFormatters;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormattersBuilder" /> class.
        /// </summary>
        public FormattersBuilder()
        {
            this.mediaTypeFormatters = new List<MediaTypeFormatter>();
        }

        /// <summary>
        /// Tests whether created result contains the provided media type formatter.
        /// </summary>
        /// <param name="mediaTypeFormatter">Instance of MediaTypeFormatter.</param>
        /// <returns>The same formatters test builder.</returns>
        public IAndFormattersBuilder ContainingMediaTypeFormatter(MediaTypeFormatter mediaTypeFormatter)
        {
            this.mediaTypeFormatters.Add(mediaTypeFormatter);
            return this;
        }

        /// <summary>
        /// Tests whether created result contains the provided media type formatter.
        /// </summary>
        /// <typeparam name="TMediaTypeFormatter">Instance of MediaTypeFormatter.</typeparam>
        /// <returns>The same formatters test builder.</returns>
        public IAndFormattersBuilder ContainingMediaTypeFormatterOfType<TMediaTypeFormatter>()
            where TMediaTypeFormatter : MediaTypeFormatter, new()
        {
            return this.ContainingMediaTypeFormatter(Activator.CreateInstance<TMediaTypeFormatter>());
        }

        /// <summary>
        /// AndAlso method for better readability when chaining formatters tests.
        /// </summary>
        /// <returns>The same formatters test builder.</returns>
        public IFormattersBuilder AndAlso()
        {
            return this;
        }

        internal ICollection<MediaTypeFormatter> GetMediaTypeFormatters()
        {
            return this.mediaTypeFormatters;
        }
    }
}