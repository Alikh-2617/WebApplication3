var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();


// s�tt Sessen till varje Sessen in loggad
builder.Services.AddSession(options =>
{   // tiden f�r Sessen aktiv 
    options.IdleTimeout = TimeSpan.FromMinutes(15);
});

//-------------------------------------------------------------------------------------

var app = builder.Build();

app.UseSession();  // l�ggs till Sessen till n�r appen buildas 
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(name: "feverCheck",   // namnet som skrevs i url
                       pattern: "feverCheck", // plats till url allts� direckt efter domain namn
                       defaults: new { controller = "Doctor", action = "FeverCheck" }); // platsen (pattern) till den aktion

//--------------------------------------------------------------------------------------
app.MapControllerRoute(name:"checkage" ,   // namnet som skrevs i url
                       pattern:"checkage", // plats till url allts� direckt efter domain namn
                       defaults: new {controller = "Check" , action = "CheckAge"}); // platsen (pattern) till den aktion


app.MapControllerRoute(name: "default", 
                       pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
