using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int collectiblesCount = 0;
    public int requiredCollectibles = 5;

    private void Awake()
    {
        // Garantir que há apenas uma instância do GameManager
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Não destruir este objeto ao mudar de cena
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

        // Aqui você pode verificar se a contagem atingiu o número necessário
        if (collectiblesCount >= requiredCollectibles)
        {
            // Chame uma função para iniciar a cutscene ou outra lógica
            Debug.Log("Iniciar cutscene!");
        }
    }
}