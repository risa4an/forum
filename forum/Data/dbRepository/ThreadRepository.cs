using System;
using System.Collections.Generic;
using forum.Data.interfaces;
using forum.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace forum.Data.dbRepository
{
    
    public class ThreadRepository : IThread
    {
        private readonly AppDBContent DbData;

        public ThreadRepository(AppDBContent DbContent)
        {
            this.DbData = DbContent;
        }



        public IEnumerable<Thread> GetMatchThreads => DbData.Thread;

    }
}
