using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour 
{
    [SerializeField] private float speed;

    public  void Update() 
    {
        MovePlayer();
    }
    public void MovePlayer()
    {
        if(isLocalPlayer)
        {
            float inputX = Input.GetAxis("Horizontal");
            float inputY = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(inputX, inputY, 0) * speed;

            transform.position = transform.position + movement;
        }
    }
}
