using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Respawn : MonoBehaviour
{
    public GameObject enemyPrefab;
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
        Instantiate(enemyPrefab, transform.position, transform.rotation);
    }
}
