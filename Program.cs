using PublicTransportNavigatorv2;

var builder = WebApplication.CreateBuilder(args);

try
{
    builder.RegisterServices();
}
catch(Exception ex)
{
    Console.WriteLine($"Error during service registration: {ex.Message}");
    return;
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); //Forces requests to switch from HTTP to HTTPS for security.

app.UseAuthorization();

app.MapControllers();

app.Run();
