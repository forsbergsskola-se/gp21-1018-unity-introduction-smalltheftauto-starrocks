using System;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    enum Weapon
    {
        Pistol = 0,
        MachineGun = 1,
        Fist = 2
    }

    public GameObject[] inventory;

    private void Start()
    {
        
    }

    private void Update()
    {
        EquipeWeapon(Weapon.Fist);
    }

    private void EquipeWeapon(Weapon weapon)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (weapon == (Weapon) i) inventory[i].SetActive(true);
            else inventory[i].SetActive(false);
        }
    }
}
