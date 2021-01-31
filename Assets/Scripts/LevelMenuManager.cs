using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelMenuManager : MonoBehaviour
{
    public GameObject levelMenuPanel;
    public GameObject nextLevelButton;
    public Text levelOverText;

    void Start()
    {
        if (levelOverText == null || nextLevelButton == null || levelMenuPanel == null)
        {
            throw new MissingComponentException("Level Menu Manager is missing components");
        }
        HideLevelMenu();
    }

    public void ShowLevelMenu(bool win)
    {
        levelMenuPanel.SetActive(true);
        nextLevelButton.SetActive(win);
        levelOverText.text = win ? "Go Find Momma!" : "Oh no! Try again!";
    }

    public void HideLevelMenu()
    {
        levelMenuPanel.SetActive(false);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
