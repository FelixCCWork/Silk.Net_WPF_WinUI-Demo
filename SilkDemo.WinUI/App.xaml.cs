﻿using Microsoft.UI.Xaml;

namespace SilkDemo.WinUI;

public partial class App : Application
{
    public static Window MainWindow { get; set; }

    public App()
    {
        InitializeComponent();
    }

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        MainWindow = new MainWindow();
        MainWindow.Activate();
    }
}
