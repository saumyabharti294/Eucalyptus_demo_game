using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTalkZone : MonoBehaviour
{
    [SerializeField] private GameObject speechBubble;
    [SerializeField] private KeyCode talkKey=KeyCode.E;
    [SerializeField] private Text keyInputText;
    // Start is called before the first frame update

    private void Awake()
    {
        speechBubble.SetActive(false);
        keyInputText.text = talkKey.ToString();

    }

    void Update()
    {
        if(Input.GetKeyUp(talkKey) && speechBubble.activeSelf) {
            Debug.Log("Start Dialog");

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            speechBubble.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            speechBubble.gameObject.SetActive(false);
        }
    }
    

    // Update is called once per frame
    
}
