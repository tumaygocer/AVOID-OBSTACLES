using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject runner;
    Vector3 distance;

    void Start()
    {
        distance = transform.position - runner.transform.position;
    }

    
    void Update()
    {
        transform.position = runner.transform.position + distance;
    }
}
