﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlotaTaxis : MonoBehaviour
{

    public int cantidadDeUnidades;
    public int periodoDeDias;

    float precioXDia = 90 / 15 * 130;

    // Start is called before the first frame update
    void Start()
    {
        float litrosXDia = cantidadDeUnidades * periodoDeDias * 90 / 15;
        float costoTotalCombustible = precioXDia * cantidadDeUnidades * periodoDeDias;


        if (cantidadDeUnidades < 1)
        {
            Debug.Log("Ingrese una cantidad de flotas >= a 1");
            return;
        }

        if(periodoDeDias < 5)
        {
            Debug.Log("Ingrese una cantidad de días >= a 5");
            return;
        }

        if(litrosXDia >= 100)
        {
            Debug.Log("Una flota de " + cantidadDeUnidades + " unidades trabajando durante " + periodoDeDias + " días implicaría un gasto de " +
            costoTotalCombustible * 0.8 + " pesos en concepto de combustible, ahorrando " + costoTotalCombustible * 0.2 + " pesos" + 
            " por descuento con convenio de estación de servicio.");
        }
        else
        {
            Debug.Log("Una flota de " + cantidadDeUnidades + " unidades trabajando durante " + periodoDeDias + " días implicaría un gasto de " +
            costoTotalCombustible + " pesos en concepto de combustible.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
