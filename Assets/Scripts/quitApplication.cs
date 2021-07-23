using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitApplication : MonoBehaviour
{
    // Update is called once per frame
    public void btnQuit()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
