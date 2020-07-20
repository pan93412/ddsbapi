using ddsbapi.Model;
using ddsbapi.Types;
using ddsbapi.Types.Errors;
using ddsbapi.Types.Get;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ddsbapi.Controllers
{
    /// <summary>
    /// Get the long URL of the given id.
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class GetController : ControllerBase
    {
        private readonly DDSBContext ctx;
        /// <summary>
        /// The constructor of <see cref="GetController"/>
        /// </summary>
        /// <param name="ctx">The <see cref="DDSBContext"/></param>
        public GetController(DDSBContext ctx)
        {
            this.ctx = ctx;
        }

        /// <summary>
        /// Get the long URL of the given <paramref name="linkId"/>
        /// </summary>
        /// <param name="linkId">The link ID.</param>
        /// <param name="password">The password of this link.</param>
        /// <returns>The original link.</returns>
        [HttpGet("{linkId}")]
        public ActionResult<GenericResponse<GetResponse>> GetLink(string linkId, [FromQuery] string password = null)
        {
            Link link = ctx.Link.Where(link =>
                link.LinkBrowseId == linkId
            ).FirstOrDefault();

            if (link == null)
            {
                return BadRequest(PredefinedErrors.NoSuchUrl);
            }
            else if (link.Password != password)
            {
                return BadRequest(PredefinedErrors.WrongPassword);
            }

            return new GenericResponse<GetResponse>
            {
                Data = new GetResponse
                {
                    Url = link.RedirectURL.ToString()
                }
            };
        }
    }
}
