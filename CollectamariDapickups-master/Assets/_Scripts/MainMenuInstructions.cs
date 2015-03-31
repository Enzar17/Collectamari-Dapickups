using UnityEngine;
using System.Collections;

public class MainMenuInstructions : MonoBehaviour {

	// on click, opens the instructions
    public void loadInstructions()
    {
        Application.LoadLevel("Instructions");
    }
    
}
