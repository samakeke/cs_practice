using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    [SerializeField]
    private Text inputFieldText;

    static public string p_name;

    public void PlayerNameInput()
    {
        p_name = inputFieldText.text;

        Debug.Log("PLAYER NAME = " + p_name);
    }
}