using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public Animator KnifeAnimator;
    public bool isCutting;
    private Rect screenBounds;

    public float TimeElapsed = 0f;
    private float ClickTimeFrame = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = new Rect(0, 0, Screen.width, Screen.height - 200);
    }

    public void SetCuttingState(bool state){
        isCutting = state;
        KnifeAnimator.SetBool("isCutting",state);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetMouseButton(0) && screenBounds.Contains(Input.mousePosition) && isCutting == false){
            TimeElapsed = 0f;
            SetCuttingState(true);
        }
        else{
            TimeElapsed += Time.fixedDeltaTime;
            if(TimeElapsed >= ClickTimeFrame && isCutting){
                SetCuttingState(false);
                TimeElapsed = 0f;
            }
            
        }
    }
}
