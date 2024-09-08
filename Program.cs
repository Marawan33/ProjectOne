namespace MVCDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            var app = builder.Build();
            app.UseRouting();
            #region MyRegion
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("You are At Home Page");
            //    }
            //    );





            //    endpoints.MapGet("/products/{ID:int?}", async context =>
            //    {
            //        var id = context.Request.RouteValues["ID"];
            //        if (id == null)
            //        {
            //            await context.Response.WriteAsync("You Are At Products Page");

            //        }
            //        else
            //        {

            //            await context.Response.WriteAsync($"You Are At Products Page ID = {id}");

            //        }
            //    }
            //    );








            //    endpoints.MapGet("/Books/{ID}/{Author}", async context =>
            //    {
            //        int id = Convert.ToInt32(context.Request.RouteValues["ID"]);
            //        string name = context.Request.RouteValues["Author"].ToString();
            //        await context.Response.WriteAsync($"You Are At Books Page Book ID = {id} , Author name is : {name}");
            //    }
            //    );
            //}); 
            #endregion

            // app.MapGet("/", () => "Hello World!");

            //app.Run(async(HttpContext) => { await HttpContext.Response.WriteAsync("Your Requested Page Is Not Available"); });

            app.MapControllerRoute(
                name: "default",
                pattern: "/{Controller = Home}/{Action = Index}",
                defaults: new { Controller = "Home", Action = "Index" }
                );

            app.Run();
        }
    }
}
