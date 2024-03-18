using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    Transform enemigo;
    public bool detectadoEnemigo;
    private Animator controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        int mascara = 1 << 6;

        Collider[] detectado = Physics.OverlapSphere(transform.position, 5f, mascara);

        if (detectado.Length > 0)
        {
            //enemigo = detectado[0].transform;
            enemigo = detectado[0].transform;
            detectadoEnemigo = true;

        }
        if (detectadoEnemigo == true)
        {
            transform.LookAt(enemigo.transform.position);
            controller.SetBool("Detectado", detectadoEnemigo);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 5f);
    }
}
