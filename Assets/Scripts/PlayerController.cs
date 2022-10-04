using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;
    public float xRange = 5.2f;
    public GameObject projectilePrefab;

    private float _horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        
        //Instantiate clones the object. First argument asks what object, 2nd asks where, 3rd asks what rotation
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
    void PlayerMovement()
    {
        //Horizontal movement only
        _horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * _horizontalInput * moveSpeed * Time.deltaTime);
        
        //Left and right bounds
        
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
    }
}
