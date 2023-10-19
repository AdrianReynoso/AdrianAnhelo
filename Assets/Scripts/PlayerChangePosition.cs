using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChangePosition : MonoBehaviour
 {
    
    [SerializeField] private Camera cam;
    [SerializeField] private GameObject player; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Area2")
        { 
            Vector3 camPosition = new Vector3 (17.78f, 0, -10);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3 (17.2f, 3.86f, 0);
            this.transform.position = playerPosition;
        
        }

        if (collision.gameObject.tag == "Area1")
        {
            Vector3 camPosition = new Vector3(-0.03000069f, 0, -10f);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(-1.04f, -4.45f, 0);
            this.transform.position = playerPosition;

    
        
         }
      }
    }

