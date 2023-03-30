using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickSound : MonoBehaviour
{
   
    public Button button;

    private void Awake()
    {
        button.onClick.AddListener(ButtonSound);
    }
    public void ButtonSound()
    {
        AudioManager.Instance.PlayButton();
    }

}
