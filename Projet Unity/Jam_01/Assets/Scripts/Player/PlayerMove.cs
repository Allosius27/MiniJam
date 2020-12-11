using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : TacticsMove
{

    // Use this for initialization
    void Start()
    {
        Init();

        moveValue = move;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward);

        if (!turn)
        {
            return;
        }

        if (!moving)
        {
            FindSelectableTiles();
            CheckMouse();
            CheckAttack();
            EndToTheTurn();
        }
        else
        {
            Move();
        }
    }

    void CheckMouse()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Tile")
                {
                    Tile t = hit.collider.GetComponent<Tile>();

                    if (t.selectable)
                    {
                        MoveToTile(t);
                    }
                }
            }
        }
    }

    void CheckAttack()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (enemyCollision)
                {
                    for (int i = 0; i < GameManager.instance.spawnEnemy.Length; i++)
                    {
                        if(GameManager.instance.spawnEnemy[i].GetComponent<NPCMove>().touched)
                        {
                            //MeshRenderer m = GameManager.instance.spawnEnemy[i].GetComponent<MeshRenderer>();
                            CapsuleCollider c = GameManager.instance.spawnEnemy[i].GetComponent<CapsuleCollider>();
                            Transform g = GameManager.instance.spawnEnemy[i].transform.GetChild(0);
                            g.gameObject.SetActive(false);
                            //m.enabled = false;
                            c.enabled = false;
                            GameManager.instance.spawnEnemy[i].GetComponent<NPCMove>().touched = false;
                        }
                    }
                    //hit.collider.GetComponent<NPCMove>().touched = true;
                    //NPCMove n = hit.collider.GetComponent<NPCMove>();
                    //n.gameObject.SetActive(false);
                    
                    attacking = true;
                    enemyCollision = false;
                    TurnManager.PlayerEndTurn();
                }
            }
        }
    }

    void EndToTheTurn()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            attacking = true;
            TurnManager.PlayerEndTurn();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("NPC"))
        {
            Debug.Log("Collision ennemi");
            enemyCollision = true;
            other.GetComponent<NPCMove>().touched = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
            Debug.Log("Sortie Collision Ennemi");
            enemyCollision = false;
            other.GetComponent<NPCMove>().touched = false;
        }
    }
}
