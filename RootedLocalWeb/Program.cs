using RootedLocalWeb.Client.Pages;
using RootedLocalWeb.Components;

var builder = WebApplication.CreateBuilder(args);
var url = "https://vapxzejwseefmokqptce.supabase.co";
var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InZhcHh6ZWp3c2VlZm1va3FwdGNlIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NzMwODkwMjEsImV4cCI6MjA4ODY2NTAyMX0.ukJ8UxDHD-5A6APdj_z5uL0WCuE9ikCU5HKhzdWuuvM";

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();
builder.Services.AddScoped(_=>new Supabase.Client(url, key));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(RootedLocalWeb.Client._Imports).Assembly);

app.Run();
