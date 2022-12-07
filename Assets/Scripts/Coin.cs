using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Player")
        {
            ScoreManager.instance.AddScore();
            Destroy(gameObject);
        }
    }
}
