using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PuntuacionText : MonoBehaviour
{
    public TMPro.TMP_Text text;

    public void Start()
    {
        text.text = "Score:" + GameManager.Instance.GetPunt();
    }

    void Update()
    {
        //To call the score's reference in the GameManager and modify the text object in the scene adding the current score, being updated each frame
        text.text = "Score:" + GameManager.Instance.GetPunt();
    }
}