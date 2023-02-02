using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectPool : MonoBehaviour
{
    private List<GameObject> pool;
    public GameObject objectToPool;
    public uint poolSize;
    public bool shouldExpand = true;

    void Awake()
    {
        Init(poolSize);    
    }

    public void Init(uint _size)
    {
        pool = new List<GameObject>();
        
        for(int i = 0; i < _size; i++)
        {
            AddGameObjectToPool();
        }
    }

    public GameObject GetInactiveGameObject()
    {
        foreach(GameObject o in pool)
        {
            if (!o.activeInHierarchy)
            {
                return o;
            }
        }

        if (shouldExpand)
        {
            return AddGameObjectToPool();
        }

        return null;
    }

    private GameObject AddGameObjectToPool()
    {
        GameObject obj = Instantiate(objectToPool, transform);
        obj.SetActive(false);
        pool.Add(obj);
        return obj;
    }
}
