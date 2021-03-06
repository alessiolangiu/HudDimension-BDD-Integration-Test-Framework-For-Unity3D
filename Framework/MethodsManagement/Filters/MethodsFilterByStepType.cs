﻿//-----------------------------------------------------------------------
// <copyright file="MethodsFilterByStepType.cs" company="Hud Dimension">
//     Copyright (c) Hud Dimension. All rights reserved.
//     http://www.HudDimension.co.uk
// </copyright>
//
// <summary>
// This is a methods filter by the type of the Step Method.
// </summary>
// 
// <disclaimer>
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// </disclaimer>
//
// <author>Alessio Langiu</author>
// <email>alessio.langiu@huddimension.co.uk</email>
//-----------------------------------------------------------------------
using System.Reflection;

namespace HudDimension.BDDExtensionForUnityTestTools
{
    /// <summary>
    /// This is a methods filter by the type of the Step Method.
    /// </summary>
    /// <seealso cref="HudDimension.BDDExtensionForUnityTestTools.IMethodsFilter" />
    public class MethodsFilterByStepType : IMethodsFilter
    {
        /// <summary>
        /// Filters the specified method.
        /// </summary>
        /// <typeparam name="T">It must to be an implementation if the interface <see cref="IGivenWhenThenDeclaration" />.</typeparam>
        /// <param name="method">The method to test.</param>
        /// <returns>
        /// True if the method passes the test, otherwise false.
        /// </returns>
        public bool Filter<T>(MethodInfo method) where T : IGivenWhenThenDeclaration
        {
            if (method.GetCustomAttributes(typeof(T), true).Length > 0)
            {
                return true;
            }

            return false;
        }
    }
}
