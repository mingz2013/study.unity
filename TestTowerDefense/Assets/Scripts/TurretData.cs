using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 炮塔数据类
[System.Serializable]
public class TurretData
{
    public GameObject turretPrefab;
    public int cost;// 建造需要的金币
    public GameObject turretUpgradePrefab;
    public int costUpgrade; // 升级后金币
    public TurretType type;
}

public enum TurretType
{
    LaserTurret,
    MissileTurret,
    StandardTurret
}