using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerMove playerMove;

    public List<GameObject> listTiles;
    public int spawner;
    public GameObject spawnAlertEnemy;
    public GameObject spawnEnemy;

    public static GameManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de EnemiesDetection dans la scène");
            return;
        }

        instance = this;
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
            spawner = Random.Range(0, listTiles.Count);
            Instantiate(spawnAlertEnemy, listTiles[spawner].transform.position, listTiles[spawner].transform.rotation);
            playerMove.countTurn = 0;
            playerMove.spawn = true;
        }
    }
}
