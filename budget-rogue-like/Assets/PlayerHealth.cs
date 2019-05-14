using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float Health = 5f;
    // Start is called before the first frame update

    public Transform SpawnPoint;
    void Start()
    {
        
    }

    // Update is called once per frame

    public void Death() 
    {
        transform.position = SpawnPoint.transform.position;
        Health = 5f;
    }
  /*  void dmg()
        {
         
        {
            if(timer <= 0) {
                Health -= 1;
                timer = 1f;
                if (Health <= 0)
                {
                    Death(); 
                } 
            }
        } 
    } */
} 