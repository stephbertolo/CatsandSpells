using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public GameObject enemygroup;
    public Material skybox01;
    public Material skybox02;
    Light lt;

    // Start is called before the first frame update
    void Start()

    {
        lt = GameObject.Find("Directional Light").GetComponent<Light>();
        RenderSettings.skybox = skybox01;
        lt.color = new Color(1f, 0.9f, 0.8f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.F))
        {
            GameObject.Find("Main Camera").GetComponent<Camera_Shake>().Shake(0.2f, 0.5f);
            RenderSettings.skybox = skybox02;
            lt.color = new Color(1f, 0.6f, 0.5f, 1f);

            enemygroup.SetActive(true);

            Destroy(gameObject);

        }

    }

}