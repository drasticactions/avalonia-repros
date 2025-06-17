// <copyright file="Main.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using Avalonia;
using AvaloniaRepros;

internal static class Program
{
    internal static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .LogToTrace();
    internal static int Main(string[] args) =>
        BuildAvaloniaApp()
            .UseAvaloniaNative()
            .UseSkia()
            .StartWithClassicDesktopLifetime(args);
}
