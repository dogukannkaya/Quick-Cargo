using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTransition : MonoBehaviour
{
    public Sprite oldSprite;
    public Sprite newSprite;
    public Button button;

    public void Change()
    {
        if (button.image.sprite == newSprite)
        {
            GameObject.FindGameObjectWithTag("audiomanager").GetComponent<AudioManager>().Play("Music");
            button.image.sprite = oldSprite;
        }
        else
        {
            GameObject.FindGameObjectWithTag("audiomanager").GetComponent<AudioManager>().Stop("Music");
            button.image.sprite = newSprite;
        }
    }
}
