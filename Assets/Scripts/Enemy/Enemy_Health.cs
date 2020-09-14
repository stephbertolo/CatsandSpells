using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    public int enemyHP;
    public GameObject friendlyNPC;
    public int scoreValue = 10;               // The amount added to the player's score when the enemy dies.
    public ParticleSystem transformParticles;
        //public GameObject enemySpawnPoint;
    public GameObject[] spawnPoints;

    public AudioSource transformSFX;

       
    void Start()
    {

    }

    void Update()
    {
        if (enemyHP <= 0)
        {
            GameObject.Find("Coin").GetComponent<Animator>().Play("CoinGiro");
            Destroy(this.gameObject);

            GameObject.Find("Main Camera").GetComponent<Camera_Shake>().Shake(0.2f, 0.2f);

            Instantiate(friendlyNPC, transform.position, transform.rotation);
            AudioSource SFX = Instantiate(transformSFX, transform.position, transform.rotation);
            Destroy(SFX.gameObject, 2);

            //ParticleSystem explosion = Instantiate(transformParticles, transform.position, transform.rotation);
            
          //  Destroy(explosion.gameObject, 3);

            // Increase the score by the enemy's score value.
            GameManager.score += scoreValue;

            //um spawn point
            //enemySpawnPoint = GameObject.FindGameObjectWithTag("Respawn");
            //enemySpawnPoint.GetComponent<Enemy_Respawn>().Spawn();

            //varios spawn points
            spawnPoints = GameObject.FindGameObjectsWithTag("Respawn");
            int random = Random.Range(0, spawnPoints.Length);
            spawnPoints[random].GetComponent<Enemy_Respawn>().Spawn();
         
        }
    }
}
