using UnityEngine;
using TMPro;

public class DialogueBox : MonoBehaviour
{
    [SerializeField]
    GameObject gameStateObject;
    private GameState gameState;
    public DialogueTree dialogueTree;
    private TMP_Text dialogueText, speakerName;

    void Start()
    {
        gameState = gameStateObject.GetComponent<GameState>();
        dialogueTree = null;
        dialogueText = transform.Find("DialogueText").gameObject.GetComponent<TMP_Text>();
        speakerName = transform.Find("SpeakerName").gameObject.GetComponent<TMP_Text>();
    }

    public void Activate(){
        speakerName.text = dialogueTree.nodes[0].name;
        dialogueText.text = dialogueTree.nodes[0].text;
    }

    
    
}
