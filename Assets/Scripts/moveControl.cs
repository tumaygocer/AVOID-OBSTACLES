using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class moveControl : MonoBehaviour
{
  
    public GameObject character;
    
    public GameObject gameOverPanel;
    public GameObject scorPanel;
    public int scor = 0;

    void Start()
    {
       
       
        
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void HomePage()
    {
        SceneManager.LoadScene(0);
    }

    void Update()
    {
        

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("barrier"))
        {
           
            gameOverPanel.SetActive(true);
        }

        if (other.CompareTag("Scor"))
        {
            scor += 1;
            scorPanel.GetComponent<TextMeshProUGUI>().text = "SCOR " + scor;
        }
    }
}
