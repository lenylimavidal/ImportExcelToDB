﻿using Microsoft.Extensions.Configuration;
using System.Windows;

namespace WPF;
/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public static IConfiguration Config { get; private set; }

    public App()
    {
        Config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        //var builder = new ContainerBuilder();
        //var container = builder.Build();
        //builder.RegisterInfrastructureServices(Config);
    }
}

