/*
    The return type of WebApplication.CreateBuilder(args) is WebApplicationBuilder.
    WebApplicationBuilder is a class provided by ASP .NET core
*/
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

/*
    The return type of builder.Build() is WebApplication.
*/
var app = builder.Build();

// this methods denotes that we will use Conventional routing
// app.MapControllerRoute(
//     name:"default",
//     pattern:"{controller=Home}/{action=index}/{id?}"
// );

// This methods denotes Attribute based routing 
app.MapControllers();

app.Run();
