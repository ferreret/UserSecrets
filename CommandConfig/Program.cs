using Microsoft.Extensions.Configuration;

IConfigurationBuilder builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true) // El orden de estas dos últimas intrucciones 
    .AddUserSecrets(typeof(Program).Assembly, optional: true);             // define el orden donde irá a buscar las configuraciones

IConfigurationRoot config = builder.Build();

Console.WriteLine("Hello, World!");
Console.WriteLine("I think that the password is: " + config["Password"]);