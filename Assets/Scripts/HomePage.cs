using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomePage : MonoBehaviour
{
    private void Start()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
 
}
