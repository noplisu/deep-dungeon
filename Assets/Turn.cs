using UnityEngine;
using System.Collections;

public class Turn : MonoBehaviour {
    bool zeroHorizontal;

    void Update () {
        float horizontal = Input.GetAxisRaw("Horizontal");
        if (horizontal == 0)
        {
            zeroHorizontal = true;
        }
        else
        {
            if(zeroHorizontal) 
                transform.Rotate(Vector3.up, 90 * horizontal);
            zeroHorizontal = false;
        }
	}
}
