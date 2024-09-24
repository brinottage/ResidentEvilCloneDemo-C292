using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected int ammoCapacity;
    [SerializeField] protected int currentLoadedAmmo;
    [SerializeField] protected int currentSpareAmmo;
    [SerializeField] protected bool canFire;

    [SerializeField] protected bool fullLoaded;
    [SerializeField] protected Transform firePoint;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentLoadedAmmo > 0) {
            canFire = true;
        } else {
            canFire = false;
        }
    }

    protected virtual void Reload() {
        if (currentSpareAmmo < ammoCapacity) {

            if (currentSpareAmmo > 0) {
                int bulletsToLoad = ammoCapacity - currentLoadedAmmo;
                if (currentSpareAmmo >= bulletsToLoad) {
                    currentLoadedAmmo = ammoCapacity;
                    currentSpareAmmo -= bulletsToLoad;
                } else {
                    currentLoadedAmmo = currentLoadedAmmo + currentSpareAmmo;
                }
            }

        }

    }

    protected virtual void Fire() {

        RaycastHit hit;

        
       
    }


}
