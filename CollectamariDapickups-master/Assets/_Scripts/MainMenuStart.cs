using UnityEngine;
using System.Collections;

public class MainMenuStart : MonoBehaviour
{
    // load the game upon click
    public void loadMain()
    {
        Application.LoadLevel("Main");
    }
}