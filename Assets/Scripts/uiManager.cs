using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uiManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene("Level1");
    }

    public void EndOne()
    {
        SceneManager.LoadScene("Level2");
    }

    public void EndTwo()
    {
        SceneManager.LoadScene("Level3");
    }

    public void EndThree()
    {
        SceneManager.LoadScene("Level4");
    }

    public void EndFour()
    {
        SceneManager.LoadScene("Level5");
    }

    public void EndFive()
    {
        SceneManager.LoadScene("DaveMenu");
    }
}
