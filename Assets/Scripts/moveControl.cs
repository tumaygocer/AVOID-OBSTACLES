using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
