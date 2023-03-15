using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WeaponAssembler : Singleton<WeaponAssembler>
{
    [SerializeField] GameObject[] gripsList;
    [SerializeField] GameObject[] barrelList;
    [SerializeField] GameObject[] bodyList;
    [SerializeField] GameObject[] magList;
    [SerializeField] GameObject[] scopeList;
    [SerializeField] GameObject[] stockList;
    GameObject Weapon = null;

    private void Start()
    {
        //Instantiate(CreateWeapon(), transform.position, Quaternion.identity);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Weapon = CreateWeapon();
            Weapon.AddComponent<Rigidbody>();
            Weapon.AddComponent<BoxCollider>();

        }
    }

    public GameObject CreateWeapon()
    {
        Destroy(Weapon);
        GameObject grip = gripsList[Random.Range(0, gripsList.Length)];
        GameObject barrel = barrelList[Random.Range(0, barrelList.Length)];
        GameObject body = bodyList[Random.Range(0, bodyList.Length)];
        GameObject mag = magList[Random.Range(0, magList.Length)];
        GameObject scope = scopeList[Random.Range(0, scopeList.Length)];
        GameObject stock = stockList[Random.Range(0, stockList.Length)];
        GameObject weapon = new GameObject("Weapon");

        GameObject bodyInstance = Instantiate(body, weapon.transform);
        GameObject barrelInstance = Instantiate(barrel, weapon.transform);
        GameObject gripInstance = Instantiate(grip, weapon.transform);
        GameObject magInstance = Instantiate(mag, weapon.transform);
        GameObject scopeInstance = Instantiate(scope, weapon.transform);
        GameObject stockInstance = Instantiate(stock, weapon.transform);
        return weapon;


        /* bodyInstance.transform.localPosition = Vector3.zero;
         barrelInstance.transform.localPosition = Vector3.zero;
         gripInstance.transform.localPosition = Vector3.zero;
         magInstance.transform.localPosition = Vector3.zero;
         scopeInstance.transform.localPosition = Vector3.zero;
         stockInstance.transform.localPosition = Vector3.zero;*/
    }

}
