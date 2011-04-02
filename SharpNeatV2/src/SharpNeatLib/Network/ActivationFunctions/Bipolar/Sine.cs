/* ***************************************************************************
 * This file is part of SharpNEAT - Evolution of Neural Networks.
 * 
 * Copyright 2004-2006, 2009-2010 Colin Green (sharpneat@gmail.com)
 *
 * SharpNEAT is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * SharpNEAT is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with SharpNEAT.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;

namespace SharpNeat.Network
{
    /// <summary>
    /// Sine activation function with doubled period.
    /// </summary>
    public class Sine : IActivationFunction
    {
        /// <summary>
        /// Default instance provided as a public static field.
        /// </summary>
        public static readonly IActivationFunction __DefaultInstance = new Sine();

        /// <summary>
        /// Gets the unique ID of the function. Stored in network XML to identify which function a network or neuron 
        /// is using.
        /// </summary>
        public string FunctionId
        {
            get { return this.GetType().Name; }
        }

        /// <summary>
        /// Gets a human readable string representation of the function. E.g 'y=1/x'.
        /// </summary>
        public string FunctionString
        {
            get { return "y = sin(2*x)"; }
        }

        /// <summary>
        /// Gets a human readable verbose description of the activation function.
        /// </summary>
        public string FunctionDescription
        {
            get { return "Sine function with doubled period.\r\nEffective xrange->[-Inf,Inf] yrange[-1,1]"; }
        }       

        /// <summary>
        /// Calculates the output value for the specified input value.
        /// </summary>
        public double Calculate(double x)
        {
            return Math.Sin(2.0 * x);
        }

        /// <summary>
        /// Calculates the output value for the specified input value with float/single precision.
        /// This single precision overload of Calculate() will be used in neural network code 
        /// that has been specifically written to use floats instead of doubles.
        /// </summary>
        public float Calculate(float x)
        {   // ENHANCEMENT: Search for a math lib that operates on single precision floats.
            return (float)Math.Sin(2f * x);
        }
    }
}