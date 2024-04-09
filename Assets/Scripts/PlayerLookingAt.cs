using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookingAt : MonoBehaviour
{
    public LayerMask objectLayers;

    public bool lookingAtCamera;
    public bool lookingAtLevel;

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out var hitObject, Mathf.Infinity, objectLayers))
        {
            if (hitObject.transform.gameObject.tag == "Camera")
            {
                lookingAtCamera = true;
                lookingAtLevel = false;
                // lookingAtEnemy2 = false;
                // lookingAtEnemy3 = false;

            }

            if (hitObject.transform.gameObject.tag == "Level")
            {
                lookingAtLevel = true;
                lookingAtCamera = false;
                // lookingAtEnemy2 = false;
                // lookingAtEnemy3 = false;

            }

            /* Use for different enemies
             * 
                        if (hitResource.transform.gameObject.tag == "Enemy2")
                        {

                            lookingAtEnemy2 = true;
                            lookingAtCamera = false;
                            lookingAtEnemy3 = false;

                        }

                        if (hitResource.transform.gameObject.tag == "Enemy3")
                        {
                            lookingAtEnemy3 = true;
                            lookingAtCamera = false;
                            lookingAtEnemy2 = false;
                        }
            */
        }
        else
        {
            lookingAtCamera = false;
            lookingAtLevel = false;
            // lookingAtEnemy2 = false;
            // lookingAtEnemy3 = false;
        }
    }
}