using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebonds : MonoBehaviour
{
    public bool Switching = false;
    public float speed = 0.14f;
    public float delay = 1.3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Trueswitch", 0, delay);

    }

    // Update is called once per frame
    void Update()
    {

        if (Switching == true)
        {
            float newY = transform.position.y - speed * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }
        if (Switching == false)
        {
            float newY = transform.position.y + speed * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }

    }

    void Trueswitch()
    {
        if (Switching == true)
        {
            Switching = false;
           
        }
        else
        {
            Switching = true;

        }
       

    }
}
