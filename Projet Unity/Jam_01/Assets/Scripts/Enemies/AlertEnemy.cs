using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertEnemy : MonoBehaviour
{
    public GameObject enemy;
    public List<GameObject> listEnemies;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);

        /*for(int i = 0; i < GameManager.instance.spawnEnemy.Length; i++)
        {
            if(!GameManager.instance.spawnEnemy[i].activeInHierarchy)
            {
                enemy = GameManager.instance.spawnEnemy[i];
                
            }
        }*/

        for (int i = 0; i < GameManager.instance.spawnEnemy.Length; i++)
        {
            if (!GameManager.instance.spawnEnemy[i].activeInHierarchy)
            {
                listEnemies.Add(GameManager.instance.spawnEnemy[i]);
            }
        }

        GameManager.instance.spawner = Random.Range(0, listEnemies.Count);
        transform.position = listEnemies[GameManager.instance.spawner].transform.position;

    }

    // Update is called once per frame
    void Update()
    {
            if (GameManager.instance.playerMove.spawnTurn >= 1)
            {
                GameManager.instance.playerMove.spawn = false;
                GameManager.instance.playerMove.countTurn = 0;
                listEnemies[GameManager.instance.spawner].SetActive(true);
                //enemy.SetActive(true);
                listEnemies.Remove(listEnemies[GameManager.instance.spawner]);
                //Instantiate(GameManager.instance.spawnEnemy, transform.position, transform.rotation);
                GameManager.instance.playerMove.spawnTurn = 0;
                Destroy(gameObject);
            }
    }
}
