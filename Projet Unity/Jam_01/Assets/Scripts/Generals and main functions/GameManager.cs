using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerMove playerMove;

    public List<GameObject> listTiles;
    public int spawner;
    public GameObject spawnAlertEnemy;
    public GameObject[] spawnEnemy;
    public int countEnemies;

    public static GameManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de EnemiesDetection dans la scène");
            return;
        }

        instance = this;

        /*for (int i = 0; i < spawnEnemy.Length; i++)
        {
            spawner = Random.Range(0, listTiles.Count);
            spawnEnemy[i].transform.position = listTiles[spawner].transform.position;
        }*/
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(playerMove.countTurn);
    }
    // Update is called once per frame
    void Update()
    {
        if(playerMove.countTurn >= 2)
        {
            if(countEnemies <= 6)
            {
                //spawner = Random.Range(0, listTiles.Count);
                Instantiate(spawnAlertEnemy, transform.position, transform.rotation);
                //listTiles[spawner].GetComponent<Tile>().walkable = false;
                playerMove.countTurn = 0;
                playerMove.spawn = true;
            }
            
        }
    }
}
