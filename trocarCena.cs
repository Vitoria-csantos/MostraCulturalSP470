using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class colission : MonoBehaviour
{
    public string nomeProximaFase;

    private void OnTriggerEnter(Collider collision)
    {
        IrProximaFase();
    }

    private void IrProximaFase()
    {
        SceneManager.LoadScene(this.nomeProximaFase);


    }
}

