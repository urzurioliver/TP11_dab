using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float speed =1;
    float aceleracion = 0.05f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = speed + aceleracion*Time.deltaTime;
        transform.Translate(0,-speed * Time.deltaTime,0);
    }
}
//vector 3 es objeto que guarda 3 valores juntos: X;Y;Z.