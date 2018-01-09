using System;
using System.Collections.Generic;
using System.Text;
using SimpleMvc.Framework.Contracts;

namespace Judge.App.Controllers
{
    class SubmissionController : BaseController

    {
        public IActionResult Submission()
        {
            return this.View();
        }
    }
}
