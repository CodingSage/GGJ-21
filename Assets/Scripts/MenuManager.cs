using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void LoadFirstLevel()
    {
        int menuID = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(menuID + 1);
    }
}
