using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class moveControl : MonoBehaviour
{
    Animator anim;
    public GameObject character;
    bool beginRun;
    public GameObject gameOverPanel;
    public GameObject scorPanel;
    public int scor = 0;

    void Start()
    {
        anim = character.GetComponent<Animator>();
        beginRun = true;
        
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
        if (beginRun == true)
        {
            anim.SetBool("Run", true);

        }
      

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("barrier"))
        {
            anim.SetBool("Run", false);
            anim.SetBool("gameover", true);
            gameOverPanel.SetActive(true);
        }

        if (other.CompareTag("Scor"))
        {
            scor += 1;
            scorPanel.GetComponent<TextMeshProUGUI>().text = "SCOR " + scor;
        }
    }
}
