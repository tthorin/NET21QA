// -----------------------------------------------------------------------------------------------
//  ContainerConfigure.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using Autofac;
using AutoFacPracticeApp.Interfaces;

namespace AutoFacPracticeApp;

public static class ContainerConfigure
{
    public static IContainer Config()
    {
        var builder = new ContainerBuilder();
        builder.RegisterType<Calculator>().As<ICalculator>();
        builder.RegisterType<ConsoleStringOutput>().As<IStringOutput>();
        return builder.Build();
    }
}