using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDmg : MonoBehaviour
{
    private float timer = 0f;
    public Transform SpawnPoint;
        void Update()
    {
        if(timer > 0) 
        {
            timer -= Time.deltaTime;
        }
    }

    // Update is called once per frame
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player") {
            if(timer <= 0) {
                GameObject.Find("The Mad Lad").GetComponent<PlayerHealth>().Health --;
                timer = 1f;
                Debug.Log(GameObject.Find("The Mad Lad").GetComponent<PlayerHealth>().Health);
                if (GameObject.Find("The Mad Lad").GetComponent<PlayerHealth>().Health <= 0)
                {
                    GameObject.Find("The Mad Lad").GetComponent<PlayerHealth>().Death();
                } 
            }
        }
    }
}