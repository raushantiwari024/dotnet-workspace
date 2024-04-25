// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

// // this is a custom middleware 
// /*
// When creating middleware with
// app.Run(callback) method will create only one 

// To make multiple middleware app.Use(callback ) method is used
// */
// // app.Run(async (test) => {
// //      // test is a object of HttpContext 
// //    await test.Response.WriteAsync("Async test");
//     // Test.response is a object of HttpResponse class

// // });

// // app.Run(async (test) => {
// //     await test.Response.WriteAsync("Async test 2");
// // });

// app.Use(async (context,next)=>{
//     await context.Response.WriteAsync("use method");

//     await next.Invoke();
// });

// app.Run(async (test) => {
//     await test.Response.WriteAsync("Async test 2");
// });

// app.Run();

var context = WebApplication.CreateBuilder(args);
context.Services.AddControllersWithViews();
var app = context.Build();



// app.Run(async (context)=>{
//     await context.Response.WriteAsync("Middleware using run method");
// });

// app.Use(async (context,next)=>{
//     await context.Response.WriteAsync("Using Use() Method");

//     await next.Invoke();
// });

// app.MapDefaultControllerRoute();

app.MapControllerRoute(
name:"default",
pattern : "{controller=Home}/{action=Index}/{id?}"
);


app.Run();