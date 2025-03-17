using UnityEngine;


public class NPC : MonoBehaviour
{
    [SerializeField]
    public GameObject gameStateObject;
    private GameState gameState;
    public float health;
    public bool interactable, highlighted, moving, currentlyTalking;
    
    UnityEngine.AI.NavMeshAgent nav;
    DialogueTree dialogueTree;

    void ActivateDialogue(){
        // Make UI Visible
        gameState.dialogueBox.SetActive(true);

        // Send Correct DialogueTree To UI
        DialogueBox dialogueBox = gameState.dialogueBox.GetComponent<DialogueBox>();
        dialogueBox.dialogueTree = dialogueTree;

        // Activate Tree on UI
        dialogueBox.Activate();
    }

    void Start()
    {
        this.gameState = this.gameStateObject.GetComponent<GameState>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        dialogueTree = GetComponent<DialogueTree>(); 
    }

    void Update()
    {
        if(highlighted){
            if(currentlyTalking && interactable){
                ActivateDialogue();
                currentlyTalking = false;
            }
        }
    }
}
