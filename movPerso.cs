using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movPerso : MonoBehaviour
{ 
    Vector3 m;

    // Start is called before the first frame update
    void Start()
    {
        m = new Vector3(1f, 1f, 1f);
        transform.Translate(m);
        m.Set(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            m.z = 0.01f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.S))
        {
            m.z = -0.01f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.A))
        {
            m.x = -0.01f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.D))
        {
            m.x = 0.01f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            m.x = 0.001f;
            m.z = 0.0001f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.E))
        {
            m.x = 0.001f;
            m.z = 0.001f;
            transform.Translate(m);
        }

        m.Set(0, 0, 0);

        if (transform.position.x >= 97.5)
        {
            transform.position = new Vector3(97.5f, transform.position.y, transform.position.z);
        }
        if (transform.position.x <= -97.5)
        {
            transform.position = new Vector3(-97.5f, transform.position.y, transform.position.z);
        }
        if (transform.position.z >= 57.7)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 57.7f);
        }
        if (transform.position.z <= -57.7)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -57.7f);
        }
        m.Set(0, 0, 0);
    }
}


