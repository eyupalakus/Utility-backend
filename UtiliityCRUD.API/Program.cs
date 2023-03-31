var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();
app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseRouting();
app.UseEndpoints(endpoints =>endpoints.MapControllers());
app.MapGet("/", () => "Hello World!");

app.Run();
