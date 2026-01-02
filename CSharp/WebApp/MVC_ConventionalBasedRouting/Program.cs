namespace MVC_ConventionalBasedRouting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

        //app.MapGet("/", () => "Hello World!");

        //app.MapControllerRoute(
        //    name: "Home",
        //    pattern: "{controller=Home}/{action=Index}"
        //    );

        //app.MapControllerRoute(
        //    name: "Contact",
        //    pattern: "{controller=Home}/{action=Contact}"
        //    );

        //app.MapControllerRoute(
        //    name: "Support",
        //    pattern: "{controller=Home}/{action=Support}"
        //    );

        //app.MapControllerRoute(
        //    name: "About",
        //    pattern: "{controller=Home}/{action=About}"
        //    );


            //http://localhost:38202/Home/GetName?name=Gana%20Sir //%20 is set automatically when we add space in string
            app.MapControllerRoute(
                name: "GetName",
                pattern: "{controller=Home}/{action=GetName}/{name?}" //when we use ?, then this field is not manadatory
                );



            //instead of writing more stuff in app.MapControllerRoute() use app.MapDefaultControllerRoute();
            //app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
