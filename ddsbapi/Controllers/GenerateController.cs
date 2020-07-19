using System;
using System.Collections.Generic;
using ddsbapi.Model;
using ddsbapi.Types;
using ddsbapi.Types.Errors;
using ddsbapi.Types.Generate;
using Microsoft.AspNetCore.Mvc;

namespace ddsbapi.Controllers
{
    /// <summary>
    /// A controller that designed for
    /// generating a shortened url.
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class GenerateController : ControllerBase
    {
        private readonly DDSBContext ctx;
        /// <summary>
        /// The constructor of <see cref="GenerateController"/>
        /// </summary>
        /// <param name="ctx">The <see cref="DDSBContext"/></param>
        public GenerateController(DDSBContext ctx)
        {
            this.ctx = ctx;
        }

        /// <summary>
        /// Generate a shortened url.
        /// </summary>
        /// <param name="request">The url to shorten, access password and etc.</param>
        /// <returns>#TODO, the information of this shortened url</returns>
        [HttpPost]
        public ActionResult<GenericResponse<Link>> GenerateLink([FromBody] GenerateRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            Link link = new Link
            {
                LinkBrowseId = request.CustomId ?? Consts.NewShortenLink,
                Password = request.Password ?? null,
                Stat = new Stat()
            };
            try
            {
                link.RedirectURL = new Uri(request.Url);
            }
            catch (UriFormatException)
            {
                return BadRequest(PredefinedErrors.BadUrl);
            }

            ctx.Link.Add(link);
            ctx.SaveChanges();

            return new GenericResponse<Link>
            {
                Data = link
            };
        }
    }
}
