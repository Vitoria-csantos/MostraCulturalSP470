using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int collectiblesCount = 0;
    public int requiredCollectibles = 5;

    private void Awake()
    {
        // Garantir que h� apenas uma inst�ncia do GameManager
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // N�o destruir este objeto ao mudar de cena
        }
        else
        {
            Destroy(gameObject); // Destruir duplicados
        }
    }

    public void AddCollectible()
    {
        collectiblesCount++;
        Debug.Log("Coletados: " + collectiblesCount);

        // Aqui voc� pode verificar se a contagem atingiu o n�mero necess�rio
        if (collectiblesCount >= requiredCollectibles)
        {
            // Chame uma fun��o para iniciar a cutscene ou outra l�gica
            Debug.Log("Iniciar cutscene!");
        }
    }
}