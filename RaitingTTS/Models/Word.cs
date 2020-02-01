using System;
using System.Collections.Generic;

namespace RaitingTTS.Models
{
    public partial class Word
    {
        public Word()
        {
            Attempt = new HashSet<Attempt>();
        }

        public int Id { get; set; }
        public string TextEnglish { get; set; }
        public string TextSpanish { get; set; }
        public string AudioUrl { get; set; }
        public int Level { get; set; }
        public string Language { get; set; }
        public int Area { get; set; }
        public int Number { get; set; }

        public virtual ICollection<Attempt> Attempt { get; set; }
    }
}
