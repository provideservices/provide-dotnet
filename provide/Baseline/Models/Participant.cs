using System.Collections.Generic;

namespace provide.Baseline.Model
{
    public class Participant
    {
        public string Address { get; set; }
        public Dictionary<string, object> Metadata { get; set; }
        public string Url { get; set; }
    }
}

