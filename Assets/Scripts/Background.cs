using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
public class Background : MonoBehaviour
{
    public float maxY = 10.24f;
    public float speed = 0.01f;
    public float currentPositionY = 0f;
    
    // Update is called once per frame
    void Update()
    {
        currentPositionY += speed;
        this.gameObject.transform.position = new Vector3(0, currentPositionY, 0);
        if (currentPositionY > maxY)
        {
            this.gameObject.transform.position = new Vector3(0, 0, 0);
            currentPositionY = 0;
        }
    }
}
