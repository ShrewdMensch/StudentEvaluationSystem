using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace StudentEvaluationSystem.Extension
{
    public class SessionTimeOutAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.HttpContext.Session.Keys.ToList().Count == 0)
                context.Result = new RedirectToActionResult("Index", "Home", new {area ="Public" });
            base.OnActionExecuted(context);
        }
    }
}
