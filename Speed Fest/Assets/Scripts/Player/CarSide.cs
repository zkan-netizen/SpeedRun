using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSide : MonoBehaviour
{
    public float Sidespeed;

    private int state = 0;

    [SerializeField]
    private bool Left;

    [SerializeField]
    private bool Right;

    void moveright()
    {
        if (state < 1) state++;
    }

    void moveleft()
    {
        if (state > -1) state--;
    }

    public void DragLeftRight()
    {
        if (Input.touchCount > 0)
        {
            Touch touched = Input.GetTouch(0);

            if (touched.deltaPosition.x >30.0f)
            {
                Right = true;
                Left = false;
            }
            if (touched.deltaPosition.x < -30.0f)
            {
                Right = false;
                Left = true;
            }

            if (Right == true)
            {
                if (state < 1) state++;
            }
            if (Left == true)
            {
                if (state > -1) state--;
            }
            Vector3 x =
                new Vector3(state * 1.5f,
                    transform.position.y,
                    transform.position.z);
            transform.position =
                Vector3
                    .MoveTowards(transform.position,
                    x,
                    Sidespeed * Time.deltaTime);
        }
    }
    private void Update() {
        DragLeftRight();
    }
}
