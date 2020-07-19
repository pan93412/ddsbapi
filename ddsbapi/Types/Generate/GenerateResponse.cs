using System.Reflection.Emit;

namespace ddsbapi.Types.Generate
{
    /// <summary>
    /// The response of <c>/generate</c>.
    /// </summary>
    public class GenerateResponse
    {
        /// <summary>
        /// The ID of this shortened URL.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The password of this dd.sb URL.
        /// </summary>
        public string Password { get; set; }
    }
}
