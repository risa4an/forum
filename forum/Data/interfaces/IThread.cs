using System;
using System.Collections.Generic;
using forum.Data.Models;

namespace forum.Data.interfaces
{
    public interface IThread
    {
        IEnumerable<Thread> GetMatchThreads { get; }
    }
}
