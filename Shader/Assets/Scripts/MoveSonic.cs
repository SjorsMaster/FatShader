using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSonic : MonoBehaviour
{
    //Simple script to move sonic
    void Update()
    {
        transform.position = new Vector3(Input.GetAxis("Horizontal") * 2, 0);    
    }
}
