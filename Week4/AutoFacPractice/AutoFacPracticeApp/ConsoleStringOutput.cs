// -----------------------------------------------------------------------------------------------
//  ConsoleOutput.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using AutoFacPracticeApp.Interfaces;

namespace AutoFacPracticeApp;

public class ConsoleStringOutput : IStringOutput
{
    public void Output(string text) => Console.WriteLine(text);
}