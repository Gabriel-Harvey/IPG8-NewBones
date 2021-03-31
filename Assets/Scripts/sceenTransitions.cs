using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceenTransitions : MonoBehaviour
{
    public UIManager manager;

    public void Room()
    {
        manager.livesTransfer();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Room2()
    {
        manager.livesTransfer();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
