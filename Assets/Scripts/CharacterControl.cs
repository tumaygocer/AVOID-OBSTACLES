using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    Animator anim;
    public float moveSpeed = 1.5f;

    void Start()
    {
        anim = GetComponent<Animator>(); 
    }

    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);  
    }
}
