using System.Threading.Tasks;

namespace TestThreading
{
    class ActionsForTest
    {
        #region Const

        const int Count = 1000000 * 10;

        #endregion

        #region Private fields

        private int[] arr;
        private readonly int _count;

        #endregion

        #region Counstructors

        public ActionsForTest()
        {
            _count = Count;
            arr = new int[_count];
        }

        public ActionsForTest(int count)
        {
            _count = count;
            arr = new int[_count];
        }

        #endregion

        #region Private Methods

        private void Helper(int i)
        {
            if (arr[i] < 10000) arr[i] = i + 10;
            if (arr[i] > 10000 & arr[i] < 200000) arr[i] = i + 20;
            if (arr[i] > 200000 & arr[i] < 3000000) arr[i] = i + 30;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Method fills the array with values by using loop "for"
        /// </summary>
        public void Loopfor()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Helper(i);
            }  
        }

        /// <summary>
        /// Method fills the array with values by using loop "For"
        /// </summary>
        public void LoopFor()
        {
            Parallel.For(0, arr.Length, Helper);
        }

        #endregion
    }
}
