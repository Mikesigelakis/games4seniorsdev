using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGamesScript : MonoBehaviour {

    public void loadGame (string name) {
        SceneManager.LoadScene (name);
    }

    public void ExitGame () {
        Application.Quit ();
    }

}