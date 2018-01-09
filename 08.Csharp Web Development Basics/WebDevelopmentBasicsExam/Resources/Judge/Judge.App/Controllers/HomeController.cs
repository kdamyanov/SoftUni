namespace Judge.App.Controllers
{
    using SimpleMvc.Framework.Contracts;

    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            this.ViewModel["guestDisplay"] = "block";
            this.ViewModel["authenticated"] = "none";
            this.ViewModel["admin"] = "none";

            if (this.User.IsAuthenticated)
            {
                this.ViewModel["guestDisplay"] = "none";
                this.ViewModel["authenticated"] = "flex";
            }

            return this.View();
        }


    }
}
