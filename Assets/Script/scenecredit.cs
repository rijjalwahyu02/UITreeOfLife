using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenecredit : MonoBehaviour
{
   
    public void SceneCredit(){
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 5);
    }

    public void Back(){
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 5);
    }
}
