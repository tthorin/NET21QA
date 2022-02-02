// See https://aka.ms/new-console-template for more information

using Autofac;
using AutoFacPracticeApp;
using AutoFacPracticeApp.Interfaces;

Console.WriteLine("Hello, World!");
var container = ContainerConfigure.Config();
using var scope = container.BeginLifetimeScope();
var calc = scope.Resolve<ICalculator>();
calc.Add(2, 3);