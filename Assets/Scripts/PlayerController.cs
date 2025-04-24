using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 

{
    public float horizontolInput;
    public float speed = 10.0f; 
    public float xRange = 10;  
    public GameObject projectilePrefab;
    float forwardInput;
    public float VerticalInput;
    public float minZ = -5f;
    public float maxZ = 20f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         horizontolInput = Input.GetAxis("Horizontal");
         forwardInput = Input.GetAxis("Vertical"); 
         transform.Translate(Vector3.forward * forwardInput * Time.deltaTime * speed );
         transform.Translate(Vector3.right * horizontolInput * Time.deltaTime * speed);

         float moveInput = Input.GetAxis("Vertical");
         Vector3 newPosition = transform.position + new Vector3(0, 0, moveInput * speed * Time.deltaTime);



        // keep the player in bounds 
         if (transform.position.x < -xRange) 
         {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
         }
         if (transform.position.x > xRange) 
         {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
         }

         // keep the player in bounds 
         if (transform.position.z < minZ) 
         {
            transform.position = new Vector3(transform.position.x, transform.position.y, minZ);
         }
         if (transform.position.z > maxZ) 
         {
           transform.position = new Vector3(transform.position.x, transform.position.y, maxZ);
         }



         if (Input.GetKeyDown(KeyCode.Space))
         {
            // Launch a projectile from player 
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
         }
    }
}
