using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;


public class movingPlatform : MonoBehaviour
{
    [SerializeField] Transform Finish;  //point 1
    [SerializeField] Transform start;   //point 2

    [SerializeField] float duration;    //duration for moving

   

    // Update is called once per frame
   async  void Start() {
    
   
    {
        while (true) //inf loop
        {
          await Task.Delay(1000); //delay
        Move();
        await Task.Delay(3000); //delay
        MoveBack();
        await Task.Delay(3000); //delay
        }
    }
    }
    void Move(){
         LeanTween.moveX(gameObject, Finish.position.x, duration);  //moving
    }
     void MoveBack(){
         LeanTween.moveX(gameObject, start.position.x, duration);   //moving back
    }
}