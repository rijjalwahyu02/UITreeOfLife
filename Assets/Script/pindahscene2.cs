using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pindahscene2 : MonoBehaviour
{
   
    public void PindahScene2(){
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 4);
    }

    public void Back(){
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 4);
    }
}
