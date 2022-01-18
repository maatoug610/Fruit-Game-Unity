using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter : MonoBehaviour
{
  //Variables:
  Vector3 randAng;
  public GameObject Knife;




  void OnTriggerEnter(Collider coll){
      if(coll.gameObject.tag == "Slice" && Knife.GetComponent<Knife>().isCutting ){
          coll.gameObject.GetComponent<Rigidbody>().isKinematic = false;
          coll.gameObject.GetComponent<Rigidbody>().AddTorque(-Vector3.up * 8900f, ForceMode.Impulse);
          randAng = new Vector3(Random.Range(-0.3f, -0.6f), Random.Range(0.2f, 0.3f), Random.Range(-0.5f, 0.5f));

          coll.gameObject.GetComponent<Rigidbody>().AddForce(randAng * Random.Range(650, 1500), ForceMode.Impulse);
          Knife.GetComponent<Knife>().SetCuttingState(true);
          GameSystem.System.levels.OnVegetableCut();
          Destroy(coll.gameObject, 4f);
          Destroy(coll.gameObject.transform.parent.gameObject, 4f);

      }
     
  }
}
