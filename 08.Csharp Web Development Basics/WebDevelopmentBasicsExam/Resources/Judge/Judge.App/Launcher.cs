namespace Judge.App
{
    using Microsoft.EntityFrameworkCore;
    using SimpleMvc.Framework;
    using SimpleMvc.Framework.Routers;
    using Data;
    using Infrastructure;
    using Infrastructure.Mapping;

    public class Launcher
    {
        static Launcher()
        {
            using (var db = new JudgeDbContext())
            {
                db.Database.Migrate();
            }

            AutoMapperConfiguration.Initialize();
        }

        public static void Main()
            => MvcEngine.Run(new WebServer.WebServer(
                1337,
                DependencyControllerRouter.Get(),
                new ResourceRouter()));
    }
}
