using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void OnTriggerEnter(Collider collidedObject){
        
        if(collidedObject.tag == "Slice" || collidedObject.tag == "Obstacle"){
           
            Destroy(collidedObject.gameObject.transform.parent.gameObject);
           }
              
        
        
    }
}
