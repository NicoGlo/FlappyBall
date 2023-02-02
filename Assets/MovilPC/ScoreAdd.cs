using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScoreAdd : MonoBehaviour
{
    private PuntuacionText texto;

    private void Start()
    {
        texto = FindObjectOfType<PuntuacionText>(); 
        //To call the Text object in the scene
    }
    
    private void OnTriggerEnter(Collider other)
    {
        BallMovement ball = other.GetComponent<BallMovement>();
        if (ball != null)
        {
            //If the player's collider touches this trigger collider, a point is added in the GameManager score
            GameManager.Instance.score += 1;
        }
    }

    
}
