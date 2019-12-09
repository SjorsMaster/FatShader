using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;

    void Start()
    {
        //Keep repeating this action every second
        InvokeRepeating("Spawn", 1,  1);
    }

    void Spawn()
    {
        //Create ring
        Instantiate(prefab, new Vector3(transform.position.x + (Random.Range(-1, 2) * 2), transform.position.y, transform.position.z), Quaternion.identity);
    }
}
