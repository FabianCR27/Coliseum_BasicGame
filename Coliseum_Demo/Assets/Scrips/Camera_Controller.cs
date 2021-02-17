using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    public float rotationSpeed = 1;
    public Transform target,player;
    float mouseX;
    float mouseY;



    void Start()
    {
        //cursor visibility
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        CamControl();
    }

    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X")* rotationSpeed;
        mouseY += Input.GetAxis("Mouse Y") * rotationSpeed;
        mouseY += Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(target);

       
            target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
           
        
    }

 
}
