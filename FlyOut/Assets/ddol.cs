using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ddol : MonoBehaviour
{
    void Start()
    {
        if(GameObject.FindGameObjectsWithTag("Respawn").Length != 1){
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

}
