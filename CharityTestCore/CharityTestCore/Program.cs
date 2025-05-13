using CharityTestCore.Repository.EPT;
using CharityTestCore.Repository.MBTI;
using CharityTestCore.Repository.UserManagment;
using CharityTestCore.Service.EPT;
using CharityTestCore.Service.MBTI;
using CharityTestCore.Service.UserManagment;
using Domain.DataBase;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
//builder.Services.AddDbContext<ParkerCharityContext>(options =>
//    options.UseSqlServer(connectionString));
//builder.Services.AddDatabaseDeveloperPageExceptionFilter();1111111111
builder.Services.AddDbContext<ParkerCharityContext>();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddScoped<IEPTService, EPTService>();
builder.Services.AddScoped<IEPTRepository, EPTRepository>();

builder.Services.AddScoped<IMBTIService, MBTIService>();
builder.Services.AddScoped<IMBTIRepository, MBTIRepository>();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<IQuizQuestionDiscRepository, QuizQuestionDiscRepository>();
builder.Services.AddScoped<IQuizAnswernDiscRepository, QuizAnswernDiscRepository>();
builder.Services.AddScoped<IQuizQuestionDiscService,QuizQuestionDiscService>();
builder.Services.AddScoped<IQuizAnswernDiscService,QuizAnswernDiscService>();
builder.Services.AddScoped<QuizQuestionDiscService>(); // or AddTransient, AddSingleton depending on the desired lifetime
builder.Services.AddScoped<QuizAnswernDiscService>(); // or AddTransient, AddSingleton depending on the desired lifetime

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;

}).AddCookie(options =>
{
    options.LoginPath = "/Login";
    options.LogoutPath = "/Logout";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(120); // 1month
    options.SlidingExpiration = true;
});
//builder.Services.AddDataProtection().PersistKeysToFileSystem(new DirectoryInfo(Directory.GetCurrentDirectory())).SetDefaultKeyLifetime(TimeSpan.FromDays(30));
builder.Services.AddDataProtection().PersistKeysToDbContext<ParkerCharityContext>()
          .SetDefaultKeyLifetime(TimeSpan.FromDays(90));
var app = builder.Build();
//using (var scope = app.Services.CreateScope())
//{
//    var db = scope.ServiceProvider.GetRequiredService<ParkerCharityContext>();
//    db.Database.Migrate();
//}
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithRedirects("/Error/{0}");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();


//DELETE
//FROM MBTIAnswerList 
//WHERE UserId NOT IN (SELECT Id FROM Users);