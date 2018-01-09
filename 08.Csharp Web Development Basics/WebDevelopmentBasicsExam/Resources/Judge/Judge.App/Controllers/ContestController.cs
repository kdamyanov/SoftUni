using System;
using System.Collections.Generic;
using System.Text;
using SimpleMvc.Framework.Contracts;

namespace Judge.App.Controllers
{
    public class ContestController : BaseController
    {
        public IActionResult Contest()
        {
            return this.View();
        }
    }
}
