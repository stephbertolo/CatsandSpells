using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    public GameObject tiro;
    //Steph eu fiz isso aqui pra quando pegar a varinha, ela aparecer na "mao" da fadinha.
    public GameObject varinhaPlayer;
 
    private void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.F))
        {
            tiro.SetActive(true);
            varinhaPlayer.SetActive(true);
            Destroy(gameObject);
        }
    }
}
