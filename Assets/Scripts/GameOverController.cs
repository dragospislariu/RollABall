using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]

public class GameOverController : MonoBehaviour
{
    public void Restart()
    {

        SceneManager.LoadScene(1);
    }
}
