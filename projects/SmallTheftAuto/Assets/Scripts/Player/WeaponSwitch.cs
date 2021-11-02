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

    private int counter;
    
    private void Start()
    {
        counter = 2;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ChangeCounter();
            SwitchWeapon();
        } 
    }

    private void ChangeCounter()
    {
        if (counter >= 2) counter = 0;
        else counter++;
    }

    private void SwitchWeapon()
    {
        Weapon currentWeapon = Weapon.Fist;

        switch (counter)
        {
            case 0:
                currentWeapon = Weapon.Pistol; 
                break;
            
            case 1:
                currentWeapon = Weapon.MachineGun;
                break;
            
            case 2:
                currentWeapon = Weapon.Fist;
                break;
        }
        
        EquipeWeapon(currentWeapon);
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
