using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    private bool rot;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if(rot == true){
                rot = false;
            } else {
                rot = true;
            }
        }
        Rotation();
    }

    void Rotation()
    {
        if (rot == true)
        {
            transform.Rotate(Vector3.up, 30f * Time.deltaTime);
        }
    }
}

