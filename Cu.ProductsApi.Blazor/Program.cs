using Cu.ProductsApi.Blazor.Components;
using Cu.ProductsApi.Blazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//add Apiservice
builder.Services.AddScoped<IProductService, ProductService>();
//Add httpClient
builder.Services.AddHttpClient();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();