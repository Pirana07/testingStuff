using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Death : MonoBehaviour
{
        private void OnTriggerEnter2D(Collider2D other) {
            if(other.tag == "Death"){
                 SceneManager.LoadScene(0);
            }
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
