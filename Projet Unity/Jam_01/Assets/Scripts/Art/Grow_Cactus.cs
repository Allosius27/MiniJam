using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow_Cactus : MonoBehaviour
{

    void Start()
    {

        transform.localScale = new Vector3(0.0001f, 0.0001f, 0.0001f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(0.0002f, 0.0002f, 0.0002f);
        if (transform.localScale.x >= 0.01 && transform.localScale.y >= 0.01 && transform.localScale.z >= 0.01)
            transform.localScale = new Vector3(0.01f, 0.011f, 0.01f);
    }
}