using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FangNPC : MonoBehaviour
{
    public GameObject dialoguePanel;
    public GameObject TriggerNewScene;
    public Text dialogueText;
    public string[] dialogue;
    private int index;
    private Animator anim;
    public GameObject contButton;
    public GameObject Rabbit;
    [SerializeField] private AudioClip KuasaBayang;
    
    public float wordSpeed;
    public bool playerIsClose;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {

            if (dialoguePanel.activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }

        }

        if(dialogueText.text == dialogue[index])
        {
            contButton.SetActive(true);
        }
    }


    public void zeroText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }


    IEnumerator Typing()
    {
        foreach(char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }


    public void NextLine()
    {

        contButton.SetActive(false);
        

        if(index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText();
            Rabbit.SetActive(true);
            TriggerNewScene.SetActive(true);
            anim.SetTrigger("KuasaBayang");
            SoundManagerScript.instance.PlaySound(KuasaBayang);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            zeroText();
        }
    }
}
