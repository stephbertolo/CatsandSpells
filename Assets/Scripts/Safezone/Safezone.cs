using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safezone : MonoBehaviour
{
    public GameObject[] enemies;
    public bool SafeZone;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SafeZone = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SafeZone = false;
        }
    }

    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (SafeZone == true)
        {

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].GetComponent<Enemy_Movement>().followPlayer = false;
            }
        }

        if (SafeZone == false)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].GetComponent<Enemy_Movement>().followPlayer = true;
            }

        }
    }

}
