using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    //Variables:
    public GameObject[] Vegetables;
    public GameObject Obstacle;
    public Transform SpawnPoint;
    public float IntervalBetweenSpawn;
    private float spawnBetweenTime;
    private int vegetableSpawnCounterForObstacle;  
    // Update is called once per frame
    void FixedUpdate()
    {
        if(spawnBetweenTime <= 0){
            int rand = Random.Range(0, Vegetables.Length);
            int obstacleLimit = Random.Range(1, 3);
            
            if(obstacleLimit == 2){

                if(vegetableSpawnCounterForObstacle > 6){
                    Instantiate(Obstacle, SpawnPoint.position, Quaternion.identity); //Instantiate(Object, position, rotation, parent)
                    vegetableSpawnCounterForObstacle =0;
                }else{
                    SpawnVeg(rand);
                }
                
            }else{
                    SpawnVeg(rand);
            }
           
            spawnBetweenTime = IntervalBetweenSpawn;
        }
        else{
            spawnBetweenTime -= Time.deltaTime;
        }
        
    }
    private void SpawnVeg(int idx){
        //Instantiate() : this function is to create a clone of gameObject
        Instantiate(Vegetables[idx],SpawnPoint.position, Quaternion.identity);
        vegetableSpawnCounterForObstacle++;
    }
}
