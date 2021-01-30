using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpeechEventSystem))]
public class GameController : MonoBehaviour
{
	public GameObject player;
	public GoalTrigger goal;
    
    private SpeechEventSystem speechSystem;

    void Start() 
    {
        if (goal == null || player == null)
        {
            throw new MissingComponentException("Game controller components missing");
        }
        speechSystem = GetComponent<SpeechEventSystem>();
    }

    private void Update()
    {
        if (goal.GoalReached())
        {
            speechSystem.TriggerSpeech(SpeechEvent.LEVEL1);
        }
    }
}
