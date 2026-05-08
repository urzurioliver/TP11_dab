using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaColisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("colision con " + col.gameObject.name);
        if(col.gameObject.CompareTag("Player"))
        {
        Destroy(col.gameObject);
    }
     else if(col.gameObject.CompareTag("piso"))
        {
        Destroy(gameObject);
    }
    }
}
