using System.Web.Http;

namespace OwinWithGoogle.AuthServer.Controllers
{
    public class ValuesController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("Hello there!");
        }
    }
}