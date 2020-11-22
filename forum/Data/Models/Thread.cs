using System;
using System.Collections.Generic;

namespace forum.Data.Models
{
    public class Thread
    {
        public Thread()
        {
        }
        public int id { set; get; }
        public string name { set; get; }
        public DateTime date { set; get; }
        public Match match { set; get; }
        public List<Message> messages { set; get; }
    }
}
