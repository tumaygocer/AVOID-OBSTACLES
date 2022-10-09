using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveControl : MonoBehaviour
{
    Animator anim;
    public GameObject character;
    bool beginRun;
    public GameObject gameOverPanel;

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
    }
}
