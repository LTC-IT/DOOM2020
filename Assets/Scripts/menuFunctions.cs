using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuFunctions : MonoBehaviour
{
   public void LoadLevel (int level)
   {
      SceneManager.LoadScene(level);
   }

   public void QuitFunction()
   {
      Application.Quit();
   }
}
