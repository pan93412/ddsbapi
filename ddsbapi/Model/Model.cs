using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ddsbapi.Model
{
    /// <summary>
    /// The model for dd.sb API
    /// </summary>
    public class DDSBContext : DbContext
    {
        /// <summary>
        /// The storage for the shorten URLs.
        /// </summary>
        public DbSet<Link> Link { get; set; }
        /// <summary>
        /// The storage for the statistics of shorten URLs.
        /// </summary>
        public DbSet<Stat> Stat { get; set; }
        /// <inheritdoc/>
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=blogging.db");
    }

    /// <summary>
    /// The storage for the shorten URLs.
    /// </summary>
    public class Link
    {
        /// <summary>
        /// The unique ID in table.
        /// </summary>
        [Key]
        public int LinkId { get; set; }
        /// <summary>
        /// The unique ID pointed to the redirect URL.
        /// </summary>
        public string LinkBrowseId { get; set; }
        /// <summary>
        /// The URL to redirect to.
        /// </summary>
        [Required]
        public System.Uri RedirectURL { get; set; }
        /// <summary>
        /// The password of the shorten URL,
        /// hashed with bcrypt.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// The statistics of this URL.
        /// </summary>
        public Stat Stat { get; set; }
    }

    /// <summary>
    /// The statistics of a shorten URL.
    /// </summary>
    public class Stat
    {
        /// <summary>
        /// The unique ID in table.
        /// </summary>
        public int StatsId { get; set; }
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
