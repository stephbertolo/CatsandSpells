using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Movement : MonoBehaviour
{
    public NavMeshAgent nav;
    public GameObject player;
    public GameObject safezone;
    public bool followPlayer;
    public Vector3 posInicial;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        safezone = GameObject.FindGameObjectWithTag("Safezone");

        posInicial = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (followPlayer == true)
        {
            nav.destination = player.transform.position;

        }

        if (followPlayer == false)
        {
            nav.destination = posInicial;
        }
    }

}
