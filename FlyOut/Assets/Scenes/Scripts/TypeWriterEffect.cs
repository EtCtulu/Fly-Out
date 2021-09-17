using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriterEffect : MonoBehaviour
{
    
    public float delay = 0.1f;
    public string fullText;

    private string currentText = "";

    private Text text;

    private float timer;
    private bool textComplete;

    public float timerBeforeDisapear = 5f;

    void Start()
    {
        text = this.GetComponent<Text>();
        StartCoroutine(ShowText());
    }

    private void Update() {
        if(textComplete == true){{
            if(timer <= timerBeforeDisapear){
            timer = timer + Time.deltaTime;
            }
            else{
                currentText = "";
                fullText = "";
                text.text = fullText;
                textComplete = false;
                timer = 0f;
                Debug.Log("Timer Went Out");
                return;
            }
        }}
    }

    IEnumerator ShowText()
    {
        for(int i = 0; i < fullText.Length; i++){
            currentText = fullText.Substring(0,i);
            text.text = currentText;
            yield return new WaitForSeconds(delay);
        }
        
        textComplete = true;
        Debug.Log("Coroutine Stopped");
        StopCoroutine(ShowText());
        yield return 0;
    }

    public void UpdateText(string newText){
        fullText = newText;
        StartCoroutine(ShowText());
    }

}
