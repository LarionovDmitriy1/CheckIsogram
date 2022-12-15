using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIsogram;

public class TheWorkOfCheckingTheIsogram
{
    public static string CheckingIsogramOrNot(string enter)
    {
        if (!String.IsNullOrEmpty(enter))
        {
            if (CheckLetter(enter))
            {
                for (int i = 0; i < enter.Length; i++)
                {
                    int count = 0;
                    for (int j = 0; j < enter.Length; j++)
                    {
                        if (enter[i] == enter[j])
                        {
                            count++;
                            if (count > 1)
                            {
                                return "Слово не изограмма";
                            }
                        }
                    }
                }
                return "Слово изограмма";
            }
            else
            {
                return "Введите корректное значение";
            }
        }
        else
        {
            return "Строка пуста";
        }
    }
    private static bool CheckLetter(string word)
    {
        foreach (char letter in word)
        {
            if (Char.IsLetter(letter))
            {
                return true;
            }
        }
        return false;
    }
}
