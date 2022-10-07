using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOoB : MonoBehaviour
{
    public float topBound;
    public float bottomBound;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > topBound)
        {
            Destroy(this.gameObject);
        }
        if(transform.position.y < bottomBound)
        {
            Debug.Log("Game Over!");
            Destroy(this.gameObject);
        }
    }
}
