using System.ComponentModel.DataAnnotations;

namespace ddsbapi.Model
{
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
}
