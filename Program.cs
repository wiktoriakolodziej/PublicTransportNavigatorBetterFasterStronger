using PublicTransportNavigatorv2;

var builder = WebApplication.CreateBuilder(args);

builder.RegisterServices();

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
