using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("MentalAsylumPOC1");
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT DAMN YOU!");
        Application.Quit();
    }
}
