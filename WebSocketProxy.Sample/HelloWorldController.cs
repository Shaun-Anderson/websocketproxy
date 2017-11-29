using Nancy;

namespace WebSocketProxy.Sample
{
    public class HelloWorldController : NancyModule
    {
        public HelloWorldController()
        {
			Get("/", (parameters) =>
			{
				return View["index.html"];
			});

		}
	}
}