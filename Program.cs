
var builder = WebApplication.CreateBuilder(args);

// Habilita os Controllers e as Views do MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura o tratamento de erros
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Configura a rota padrão
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
