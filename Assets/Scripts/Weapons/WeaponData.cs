using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="BaseWeaponData", menuName = "ScriptableObjects/WeaponData",order = 1)]
public class WeaponData : ScriptableObject
{
    public float reloadSpeed = 1f;
    public float fireRate = 1.5f;
    public int magSize = 8;
    public int damage = 100;
    public float accuracy= 90f;

    public int levelRq = 1;
    public int price = 1000;


}
