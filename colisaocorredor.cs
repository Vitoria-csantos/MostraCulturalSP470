using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections.Generic;

public class colisaoCorredor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Corredorpassado");
        }
    }
}
