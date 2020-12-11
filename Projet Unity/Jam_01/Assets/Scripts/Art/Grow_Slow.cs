using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow_Slow : MonoBehaviour
{

    void Start()
    {

        transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(0.02f, 0.02f, 0.02f);
        if (transform.localScale.x >= 1 && transform.localScale.y >= 1 && transform.localScale.z >= 1)
            transform.localScale = new Vector3(1f, 1f, 1f);
    }
}