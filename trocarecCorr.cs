using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class trocarecCorr : MonoBehaviour
{

    public string Corredor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("a01preCorridor");
        }
    }






}
   
            
       