using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    //Variable: 
    //public float speed;
    // Update is called once per frame
    void FixedUpdate() //More performance
    {
        transform.Translate(-Vector3.right * Time.deltaTime * GameSystem.System.levels.CSpeed, Space.World);
    }
}
