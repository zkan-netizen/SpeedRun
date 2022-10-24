using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "P25")
        {
            Debug.Log("25PUAN");
            GameManager._gamemanager.ScorePoint(25);
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "P50")
        {
            GameManager._gamemanager.ScorePoint(50);
            other.gameObject.SetActive(false);
            Debug.Log("50PUAN");
        }
        if (other.gameObject.tag == "P40")
        {
            GameManager._gamemanager.ScorePoint(40);
            other.gameObject.SetActive(false);
            Debug.Log("40PUAN");
        }
        if (other.gameObject.tag == "P30")
        {
            GameManager._gamemanager.ScorePoint(30);
            other.gameObject.SetActive(false);
            Debug.Log("30PUAN");
        }
        if (other.gameObject.tag == "P2X")
        {
            GameManager
                ._gamemanager
                .ScorePoint(GameManager._gamemanager.Score * 2);
            other.gameObject.SetActive(false);
            Debug.Log("2X");
        }
    }
}
