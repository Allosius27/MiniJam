using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCtrl : MonoBehaviour
{
    public float speed = 6.0f;
    public float rotateSpeed = 90.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;
    private bool isGrounded = false;
    private CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = Vector2.zero;

        if (Input.GetKeyDown(KeyCode.Z))
        {
            moveDirection.x = 0;
            moveDirection.z = speed;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            moveDirection.x = -speed;
            moveDirection.z = 0;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            moveDirection.x = 0;
            moveDirection.z = -speed;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            moveDirection.x = speed;
            moveDirection.z = 0;
        }

        Movements();
    }

    public void Movements()
    {
        if(isGrounded)
        {
            // Calcul direction mouvement
            transform.position = new Vector3(transform.position.x + moveDirection.x, transform.position.y, transform.position.z + moveDirection.z);
            //moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            //moveDirection = transform.TransformDirection(moveDirection);
            //moveDirection *= speed;
        }

        moveDirection.y -= gravity * Time.deltaTime;
        Physics.SyncTransforms();

        // Application mouvement joueur
        var flags = controller.Move(moveDirection * Time.deltaTime);

        // Gestion rotation joueur
        transform.Rotate(0, Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime, 0);

        // Détection du sol
        isGrounded = CollisionFlags.CollidedBelow != 0;
    }
}
