
using AnimeX.BusinnessLayer.Abstract;
using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Abstract;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;

using AnimeX.UI.Models;
using EntityLayer;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>(
    opt =>
    {
        opt.Password.RequireNonAlphanumeric = false;
        opt.Password.RequiredLength = 1;
        opt.Password.RequireUppercase = false;
        opt.Password.RequireLowercase = false;
        opt.Password.RequireDigit = false;
        
        // opt.SignIn.RequireConfirmedEmail = true;//mail doðrulamasý olsun mu

    }
    )
    .AddErrorDescriber<CustomerIdentityValidation>()
    .AddEntityFrameworkStores<Context>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
               .AddCookie(x =>
               {
                   x.LoginPath = "/Account/login";

               });

builder.Services.AddScoped<Context>();
builder.Services.AddScoped<IAnimelerDal,efAnimelerRepository>();
builder.Services.AddScoped<IAnimelerService,AnimelerManager>();

builder.Services.AddScoped<ICategoriesService,CategoriesManager>();
builder.Services.AddScoped<ICategoriesDal, efCatagoriesRepository>();


builder.Services.AddScoped<ICategoryAnimeDal, efCategoryAnimeRepository>();
builder.Services.AddScoped<ICategoryAnimeService, CategoryAnimeManeger>();

builder.Services.AddScoped<ICommentDal, efCommentRepository>();
builder.Services.AddScoped<ICommentService, CommentManager>();

builder.Services.AddScoped<IUserFavoriDal, efUserFavoriRepository>();
builder.Services.AddScoped<IUserFavoriService, UserFavoriManager>();

builder.Services.AddScoped<IAnimeBolumsDal, efAnimeBolumsRepository>();
builder.Services.AddScoped<IAnimeBolumsService, AnimeBolumsManager>();

builder.Services.AddScoped<IAnimeBolumsService, AnimeBolumsManager>();
builder.Services.AddScoped<IAnimeBolumsService, AnimeBolumsManager>();







var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Privacy");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
