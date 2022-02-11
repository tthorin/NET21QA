// -----------------------------------------------------------------------------------------------
//  Astrology.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace GroupTestPracticeApp;

public class Astrology
{   
    public string Sign(DateOnly birthDate)
    {
        Dictionary<DateOnly, string> signs = new()
        {
            {new DateOnly(birthDate.Year, 12, 22), "Stenbock"},
            {new DateOnly(birthDate.Year, 11, 23), "Skytt"},
            {new DateOnly(birthDate.Year, 10, 24), "Skorpion"},
            {new DateOnly(birthDate.Year, 9, 23), "Våg"},
            {new DateOnly(birthDate.Year, 8, 24), "Jungfru"},
            {new DateOnly(birthDate.Year, 7, 23), "Lejon"},
            {new DateOnly(birthDate.Year, 6, 22), "Kräfta"},
            {new DateOnly(birthDate.Year, 5, 22), "Tvilling"},
            {new DateOnly(birthDate.Year, 4, 21), "Oxe"},
            {new DateOnly(birthDate.Year, 3, 21), "Vädur"},
            {new DateOnly(birthDate.Year, 2, 19), "Fisk"},
            {new DateOnly(birthDate.Year, 1, 21), "Vattuman"},
            {new DateOnly(birthDate.Year, 1, 1), "Stenbock"}
        };
        var sign = signs.FirstOrDefault(x => birthDate >= x.Key);
        return sign.Value;
    }

    public string ChineseYear(DateOnly birthDay)
    {
        var diff = birthDay.Year - 2020;
        if (birthDay.Month == 1) diff--;
        while (diff is > 12 or < 0)
        {
            diff = diff < 0 ? diff + 12 : diff - 12;
        }

        return $"{(ChineseSigns) diff}";
    }

}

internal enum ChineseSigns
{
    Råtta,
    Buffel,
    Tiger,
    Katt,
    Drake,
    Orm,
    Häst,
    Get,
    Apa,
    Tupp,
    Hund,
    Gris
}