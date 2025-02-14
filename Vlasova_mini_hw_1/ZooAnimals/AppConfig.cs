using System;
using Microsoft.Extensions.DependencyInjection;

namespace ZooAnimalsModel;

public class AppConfig
{
    private static IServiceProvider? _services;
    private static Object lockObj = new object();

    public static IServiceProvider Services {
        get {
            lock(lockObj) {
            _services ??= GetService();
            return  _services;
            }
            
        }
        
    }

    public static IServiceProvider GetService()
    {
        Console.WriteLine("Get Services........");
        var services = new ServiceCollection();
        services.AddSingleton<VeterinaryClinic>(); // Регистрация VeterinaryClinic как Singleton
        services.AddSingleton<Zoo>(); // Регистрация Zoo


        var serviceProvider = services.BuildServiceProvider(); // строим контейнер зависимостей
        return serviceProvider;

    }

}