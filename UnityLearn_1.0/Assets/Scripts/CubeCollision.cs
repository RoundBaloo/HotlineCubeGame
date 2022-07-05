using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    public PlayerMovement Movement;
    private void OnCollisionEnter(Collision collisionInfo) 
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Movement.enabled = false;
            FindObjectOfType<Manager>().GameOver();
        }

    }

}
