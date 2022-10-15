using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class XCamControl : MonoBehaviour
{  
    bool right;
    bool left;   
    bool speedControl;
    Rigidbody rd;
    public GameObject GameOverPanel;
    int Scor;
    public GameObject scorPanel;
    [SerializeField] float speed;
    public AudioSource scorSound;
     

    private void Start()
    {
        Scor = 0;
        speedControl = true;
        rd = GetComponent<Rigidbody>();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AnaSayfa()
    {
        SceneManager.LoadScene(0);
    }

    private void Update()
    {

        if (speedControl == true)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
       
        
        if (Input.touchCount == 0) return;
        HandleInput();
    }

    private void HandleInput()
    {
        Vector3 go_right = new Vector3(1, transform.position.y, transform.position.z);
        Vector3 go_left = new Vector3(-1, transform.position.y, transform.position.z);
        Touch finger = Input.GetTouch(0);

        if (finger.deltaPosition.x > 60.0f)
        {
            right = true;
            left = false;
        }

        if (finger.deltaPosition.x < -60.0f)
        {
            right = false;
            left = true;
        }

        if (right == true)
        {
            transform.position = Vector3.Lerp(transform.position, go_right, 4 * Time.deltaTime);
        }

        if (left == true)
        {
            transform.position = Vector3.Lerp(transform.position, go_left, 4 * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("barrier"))
        {
            GameOverPanel.SetActive(true);
            speedControl = false;           
        }

        if (collision.gameObject.CompareTag("Scor"))
        {
            scorSound.Play();
            Scor += 1;
            scorPanel.GetComponent<TextMeshProUGUI>().text = "SCOR " + Scor;           
        }
                                           
    }
}
