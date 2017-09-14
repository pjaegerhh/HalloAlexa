using System.Web.Http;

namespace HalloAlexa.Controllers
{
    public class AlexaController : ApiController
    {
        [HttpPost, Route("api/alexa/demo")]
        public dynamic HelloWorld(dynamic request)
        {
            return new
            {
                version = "1.0",
                sessionAttributes = new { },
                response = new
                {
                    outputSpeech = new
                    {
                        type = "PlainText",
                        text = "Hello World"
                    },
                    card = new
                    {
                        type = "Simple",
                        title = "HelloWorld",
                        content = "Hello fine new Voice world !"
                    },
                    shouldEndSession = true
                }
            };
        }
    }
}
