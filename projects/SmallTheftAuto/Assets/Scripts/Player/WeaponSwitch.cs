using System;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSwitch : MonoBehaviour
{
    //I like that you kept your code well separated in small scripts, it's easy to get an overview and
    //your code is very readable
    enum Weapon
    {
        Pistol = 0,
        MachineGun = 1,
        Fist = 2
    }

    public GameObject[] inventory;
    public GameObject[] weaponImages;

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
            if (weapon == (Weapon) i) {
                inventory[i].SetActive(true);
                weaponImages[i].SetActive(true);
            }
            else {
                inventory[i].SetActive(false);
                weaponImages[i].SetActive(false);

            }
        }
    }
}
