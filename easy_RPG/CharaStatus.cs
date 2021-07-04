using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharaStatus : MonoBehaviour
{
    [SerializeField]
    private Text enemyHP;

    [SerializeField]
    private Text playerHP;
    [SerializeField]
    private Text playerNAME;
    [SerializeField]
    private Text partyMEMBER1_name;
    [SerializeField]
    private Text partyMEMBER1_hp;
    [SerializeField]
    private Text partyMEMBER2_name;
    [SerializeField]
    private Text partyMEMBER2_hp;
    [SerializeField]
    private Text partyMEMBER3_name;
    [SerializeField]
    private Text partyMEMBER3_hp;

    EasyEnemyStatus easyEnemyStatus;

    void Start()
    {
        easyEnemyStatus = new EasyEnemyStatus();
        easyEnemyStatus.GS_easyEnemy_eHp = 15;
        easyEnemyStatus.GS_easyEnemy_eAtk = 3;

        enemyHP.text += easyEnemyStatus.GS_easyEnemy_eHp;

        playerNAME.text = InputName.p_name;
        playerHP.text += OccupationStatus.GetOccupationStatus_hp;
        partyMEMBER1_hp.text += OccupationStatus.GetOccupationStatus_hp;        // èCê≥ó\íË
        partyMEMBER2_hp.text += OccupationStatus.GetOccupationStatus_hp;        // èCê≥ó\íË
        partyMEMBER3_hp.text += OccupationStatus.GetOccupationStatus_hp;        // èCê≥ó\íË

        Debug.Log("PLAYER HP : " + OccupationStatus.GetOccupationStatus_hp);
        Debug.Log("PLAYER ATK : " + OccupationStatus.GetOccupationStatus_atk);
        Debug.Log("ENEMY HP : " + easyEnemyStatus.GS_easyEnemy_eHp);
        Debug.Log("ENEMY ATK : " + easyEnemyStatus.GS_easyEnemy_eAtk);
    }
}

public abstract class EnemyStatus
{
    private int ehp;
    private int eatk;

    public abstract int GS_easyEnemy_eHp { get; set; }
    public abstract int GS_easyEnemy_eAtk { get; set; }
}

public class EasyEnemyStatus : EnemyStatus
{
    private int ehp;
    private int eatk;

    public override int GS_easyEnemy_eHp
    {
        get
        {
            return ehp;
        }
        set
        {
            ehp = value;
        }
    }

    public override int GS_easyEnemy_eAtk
    {
        get
        {
            return eatk;
        }
        set
        {
            eatk = value;
        }
    }
}

public class NormalEnemyStatus : EnemyStatus
{
    private int ehp;
    private int eatk;

    public override int GS_easyEnemy_eHp
    {
        get
        {
            return ehp;
        }
        set
        {
            ehp = value;
        }
    }

    public override int GS_easyEnemy_eAtk
    {
        get
        {
            return eatk;
        }
        set
        {
            eatk = value;
        }
    }
}

public class HardEnemyStatus : EnemyStatus
{
    private int ehp;
    private int eatk;

    public override int GS_easyEnemy_eHp
    {
        get
        {
            return ehp;
        }
        set
        {
            ehp = value;
        }
    }

    public override int GS_easyEnemy_eAtk
    {
        get
        {
            return eatk;
        }
        set
        {
            eatk = value;
        }
    }
}