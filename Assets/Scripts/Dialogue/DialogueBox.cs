using UnityEngine;

public class DialogueBox : MonoBehaviour
{
    [SerializeField]
    GameObject gameStateObject;
    private GameState gameState;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameState = gameStateObject.GetComponent<GameState>();
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
