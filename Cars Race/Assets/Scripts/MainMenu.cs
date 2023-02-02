using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        //Loads the Scene 01 on clicking "Pkay in the menu"
        SceneManager.LoadScene("Scene01");
    }
}
