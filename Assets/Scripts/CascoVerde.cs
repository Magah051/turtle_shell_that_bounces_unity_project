using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CascoVerde : MonoBehaviour
{
    [Header("Referências Gerais")]
    private Rigidbody2D oRigidbody2D;

    [Header("Rebater Casco")]
    [SerializeField] private float velocidadeHorizontal;
    [SerializeField] private float tamanhoDoRaioDeVerificacao;
    [SerializeField] private Transform verificadorDaEsquerda;
    [SerializeField] private Transform verificadorDaDireita;
    [SerializeField] private LayerMask layersParaColidir;


    private void Awake()
    {
        oRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        verificarAmbiente();
    }

    private void verificarAmbiente()
    {
        if (Physics2D.OverlapCircle(verificadorDaEsquerda.position, tamanhoDoRaioDeVerificacao, layersParaColidir))
        {
            ImpulsionaParaDireita();
        }
        else if (Physics2D.OverlapCircle(verificadorDaDireita.position, tamanhoDoRaioDeVerificacao, layersParaColidir))
        {
            ImpulsionaParaEsquerda();
        }

    }

    private void ImpulsionaParaEsquerda()
    {
        oRigidbody2D.AddForce(-transform.right * velocidadeHorizontal);
    }

    private void ImpulsionaParaDireita()
    {
        oRigidbody2D.AddForce(transform.right * velocidadeHorizontal);
    }

    private void OnDrawGizmos()
    {
        //Desenham os verificadores laterais na aba Scene
        Gizmos.DrawWireSphere(verificadorDaEsquerda.position, tamanhoDoRaioDeVerificacao);
        Gizmos.DrawWireSphere(verificadorDaDireita.position, tamanhoDoRaioDeVerificacao);
    }


}
