using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    Movement movement;
    // Start is called before the first frame update
    void Start()
    {
        movement = GameObject.FindObjectOfType<Movement>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name =="Player")
        {
            movement.Death();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
