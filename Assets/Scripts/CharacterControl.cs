using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    Animator anim;
    public float moveSpeed = 1.5f;
    bool beginRun;

    void Start()
    {
        anim = GetComponent<Animator>();
        beginRun = true;
    }

    
    void Update()
    {
        if (beginRun == true)
        {
            anim.SetBool("Run", true);
        }
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);  
    }
}
