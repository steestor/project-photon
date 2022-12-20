using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    public float speed2;
    public Rigidbody rb2;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb2.velocity = new Vector3(0, 0, speed2);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb2.velocity = new Vector3(0, 0, -speed2);

        }
        else
        {
            rb2.velocity = new Vector3(0, 0, 0);
        }


    }
}
