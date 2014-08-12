using System;
using System.Diagnostics;

namespace TestThreading
{
    class Tester
    {
        #region Private fields

        private Stopwatch _stopWatch;

        #endregion

        #region Counstructors

        public Tester()
        {
            _stopWatch = new Stopwatch();
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Counts method's runtime and shows result.
        /// </summary>
        /// <param name="action"></param>
        public void StopWatching(Action action)
        {
            _stopWatch.Start();
            action();
            _stopWatch.Stop();
            Console.WriteLine("Time {1} Method: {0}", action.Method.Name, _stopWatch.Elapsed);
            _stopWatch.Reset();
        }

        #endregion
    }
}
