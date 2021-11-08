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
        // Note:
        // Consider putting the number 2 in a variable to increase readability and avoid magic number
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
        // Note:
        // Consider using a switch expression, which does the same thing but less code to write. 
        // Weapon currentWeapon = counter switch
        // {
        //     1 => Weapon.MachineGun,
        //     2 => Weapon.Fist,
        //     _ => Weapon.Pistol
        // };

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
