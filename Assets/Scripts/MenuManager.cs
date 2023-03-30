using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public void LoadGameScene()
    {
        Invoke("LoadGameSceneDelay", 0.5f);
        
    }

    private void LoadGameSceneDelay()
    {
        SceneManager.LoadScene("Game");
    }
}
