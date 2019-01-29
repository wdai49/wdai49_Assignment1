using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateBox : MonoBehaviour
{

    // Start is called before the first frame update

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.transform.Rotate(new Vector3(1, 2, 1));
        }
    }

    
}
