using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Destroy : MonoBehaviour
{
    public float deathTiming;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, deathTiming);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
