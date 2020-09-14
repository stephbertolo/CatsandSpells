using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Skill
{
    Health,
    Energy,
    Shield,
    Score,
};

public class PowerUps : MonoBehaviour
{
    public Skill mySkill;
    public GameManager gmReference;
    public GameObject[] spawnPoints;
    public AudioSource hpSFX;
    // Start is called before the first frame update
    void Start()
    {
        gmReference = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(mySkill==Skill.Health)
            {
                other.gameObject.GetComponent<Player_Health>().currentPlayerHealth = 10;
                AudioSource SFX = Instantiate(hpSFX, transform.position, transform.rotation);
                Destroy(SFX.gameObject, 1);

                Destroy(this.gameObject);

            }

            spawnPoints = GameObject.FindGameObjectsWithTag("Respawn");
            int random = Random.Range(0, spawnPoints.Length);
            spawnPoints[random].GetComponent<PUp_Respawn>().Spawn();


        }
    }

}
