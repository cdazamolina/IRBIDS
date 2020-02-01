using System;
using System.Collections.Generic;

namespace RaitingTTS.Models
{
    public partial class Attempt
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Created { get; set; }
        public float Confidence { get; set; }
        public int WordId { get; set; }
        public string RecordedUrl { get; set; }

        public virtual User User { get; set; }
        public virtual Word Word { get; set; }
    }
}
