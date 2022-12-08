using OldPhonePadLibrary.Constants;

namespace OldPhonePadLibrary;
public static class KeyMap
{

    private readonly static Dictionary<char, List<char>> KeyMapping = new()
    {
        {Key.ONE,new List<char>(){'&','\'','(' } },
        {Key.TWO,new List<char>(){'A','B','C' } },
        {Key.THREE,new List<char>(){'D','E','F' } },
        {Key.FOUR,new List<char>(){'G','H','I' } },
        {Key.FIVE,new List<char>(){'J','K','L' } },
        {Key.SIX,new List<char>(){'M','N','O' } },
        {Key.SEVEN,new List<char>(){'P','Q','R','S' } },
        {Key.EIGHT,new List<char>(){'T','U', 'V' } },
        {Key.NINE,new List<char>(){'W','X','Y','Z' } },
    };

    public static string GetCharFromKeys(char key, int numberOfTimesPressed)
    {
        if (key == Key.SPACE)
            return String.Empty;
        if (!KeyMapping.ContainsKey(key))
            throw new ArgumentException(ExceptionMessage.INVALID_KEY);
        var keyIndex = numberOfTimesPressed - 1;
        keyIndex %= KeyMapping[key].Count;
        var mappings = KeyMapping[key];
        return mappings[keyIndex].ToString();
    }
}
