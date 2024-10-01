using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 

{
    public float horizontolInput;
    public float speed = 10.0f; 
    public float xRange = 10;  
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         horizontolInput = Input.GetAxis("Horizontal");
         transform.Translate(Vector3.right * horizontolInput * Time.deltaTime * speed);


        // keep the player in bounds 
         if (transform.position.x < -xRange) 
         {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
         }
         if (transform.position.x > xRange) 
         {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
         }

         if (Input.GetKeyDown(KeyCode.Space))
         {
            // Launch a projectile from player 
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
         }
    }
}
