using Nancy;
using Counter.Objects;

namespace Counter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get ["/"] = _ => View ["index.cshtml"];

      Post ["/counted"] = _ =>
      {
        RepeatCounter newCounter = new RepeatCounter(Request.Form["start-sentence"], Request.Form["start-search"]);
        return View["counted.cshtml", newCounter];
      };
    }
  }
}
