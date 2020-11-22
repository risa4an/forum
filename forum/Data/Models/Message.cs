using System;
namespace forum.Data.Models
{
    public class Message
    {
        public Message()
        {
        }
        public int id { set; get; }
        public int idThread { set; get; }
        public virtual Thread Thread { set; get; }
        public string text { set; get; }
        public DateTime date { set; get; }
    }
}
