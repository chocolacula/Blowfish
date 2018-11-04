using System;
using System.Linq;

public static class RandomString
{
    [Flags]
    public enum Chars : byte
    {
        All      = 255,
        Numbers  = 1,
        Symbols  = 2,
        English  = 4,
        Chinese  = 8,
        Cyrillic = 16
    }
    
    private const string NUMBERS  = "0123456789";
    private const string SYMBOLS  = "!?@#$%^&*() _+-=[]{},;.:/|\\<>~`\"'";
    private const string ENGLISH  = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string CHINESE  = "電買車紅無東馬風時鳥語頭魚園長島愛紙書見假佛德拜黑冰兔妒每壤步巢惠鞋莓圓聽實證龍賣龜藝戰繩關鐵圖團轉廣惡豐腦雜壓雞價樂氣廳發勞劍歲權燒贊兩譯觀營處齒驛櫻產藥讀畫顏聲學體點麥蟲舊會萬盜寶國醫雙晝觸來黃區";
    private const string CYRILLIC = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
    
    private static Random random = new Random();

    public static string Generate(int length, Chars chars)
    {
        string source = "";

        if ((chars & Chars.Numbers) == Chars.Numbers)
            source += NUMBERS;
        if ((chars & Chars.Symbols) == Chars.Symbols)
            source += SYMBOLS;
        if ((chars & Chars.English) == Chars.English)
            source += ENGLISH;
        if ((chars & Chars.Chinese) == Chars.Chinese)
            source += CHINESE;
        if ((chars & Chars.Cyrillic) == Chars.Cyrillic)
            source += CYRILLIC;
        
        return new string(Enumerable.Repeat(source, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}
