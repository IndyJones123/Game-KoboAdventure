using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pekora : MonoBehaviour
{
    public GameObject dialoguePanel;
    // public GameObject Player;
    [SerializeField] private AudioClip ketawa;
    public GameObject Fang;
    public GameObject Penculik;
    public Text dialogueText;
    public string[] dialogue;
    private int index;

    public GameObject contButton;
    public GameObject yesButton;
    public GameObject noButton;
    public GameObject TriggerBlok;
    public GameObject Rabbit;
    // public Animator animation;
    // public PlayerMovement movementplayer;
    public float wordSpeed;
    public bool playerIsClose;


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
                contButton.SetActive(true);
                yesButton.SetActive(false);
                noButton.SetActive(false);
            }

        }

        if(dialogueText.text == dialogue[index])
        {
            
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
        yesButton.SetActive(false);
        noButton.SetActive(false);
        
       
        if(index == 4)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
            contButton.SetActive(false);
            yesButton.SetActive(true);
            noButton.SetActive(true);
        }

        if(index < 5)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        // else
        // {
        //     zeroText();
        //     Destroy(gameObject);
        // }
    }
    
    public void No()
    {
        yesButton.SetActive(false);
        noButton.SetActive(false);

        index = 8;

        if(index < 9)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
            // animation = Player.GetComponent<Animator>();
            // movementplayer = Player.GetComponent<PlayerMovement>();
            // movementplayer.enabled = false;
            // animation.SetTrigger("Monster");
            SoundManagerScript.instance.PlaySound(ketawa);
            Penculik.SetActive(true);
            Destroy(dialoguePanel,3);
            Destroy(gameObject,2);
        }

    }
    
    public void Yes()
    {
        yesButton.SetActive(false);
        noButton.SetActive(false);

        index = 9;

        if(index < 10)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
            Fang.SetActive(true);
            Destroy(dialoguePanel,3);
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
