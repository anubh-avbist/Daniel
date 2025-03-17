using UnityEngine;


public class NPC : MonoBehaviour
{


    [SerializeField]
    public GameObject gameStateObject;
    private GameState gameState;

    public float health;
    public bool interactable, highlighted, moving;
    
    UnityEngine.AI.NavMeshAgent nav;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gameState = this.gameStateObject.GetComponent<GameState>();


        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(highlighted){
            Debug.Log(gameState.dummyValue);
        }
    }
}
