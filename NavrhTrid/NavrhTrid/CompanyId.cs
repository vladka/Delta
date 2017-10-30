using System;

namespace NavrhTrid
{
    /// <summary>
    /// Identifikator zamestnance. Defaultni instance identifikuje hosta,
    /// </summary>
    public struct CompanyId
    {
        public string Identifier { get; }
        public DateTime Created { get; }

        public CompanyId(string identifier, DateTime created)
        {
            Identifier = identifier;
            Created = created;
        }
        public override string ToString()
        {
            return Identifier == null ? "Guest" : string.Format("{0}-{1}", Identifier, Created.Year);
        }
    }
}