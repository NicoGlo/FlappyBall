using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObjectPool pool;
    void Update()
    {
        //Used to detect the pool(in this case the Tubes)
        GameObject o = pool.GetInactiveGameObject();
        o.SetActive(true);
    }
}
