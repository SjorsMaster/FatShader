using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    [SerializeField] float speed;

    private void Awake()
    {
        //give start rotation
        transform.Rotate(90, 0, 0);
    }

    void Update()
    {
        //move ring
        transform.Translate(Vector3.down * speed);

        //Remove ring when off the play-space
        if(transform.position.z <= -1)
        {
            Destroy(gameObject);
        }
    }
}
