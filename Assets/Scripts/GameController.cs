using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(SpeechEventSystem))]
public class GameController : MonoBehaviour
{
	public GameObject player;
	public GoalTrigger goal;
    
    private SpeechEventSystem speechSystem;
    private string levelName;

    void Start() 
    {
        if (goal == null || player == null)
        {
            throw new MissingComponentException("Game controller components missing");
        }
        speechSystem = GetComponent<SpeechEventSystem>();
        levelName = SceneManager.GetActiveScene().name;
    }

    private void Update()
    {
        if (goal.GoalReached())
        {
            speechSystem.TriggerSpeech(SpeechEvent.GetSpeechEvent(levelName));
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
