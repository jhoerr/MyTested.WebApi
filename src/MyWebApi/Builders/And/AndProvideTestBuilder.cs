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

namespace MyWebApi.Builders.And
{
    using System;
    using System.Web.Http;
    using Base;

    /// <summary>
    /// Provides controller and action information.
    /// </summary>
    public class AndProvideTestBuilder : BaseTestBuilderWithCaughtException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AndProvideTestBuilder" /> class.
        /// </summary>
        /// <param name="controller">Controller on which the action will be tested.</param>
        /// <param name="actionName">Name of the tested action.</param>
        /// <param name="caughtException">Caught exception during the action execution.</param>
        public AndProvideTestBuilder(ApiController controller, string actionName, Exception caughtException)
            : base(controller, actionName, caughtException)
        {
        }
    }
}
