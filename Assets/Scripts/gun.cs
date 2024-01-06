using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get mouse position
        Vector3 mousePos =  Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mousePos.z = 0;
        Vector3 dirToMouse = (mousePos - transform.position).normalized;
        dirToMouse.z = 0;
        transform.right = dirToMouse;
    }
}
