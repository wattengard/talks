using MyPenguins.Shared;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
var client = new HttpClient { BaseAddress = new Uri("https://api.met.no/weatherapi/locationforecast/2.0/") };
client.DefaultRequestHeaders.UserAgent.Clear();
client.DefaultRequestHeaders.UserAgent.ParseAdd("BouvetOne_Blazor101/0.1 (christian.wattengard@bouvet.no)");


app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.MapGet("/weather", async (string lat, string lon) => {

    var result = await client.GetFromJsonAsync<YrResponse>($"compact?lat={lat}&lon={lon}");
    return result;

});

app.MapFallbackToFile("index.html");
app.Run();
