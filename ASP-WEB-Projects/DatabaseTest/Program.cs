using DatabaseTest.Models;

// create new blog posts
using (var context = new BlogDataContext())
{
    var john = new Author { Name = "John T. Author", Email = "john@example.com" };
    context.Authors.Add(john);

    var jane = new Author { Name = "Jane Q. Hacker", Email = "jane@example.com" };
    context.Authors.Add(jane);

    var post = new Post { Title = "Hello World", Content = "I wrote an app using EF Core!", Author = jane };
    context.Posts.Add(post);
    post = new Post { Title = "How to use EF Core", Content = "It's pretty easy", Author = john };
    context.Posts.Add(post);

    context.SaveChanges();
}

// query the blog posts, using a join between the two tables
// using (var context = new BlogDataContext())
// {
//     var posts = context.Posts
//         .Include(p => p.Author)
//         .ToList();

//     foreach (var post in posts)
//     {
//         Console.WriteLine($"{post.Title} by {post.Author.Name}");
//     }
// }




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// var provider = builder.Services.BuildServiceProvider();
// var config = provider.GetRequiredService<IConfiguration>();
// builder.Services.AddDbContext<StudentDBContext>(items =>items.)
// builder.Services.AddMySqlDataSource(builder.Configuration.GetConnectionString("Default")!);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
