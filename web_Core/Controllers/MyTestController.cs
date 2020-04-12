using Amazon.Runtime.Internal;
using Microsoft.AspNetCore.Mvc;

namespace web_Core.Controllers
{
    public class MyTestController : Controller
    {
        public void Execute(RequestContext requestContext)
        {
          //  string ip = requestContext.ht  //HttpContext.Request.UserHostAddress;
          //  var response = requestContext.HttpContext.Response;
          //  response.Write("<h2>Ваш IP-адрес: " + ip + "</h2>");
        }
    }
}
