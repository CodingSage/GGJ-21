using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpeechEventSystem : MonoBehaviour
{
    public TMP_Text speech;

    public void TriggerSpeech(SpeechEvent speechEvent)
    {
        StartCoroutine(DisplayText(speechEvent, 1f));
    }

    IEnumerator DisplayText(SpeechEvent speechEvent, float delay)
    {
        string allLines = "";
        foreach (string line in speechEvent.SpeechLines())
        {
            allLines += line + "\n\n";
            speech.text = allLines;
        }
        yield return null;
    }
}
