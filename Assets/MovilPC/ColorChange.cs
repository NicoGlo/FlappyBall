using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

    MeshRenderer rnd;

    void Start()
    {
        rnd = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
#if (UNITY_EDITOR || UNITY_STANDALONE_WIN)
        if(Input.GetKey(KeyCode.Space))
        {
            rnd.material.color = Color.green;
        }
#elif (UNITY_ANDROID)
    foreach(Touch touch in Input.touches)
    {
        if((Input.GetTouch(0).phase) == TouchPhase.Began)
        {
            rnd.material.color = Color.red;
        }
    }
#endif
    }
}
