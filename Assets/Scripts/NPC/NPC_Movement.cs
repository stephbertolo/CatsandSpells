using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

public class NPC_Movement : MonoBehaviour
{
    public NavMeshAgent nav;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //float distance = Vector3.Distance(transform.position, player.transform.position);

        Vector3 dirToPlayer = transform.position - player.transform.position;
        Vector3 newPos = transform.position + dirToPlayer;
        nav.SetDestination(newPos);
    }
}
