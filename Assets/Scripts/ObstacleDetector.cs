using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDetector : MonoBehaviour
{
    //var:
    public GameObject Knife;
    public Animator Animator;

    private IEnumerator Destroys(){
        yield return new WaitForSeconds(2);
        //Destroy(Knife.gameObject.transform.parent);
        Time.timeScale = 0; //Stop Game 
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit)){

            if(hit.collider.tag == "Obstacle" && Knife.GetComponent<Knife>().isCutting){
                Animator.SetBool("isHit", true);
                //StartCoroutine(Destroys());
            }
            // else if(hit.collider.tag == "test" && Knife.GetComponent<Knife>().isCutting){
                
            // }
        }
    }
}
