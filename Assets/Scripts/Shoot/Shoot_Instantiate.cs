using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Instantiate : MonoBehaviour
{
    public GameObject Projectile;
    public Transform particlePosition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject clone;
            clone = Instantiate(Projectile, transform.position, transform.rotation);
            Destroy(clone, 5);
            
        }

    }
}