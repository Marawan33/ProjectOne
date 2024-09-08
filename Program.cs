namespace MVCDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Home", async context =>
                {
                    await context.Response.WriteAsync("You are At Home Page");
                }
                );
                endpoints.MapGet("/products", async context =>
                {
                    await context.Response.WriteAsync("You Are At Products Page");
                }
                );
            });

            // app.MapGet("/", () => "Hello World!");

            app.Run(async(HttpContext) => { await HttpContext.Response.WriteAsync("Your Requested Page Is Not Available"); });

            app.Run();
        }
    }
}
