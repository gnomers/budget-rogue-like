using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float Health = 5f;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other)
    {
    
        if(other.transform.tag == "enemy")
        {
            if(timer <= 0) {
                Debug.Log(other.transform.tag);
                timer = 1f;
            }
        } 
    }
    void Update()
    {
        if(timer > 0) 
        {
            timer -= Time.deltaTime;
        }
    }
} 