using System;
using System.Linq;
using ddsbapi.Model;
using ddsbapi.Types;
using ddsbapi.Types.Errors;
using ddsbapi.Types.Generate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        /// Get the link with same ID specified in <paramref name="request"/>
        /// </summary>
        /// <param name="request">The request from <see cref="GenerateLink"/></param>
        /// <returns>Return the link if any, otherwise <see langword="null"/>.</returns>
        protected Link GetLinkWithSameId(GenerateRequest request)
        {
            return ctx.Link.Where(
                    l =>
                        l.LinkBrowseId == request.CustomId
                ).FirstOrDefault();
        }

        /// <summary>
        /// Get the link that has been generated before.
        /// </summary>
        /// <param name="request">The request from <see cref="GenerateLink"/></param>
        /// <returns>Return the generated link if there are any, otherwise <see langword="null"/>.</returns>
        protected Link GetDuplicatedLink(GenerateRequest request)
        {
            return ctx.Link.Where(
                    l =>
                        l.RedirectURL == new Uri(request.Url) // the redirect url is same, and
                        && l.Password == request.Password // the password is same
                ).FirstOrDefault();
        }

        /// <summary>
        /// Generate a shortened url.
        /// </summary>
        /// <param name="request">The url to shorten, access password and etc.</param>
        /// <returns>The information of this shortened url</returns>
        [HttpPost]
        public ActionResult<GenericResponse<GenerateResponse>> GenerateLink([FromBody] GenerateRequest request)
        {
            Uri redirectURL;
            Link link;

            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (GetLinkWithSameId(request) != null)
            {
                return BadRequest(PredefinedErrors.IdHasBeenTaken);
            }

            try
            {
                redirectURL = new Uri(request.Url);
                link = GetDuplicatedLink(request);
            }
            catch (UriFormatException)
            {
                return BadRequest(PredefinedErrors.BadUrl);
            }

            if (link == null)
            {
                link = new Link
                {
                    LinkBrowseId = request.CustomId ?? Consts.NewShortenLink,
                    Password = request.Password ?? null,
                    RedirectURL = redirectURL,
                    Stat = new Stat()
                };

                ctx.Link.Add(link);
                ctx.SaveChanges();
            }

            return new GenericResponse<GenerateResponse>
            {
                Data = new GenerateResponse {
                    Id = link.LinkBrowseId,
                    Password = link.Password
                }
            };
        }
    }
}
