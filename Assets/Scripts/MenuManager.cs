using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject controlPanel;

    private void Start()
    {
        HideControlPanel();
    }

    public void LoadFirstLevel(){
         int menuID = SceneManager.GetActiveScene().buildIndex;


         SceneManager.LoadScene(menuID + 1);
        }

    public void ShowControlPanel()
    {
        controlPanel.SetActive(true);
    }

    public void HideControlPanel()
    {
        controlPanel.SetActive(false);
    }
    
}
