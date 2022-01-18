using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour
{
    public void Restart(){
        GameSystem.System.Restart();
    }

    public void KnifeKill(){
        GameSystem.System.KnifeKill();
    }
}
