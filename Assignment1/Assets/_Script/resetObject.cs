using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetObject : MonoBehaviour
{
    Vector3 originolPosition;

    // Start is called before the first frame update
    void Start()
    {
        originolPosition = gameObject.transform.position;
    }

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
            gameObject.transform.position = originolPosition;
            
    }

}
