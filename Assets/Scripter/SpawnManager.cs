using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstractlePrefeb;
    private Vector3 spawnPos = new Vector3(25, 0, 0);

    void Start()
    {
        Instantiate(obstractlePrefeb, spawnPos, transform.rotation);
    }

}
