namespace ddsbapi.Model
{
    /// <summary>
    /// The statistics of a shorten URL.
    /// </summary>
    public class Stat
    {
        /// <summary>
        /// The unique ID in table.
        /// </summary>
        public int StatId { get; set; }
        /// <summary>
        /// How many visitors visited this link?
        /// </summary>
        public int Visitors { get; set; }

        /// <summary>
        /// The ID assocated the <see cref="Link"/>.
        /// </summary>
        public int LinkId { get; set; }
        /// <summary>
        /// The assocated <see cref="Link"/>.
        /// </summary>
        public Link Link { get; set; }
    }
}
