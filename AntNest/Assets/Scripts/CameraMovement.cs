using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Vector3 surfacePos = new Vector3(4, 6, -6);
    Vector3 surfaceRot = new Vector3(45, 0, 0);

    Vector3 anthillPos = new Vector3(13, -2, 0);
    Vector3 anthillRot = new Vector3(0, -90, 0);

    float speed = 20;

    bool outside = true;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            if (outside)
            {
                gameObject.transform.position -= new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                           0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
            }
            else
            {
                gameObject.transform.position -= new Vector3(0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed,
                                          Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed);
            }
           

        }
        gameObject.GetComponent<Camera>().fieldOfView += Input.GetAxis("Mouse ScrollWheel") * speed;
    }

    public void goToSurface()
    {
        outside = true;
        gameObject.GetComponent<Camera>().orthographic = false;
        gameObject.transform.position = surfacePos;
        gameObject.transform.eulerAngles = surfaceRot;
    }

    public void gotToAnthill()
    {
        outside = false;
        gameObject.GetComponent<Camera>().orthographic = true;
        gameObject.transform.position = anthillPos;
        gameObject.transform.eulerAngles = anthillRot;
    }
}
