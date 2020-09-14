using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour
{
    public int startingPlayerHP = 10;
    public int currentPlayerHealth;
    public Slider healthSlider;
    public Image damageImage;
    public float flashSpeed = 5f;
    public Color flashColor = new Color(1f, 0f, 0f, 0.1f);
    public ParticleSystem shootParticleplayer;

    public AudioSource playerGetHit;

    bool damaged;

    private void Awake()
    {
        currentPlayerHealth = startingPlayerHP;
    }
    
    void Start()
    {

    }

    void Update()
    {
        if (damaged)
        {
            damageImage.color = flashColor;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;

        healthSlider.value = currentPlayerHealth;

        if (currentPlayerHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Game");
      }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shootParticleplayer.Play(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            damaged = true;
            currentPlayerHealth--;
            AudioSource SFX = Instantiate(playerGetHit, transform.position, transform.rotation);
            Destroy(SFX.gameObject, 5);
        }

    }
}
