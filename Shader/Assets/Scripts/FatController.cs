using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatController : MonoBehaviour
{

    [SerializeField]
    GameObject player, spawner;

    Renderer rend;

    [SerializeField]
    float thickness = 0.5f, goal = 2;

    //get the proper references
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.SetFloat("_VertMorph", thickness / 1000);
    }

    //make thicker when touching the union rings
    private void OnTriggerEnter(Collider other)
    {
        thickness += 0.1f;
        rend.material.SetFloat("_VertMorph", thickness / 1000);

    }
    
    //if sonic gets too thick delete him.
    private void Update()
    {
        if (thickness >= goal)
        {
            Destroy(spawner);
            Destroy(player);
        }
    }

}
