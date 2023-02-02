using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }


    private void Awake()
    {
        Instance = this;
    }

    public int score = 0;
    GameObjectPool pool;
    float timeToSpawn = 3;
    float auxTime = 0;
    bool canBeSpawned = false;
    private void Start()
    {
        pool = FindObjectOfType<GameObjectPool>();
        canBeSpawned = true;
    }

    private void Update()
    {
        GetPunt();

        //To spawn the tubes in a provided range inbetween the Y axis
        if (canBeSpawned == true)
        {
            canBeSpawned = false;
            GameObject obstacle = pool.GetInactiveGameObject();
            if (obstacle != null)
            {
                obstacle.transform.position = pool.transform.position + new Vector3(0f, Random.Range(1.83f, -0.12f), 0f);
                obstacle.SetActive(true);

            }
        }


        //The time each tube is spawned
            if (canBeSpawned == false)
            {
                auxTime += Time.deltaTime;
                if (auxTime >= timeToSpawn)
                {
                    canBeSpawned = true;
                    auxTime = 0;
                }
            }

            
    }

    
    //To return an updated score information that will be used to updated in the text too
    public int GetPunt()
    {
        return score;
    }
}
