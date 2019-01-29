using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCamera : MonoBehaviour
{

    public Camera mainCamera;
    public Camera topCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera.enabled = true;
        topCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            mainCamera.enabled = !mainCamera.enabled;
            topCamera.enabled = !topCamera.enabled;
        }
    }
}

