using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebonds1 : MonoBehaviour
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
            transform.localScale += new Vector3(0.00002f, 0.00002f, 0.00002f);
        }
        if (Switching == false)
        {
            transform.localScale -= new Vector3(0.00002f, 0.00002f, 0.00002f);
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
