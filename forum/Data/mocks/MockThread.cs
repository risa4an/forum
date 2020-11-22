using System;
using System.Collections.Generic;
using forum.Data.interfaces;
using forum.Data.Models;

namespace forum.Data.mocks
{
    public class MockThread : IThread
    {
        public MockThread()
        {
        }

        public IEnumerable<Thread> GetMatchThreads {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }
}
