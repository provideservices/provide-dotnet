using System.Collections.Generic;

namespace provide.Baseline.Model
{
    public class Commitment
    {
        /// <summary>
        /// Arbitrary data. 
        /// </summary>
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// Abstract location of the commitment (i.e., in the case of a merkle tree, this is the leaf index)
        /// </summary>
        public long Location { get; set; }

        /// <summary>
        /// Salt such that currentHash = H(data + salt). 
        /// </summary>
        public string Salt { get; set; }

        /// <summary>
        /// Array of proofs;
        /// </summary>
        public long[] Proof { get; set; }

        /// <summary>
        /// Public inputs used to generate the commitment
        /// </summary>
        public string[] PublicInputs { get; set; }

        /// <summary>
        /// Address of participant who created the commitment. 
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// Allows mapping from participant address -> signature. 
        /// </summary>
        public Dictionary<string, string> Signatures { get; set; }

        /// <summary>
        /// Unix timestamp when the commitment was pushed. 
        /// </summary>
        public long Timestamp { get; set; }

        /// <summary>
        /// Commitment value. 
        /// </summary>
        public string Value { get; set; }
    }
}
