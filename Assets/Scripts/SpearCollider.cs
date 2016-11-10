using UnityEngine;
using System.Collections;

public class SpearCollider : MonoBehaviour
{

    public static SpearCollider instance;

    void Awake()
    {
        instance = this;
    }

    void OnTriggerEnter(Collider other)
    {//may have to put on a script on player object, not player prefab. ya know, cuz this script controlls player and spear. Thats a pain...
        Debug.Log("Wat");
        if (other.gameObject.tag == "SpearPoint")
        {
            //die
            Debug.Log("Woe there");
        }

    }
}
