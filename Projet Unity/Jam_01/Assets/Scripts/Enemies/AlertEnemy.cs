using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.playerMove.spawnTurn >= 1)
        {
            GameManager.instance.playerMove.spawn = false;
            GameManager.instance.playerMove.countTurn = 0;
            Instantiate(GameManager.instance.spawnEnemy, transform.position, transform.rotation);
            GameManager.instance.playerMove.spawnTurn = 0;
            Destroy(gameObject);
        }
    }
}
