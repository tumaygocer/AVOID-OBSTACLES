using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XCamControl : MonoBehaviour
{  
    bool right;
    bool left;

    private void Update()
    {
        Vector3 go_right = new Vector3(1, transform.position.y, transform.position.z);
        Vector3 go_left = new Vector3(-1, transform.position.y, transform.position.z);

        if (Input.touchCount > 0)
        {
            Touch finger = Input.GetTouch(0);

            if (finger.deltaPosition.x > 50.0f)
            {
                right = true;
                left = false;
            }

            if (finger.deltaPosition.x < -50.0f)
            {
                right = false;
                left = true;
            }

            if (right == true)
            {
                transform.position = Vector3.Lerp(transform.position, go_right, 5 * Time.deltaTime);
            }

            if (left == true)
            {
                transform.position = Vector3.Lerp(transform.position, go_left, 5 * Time.deltaTime);
            }
        }
    }

}
