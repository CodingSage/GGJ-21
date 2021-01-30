using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechEvent
{
    public static readonly SpeechEvent START = new SpeechEvent("Where is my Momma!!?? Little Beach Baby cried. If I don’t find her soon I’ll never survive!");
    public static readonly SpeechEvent LEVEL1 = new SpeechEvent("You’re not my Momma, your swimsuit is red.", "Could she be over there? is what the lady said");
    public static readonly SpeechEvent LEVEL2 = new SpeechEvent("You’re not my Momma, you’re wearing a hat.", "Try over there, if you don’t find her come back.");
    public static readonly SpeechEvent LEVEL3 = new SpeechEvent("You’re not my Momma, your umbrella is pink.", "Why don’t you ask the lifeguard, that’s what I think");
    public static readonly SpeechEvent LEVEL4 = new SpeechEvent("You’re not my Momma, you're way to tan.", "Perhaps she’s over there, just past that man.");
    public static readonly SpeechEvent END = new SpeechEvent("I found my Momma, I’ve missed you so!", "Oh Little Beach Baby I’ll never let you go.");

    private string[] eventSpeech;

    private SpeechEvent(params string[] speech)
    {
        eventSpeech = speech;
    }

    public string[] SpeechLines()
    {
        return eventSpeech;
    }

    public static IEnumerable<SpeechEvent> Values
    {
        get
        {
            yield return START;
            yield return LEVEL1;
            yield return LEVEL2;
            yield return LEVEL3;
            yield return LEVEL4;
            yield return END;
        }
    }

    public static SpeechEvent GetSpeechEvent(string levelName)
    {
        string normalizedName = levelName.ToUpper();
        if (normalizedName == "LEVEL1") return LEVEL1;
        if (normalizedName == "LEVEL2") return LEVEL2;
        if (normalizedName == "LEVEL3") return LEVEL3;
        if (normalizedName == "LEVEL4") return LEVEL4;
        if (normalizedName == "LEVEL5") return END;
        return START;
    }

    public string Name { get; private set; }
}
