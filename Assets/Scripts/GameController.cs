﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(SpeechEventSystem))]
[RequireComponent(typeof(LevelMenuManager))]
public class GameController : MonoBehaviour
{
	public GameObject player;
	public GoalTrigger goal;
    
    private SpeechEventSystem speechSystem;
    private LevelMenuManager menuManager;
    private Destructible playerDestructible;
    private string levelName;

    private bool startEventTriggered = false;

    void Start() 
    {
        if (goal == null || player == null)
        {
            throw new MissingComponentException("Game controller components missing");
        }
        speechSystem = GetComponent<SpeechEventSystem>();
        menuManager = GetComponent<LevelMenuManager>();
        menuManager.HideLevelMenu();
        playerDestructible = player.GetComponent<Destructible>();
        levelName = SceneManager.GetActiveScene().name;

        if (!startEventTriggered && levelName.ToUpper() == "LEVEL1")
        {
            startEventTriggered = true;
            StartCoroutine(StartGameEvent(5f));
        }
    }

    private void Update()
    {
        if (goal.GoalReached())
        {
            StartCoroutine(WinLevel(1f));
        }

        if (playerDestructible.isDown())
        {
            RestartLevel();
        }
    }

    IEnumerator WinLevel(float delay)
    {
        speechSystem.TriggerSpeech(SpeechEvent.GetSpeechEvent(levelName));
        yield return new WaitForSeconds(delay);
        menuManager.ShowLevelMenu();
        yield return null;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator StartGameEvent(float delay)
    {
        speechSystem.TriggerSpeech(SpeechEvent.START);
        yield return new WaitForSeconds(delay);
        speechSystem.TriggerSpeech(SpeechEvent.NO_EVENT);
        yield return null;

    }
}
