using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Collision : MonoBehaviour
{
    Rigidbody rb;
    public ParticleSystem hitParticles;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        rb.AddForce(transform.forward*1400);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemy_Health>().enemyHP--;
            Destroy(this.gameObject);
            ParticleSystem explosion = Instantiate(hitParticles, transform.position, transform.rotation);
            Destroy(explosion, 3);

        }
    }

}
