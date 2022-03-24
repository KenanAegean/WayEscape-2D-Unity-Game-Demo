using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalScroll : MonoBehaviour
{
    [Tooltip("Game units per socond")]
    [SerializeField] float scrollrate = 0.2f;
    

    void Update()
    {
        //you can create yMove
        transform.Translate(new Vector2(0f, scrollrate * Time.deltaTime));
    }
}
