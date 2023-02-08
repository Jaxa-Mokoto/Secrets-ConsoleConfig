using Microsoft.Extensions.Configuration;

IConfigurationBuilder builder = new ConfigurationBuilder()
    //specify default path
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddUserSecrets(typeof(Program).Assembly, optional: true)
    //add a .json file - configuration source and providers
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

// create a config item
IConfigurationRoot config = builder.Build();

Console.WriteLine("I think the password is..."+ config["Password"]);
