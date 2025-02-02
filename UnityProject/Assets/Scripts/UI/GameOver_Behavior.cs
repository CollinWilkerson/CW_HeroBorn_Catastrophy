using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver_Behavior : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void Reset()
    {
        SceneManager.LoadScene("Level1");
        Debug.Log("Geturn to game scene");
    }

    public void Quit()
    {
        SceneManager.LoadScene("Title");
        Debug.Log("Game Quit");
    }
}
