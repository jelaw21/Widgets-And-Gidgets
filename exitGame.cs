using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitGame : MonoBehaviour
{
    public AudioSource exitClick;
    public void Exit()
    {
        exitClick.Play();
        SceneManager.LoadScene(0);
    }

    public void ExitFromMenu()
    {
        exitClick.Play();
        Application.Quit();
    }
}
