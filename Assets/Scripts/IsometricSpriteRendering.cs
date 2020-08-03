using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsometricSpriteRendering : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().sortingOrder = (int)(transform.position.y * -10);
    }
}
