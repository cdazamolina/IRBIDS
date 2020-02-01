using System;
using System.Collections.Generic;

namespace RaitingTTS.Models
{
    public partial class User
    {
        public User()
        {
            Attempt = new HashSet<Attempt>();
        }

        public int Id { get; set; }
        public string Ani { get; set; }
        public float Score { get; set; }
        public int AttemptCount { get; set; }

        public virtual ICollection<Attempt> Attempt { get; set; }
    }
}
