using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CajaColisionDetection : MonoBehaviour
{
    float[] posicionesX= {-2, 0, 2};
    public TextMeshProUGUI txt_perdiste;
    public TextMeshProUGUI txt_tiempo;
    float tiempo;
    bool perdio = false;
    // Start is called before the first frame update
    void Start()
    {
         txt_perdiste.gameObject.SetActive(false);
         txt_tiempo.text = tiempo.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (perdio == false){
        tiempo += Time.deltaTime;
        txt_tiempo.gameObject.SetActive(true);
        txt_tiempo.text = tiempo.ToString();
    }}
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("colision con " + col.gameObject.name);
        if(col.gameObject.CompareTag("Player"))
        {
        Destroy(col.gameObject);
        txt_perdiste.gameObject.SetActive(true);
        perdio = true;

    }
     else if(col.gameObject.CompareTag("piso"))
        {
            int NuevaPosicion = Random.Range(0, posicionesX.Length);
            float posicionX = posicionesX[NuevaPosicion];
            transform.position = new Vector3(posicionX, 10f, 0f);
            GetComponent<Rigidbody>().velocity =
    new Vector3
    (
        0f,
        GetComponent<Rigidbody>().velocity.y,
        0f
    );
    }
    }
}
