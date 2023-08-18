using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CascoVerde : MonoBehaviour
{
    private Rigidbody2D oRigidbody2D;
    [SerializeField] private float velocidadeHorizontal;
    [SerializeField] private float tamanhoDoRaioDeVerificacao;
    [SerializeField] private Transform verificadorDaEsquerda;
    [SerializeField] private Transform verificadorDaDireita;
    [SerializeField] private LayerMask layersParaColidir;


    private void Awake()
    {
        oRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ImpulsionaParaEsquerda()
    {
        oRigidbody2D.AddForce();
    }
}
