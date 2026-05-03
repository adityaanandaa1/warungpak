using System.Collections;
using UnityEngine;

public class Scene01Start : MonoBehaviour
{
    public GameObject fadeIn;
    public GameObject charRaka;
    public GameObject charIbu;
    public GameObject textBox;

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;
    [SerializeField] GameObject nextButton;
    [SerializeField] int eventPos = 0;
    [SerializeField] GameObject charName;
    [SerializeField] GameObject fadeOut;

   
    void Start()
    {
        StartCoroutine(EventStarter());
    }

    // Update is called once per frame
    void Update()
    {
        textLength = TextCreator.charCount;
    }

    IEnumerator EventStarter()
    {
        //event 0
        yield return new WaitForSeconds(2);    //perlu menunggu 2 detik, lalu kode selanjutnya di jalankan
        fadeIn.SetActive(false);
        charIbu.SetActive(true);
        yield return new WaitForSeconds(2);
        mainTextObject.SetActive(true);
        textToSpeak ="Raka . . . warung ini satu-satunya yang kita punya sekarang";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 1;
        
        
    }

    IEnumerator EventOne()
    {
        // event 1
        nextButton.SetActive(false);
        
        textBox.SetActive(true);

        textToSpeak ="Kalo kamu belum siap, Ibu bisa cari cara lain . . .";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 2;
    }

    IEnumerator EventTwo()
    {
        // event 2
        nextButton.SetActive(false);
        charRaka.SetActive(true);
        textBox.SetActive(true);
        yield return new WaitForSeconds(2);
        charName.GetComponent<TMPro.TMP_Text>().text = "Raka";
        textToSpeak ="Aku coba, Bu . . .";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true); 
        eventPos = 3;  
    }

    IEnumerator EventThree()
    {
        // event 3
        nextButton.SetActive(false);
        
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Ibu";

        textToSpeak ="Bapakmu dulu selalu bilang . . .";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 4;
    }

    IEnumerator EventFour()
    {
        // event 4
        nextButton.SetActive(false);
        
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Ibu";

        textToSpeak ="Warung ini bukan cuma tempat jualan.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 5;
    }

    IEnumerator EventFive()
    {
        // event 5
        nextButton.SetActive(false);
        
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Ibu";

        textToSpeak ="Ini tempat orang percaya.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;

        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 6;
    }

    IEnumerator EventSix()
    {
        // event 6
        nextButton.SetActive(false);
        
        textBox.SetActive(true);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
    }

    public void NextButton()
    {
        if (eventPos ==1)
        {
            StartCoroutine(EventOne());
        }
        else if (eventPos == 2)
        {
            StartCoroutine(EventTwo());
        }
        else if (eventPos == 3)
        {
            StartCoroutine(EventThree());
        }
        else if (eventPos == 4)
        {
            StartCoroutine(EventFour());
        }
        else if (eventPos == 5)
        {
            StartCoroutine(EventFive());
        }
        else if (eventPos == 6)
        {
            StartCoroutine(EventSix());
        }
    }
}
