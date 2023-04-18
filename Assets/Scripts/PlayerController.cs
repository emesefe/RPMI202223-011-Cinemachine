using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float mouseX = Input.GetAxis("Mouse X");
        
        transform.Translate(Vector3.forward * verticalInput * 5 * Time.deltaTime);
        transform.Rotate(Vector3.up, 100 * mouseX * Time.deltaTime);
    }
}
