// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Rathore"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
namespace Program.cs
{
    /// <summary>
    /// stopwatch class
    /// </summary>
    class Watchstop
    {
        /// <summary>
        /// The start time
        /// </summary>
        long startTime;
        long stopTime;
        long elapsed;

        public void Start()
        {
            startTime = DateTime.Now.Millisecond;
        }
        /// <summary>
        /// Stops this instance.
        /// </summary>
        public void Stop()
        {
            stopTime = DateTime.Now.Millisecond;
        }
        /// <summary>
        /// Times this instance.
        /// </summary>
        /// <returns></returns>
        public int Time()
        {
            elapsed = stopTime - startTime;
            return (int)elapsed;
        }
    }
}
