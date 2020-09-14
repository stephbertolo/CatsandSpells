using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Desctructible : MonoBehaviour
{
    public GameObject destroydVersion;
    public ParticleSystem dust;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            Debug.Log("foi");
            Destroy(this.gameObject);

                        
            GameObject temp = Instantiate(destroydVersion, transform.position, transform.rotation);
            ParticleSystem tempPs = Instantiate(dust, transform.position, transform.rotation);


            Destroy(temp, 6);
            Destroy(tempPs, 5);
        }
       
       




    }
}