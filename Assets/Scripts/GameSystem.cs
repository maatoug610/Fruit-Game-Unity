using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text
using UnityEngine.SceneManagement;
public class GameSystem : MonoBehaviour
{
   static GameSystem  _system;
   public GameObject GameScoreCanvas;
   public GameObject EndGameCanvas;
   public Text EndScoreText;

   public static GameSystem System{
       get{
           if(_system == null){
               _system = GameObject.FindObjectOfType<GameSystem>();

               if(_system == null){
                   GameObject container = new GameObject("GameSystem");
                   _system = container.AddComponent<GameSystem>();
               }
           }

           return _system;
       }
   }

   public void Restart(){
       EndGameCanvas.SetActive(true);
       GameScoreCanvas.SetActive(false);

       SceneManager.LoadScene(0);
   }

    public void KnifeKill(){
        EndScoreText.text = levels.Score.ToString();
        EndGameCanvas.SetActive(true);
        GameScoreCanvas.SetActive(false);
    }

   public Level levels;
}
[System.Serializable]
public class Level{
    public float CSpeed = 600;
    public int Score =0;
    public Text ScoreText;
    //public Text ScoreText;
    public void PlusScore(){
        Score +=1;
        ScoreText.text = Score.ToString();
        float speed = CSpeed;
      //if(CSpeed != 1200){

        if(Score >= 200){
            speed = 900;
        }
        if(Score >= 400){
            speed = 1200;
        }
        if(Score >= 2000){
            speed = 2000;
        }

        if(Score >= 3000){
            speed = 3000;
        }

        if(Score >= 4000){
            speed = 4000;
        }

        if(Score >= 5000){
            speed = 5000;
        }

        if(Score >= 6000){
            speed = 6000;
        }

        UpdateSpeed(speed);
        
      //}
    }

    private void UpdateSpeed(float sp){
        ObjectSpawner spawner = GameObject.FindObjectOfType<ObjectSpawner>();
        Animator KnifeAnimator = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();

        if(sp == 900){
            spawner.IntervalBetweenSpawn = 0.4f;
            KnifeAnimator.SetFloat("speed", 2.0f);
        }

        if(sp == 1200){
            spawner.IntervalBetweenSpawn = 0.26f;
            KnifeAnimator.SetFloat("speed", 2.6f);
        }

         if(sp == 2000){
            spawner.IntervalBetweenSpawn = 0.10f;
            KnifeAnimator.SetFloat("speed", 2.9f);
        }

         if(sp == 3000){
            spawner.IntervalBetweenSpawn = 0.05f;
            KnifeAnimator.SetFloat("speed", 3.4f);
        }

         if(sp >= 4000){
            spawner.IntervalBetweenSpawn = 0.01f;
            KnifeAnimator.SetFloat("speed", 3.8f);
        }
        CSpeed = sp;
    }
    public void OnVegetableCut(){
        PlusScore();
    }

}
