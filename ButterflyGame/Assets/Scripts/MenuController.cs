using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartButton()
    {
        Debug.Log("Going");
        SceneManager.LoadScene("TestColour");
    }

    public void ExitButton()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
