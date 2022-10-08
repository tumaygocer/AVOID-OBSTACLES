using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LedgeGenerate : MonoBehaviour
{

    public GameObject[] ledge;
    public int ledgeNum;
    public int ledgePos = 10;
    public bool creatingLedge = false;
    public GameObject cauntDownText;
    public GameObject panel;
    public GameObject characterFile;


    void Start()
    {
        StartCoroutine(Begin());
    }

    void Update()
    {
        if (creatingLedge == false)
        {
            creatingLedge = true;
            StartCoroutine(GenerateLedge());
        } 
    }

    IEnumerator GenerateLedge()
    {
        ledgeNum = Random.Range(0, 7);
        Instantiate(ledge[ledgeNum], new Vector3(0, 0, ledgePos), Quaternion.identity);
        ledgePos += 1;
        Instantiate(ledge[0], new Vector3(0, 0, ledgePos), Quaternion.identity);
        ledgePos += 1;
        yield return new WaitForSeconds(0.5f);
        creatingLedge = false;
    }

    IEnumerator Begin()
    {
        panel.SetActive(true);
        cauntDownText.SetActive(true);
        yield return new WaitForSeconds(1);
        cauntDownText.GetComponent<TextMeshProUGUI>().text = "2";
        yield return new WaitForSeconds(1);
        cauntDownText.GetComponent<TextMeshProUGUI>().text = "1";
        yield return new WaitForSeconds(1);
        cauntDownText.SetActive(false);
        panel.SetActive(false);
        characterFile.GetComponentInChildren<moveControl>().enabled = true;
        cauntDownText.GetComponent<TextMeshProUGUI>().text = "3";
    }
}
