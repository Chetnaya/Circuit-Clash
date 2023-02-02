using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AboutPage : MonoBehaviour
{
    public void Back()
    {
        //Loads the Scene 01 on clicking "Pkay in the menu"
        SceneManager.LoadScene("MainMenu");
    }
}
