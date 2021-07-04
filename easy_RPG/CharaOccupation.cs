using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharaOccupation : MonoBehaviour
{
    [SerializeField]
    private Button warriorButton;
    [SerializeField]
    private Button monkButton;
    [SerializeField]
    private Button blackMageButton;
    [SerializeField]
    private Button whiteMageButton;
    [SerializeField]
    private Text text;

    private OccupationStatus occupationStatus;

    void Start()
    {
        text.text = (InputName.p_name + " ‚³‚ñA‚æ‚¤‚±‚»");

        warriorButton.onClick.AddListener(() =>
        {

            occupationStatus = new OccupationStatus();

            OccupationStatus.GetOccupationStatus_hp = 10;
            OccupationStatus.GetOccupationStatus_atk = 2;

            Debug.Log("WarriorSelsect");
        });

        monkButton.onClick.AddListener(() =>
        {
            occupationStatus = new OccupationStatus();

            OccupationStatus.GetOccupationStatus_hp = 8;
            OccupationStatus.GetOccupationStatus_atk = 3;

            Debug.Log("MonkSelect");
        });

        blackMageButton.onClick.AddListener(() =>
        {
            occupationStatus = new OccupationStatus();

            OccupationStatus.GetOccupationStatus_hp = 5;
            OccupationStatus.GetOccupationStatus_atk = 3;

            Debug.Log("BlackMageSelect");
        });

        whiteMageButton.onClick.AddListener(() =>
        {
            occupationStatus = new OccupationStatus();

            OccupationStatus.GetOccupationStatus_hp = 5;
            OccupationStatus.GetOccupationStatus_atk = 1;

            Debug.Log("WhiteMageSelect");
        });
    }
}

public class OccupationStatus
{
    static private int hp;
    static private int atk;

    static public int GetOccupationStatus_hp
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value;
        }
    }

    static public int GetOccupationStatus_atk
    {
        get
        {
            return atk;
        }
        set
        {
            atk = value;
        }
    }
}