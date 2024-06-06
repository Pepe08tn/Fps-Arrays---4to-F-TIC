using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeScript : MonoBehaviour
{
    public int nivelHambre;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TomarAliento(int valorAlimentario)
    {
        nivelHambre -= valorAlimentario;
        if(nivelHambre <= 0)
        {
            nivelHambre = 0;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        AlimentoScript alimento;
        alimento = other.GetComponent<AlimentoScript>();
        if(alimento)
        {
            TomarAliento(alimento.valorAlimentario);
            Destroy(other.gameObject);
        }
    }
}
