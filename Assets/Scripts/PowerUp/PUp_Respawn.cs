using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUp_Respawn : MonoBehaviour
{
    public GameObject pUpPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Spawn()
    {
        Instantiate(pUpPrefab, transform.position, transform.rotation);
    }
}
