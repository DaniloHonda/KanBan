using KanBan.Data;
using KanBan.Services.Atividade;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

// entrando no appsettings e pegando o connection string
builder.Services.AddDbContext<AppDbContext>
    (options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// faz ligacao para que interface saiba onde estao seus metodos
builder.Services.AddScoped<IAtividadeInterface, AtividadeService>(); 

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
    pattern: "{controller=Atividade}/{action=Index}/{id?}");

app.Run();
