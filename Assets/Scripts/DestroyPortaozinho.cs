using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPortaozinho : MonoBehaviour
{
    public float portaoHP = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (portaoHP<1)
        {
            Destroy(gameObject);
        }
    }
}
