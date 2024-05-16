using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pindahscene1 : MonoBehaviour
{
   
    public void PindahScene1(){
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 2);
    }

    public void Back(){
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 2);
    }
}
