using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField]
    private float Speed;

   

    private void Movement()
    {
        if (GameManager._gamemanager.isGameStart)
        {
            transform.Translate(0, 0, Speed * Time.deltaTime);
            
        }
    }
 
    private void Update()
    {
        Movement();
    }
}
