using UnityEngine;
using System.Collections;

public class GoBack : MonoBehaviour
{

    // Goes back to the main menu
    public void loadMenu()
    {
        Application.LoadLevel("Menu");
    }
}