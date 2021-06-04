using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class NewPhraseRecognition : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();
    
    public AudioClip intro;
    public AudioClip who;
    public AudioClip Languages;
    public AudioClip Finance;
    public AudioClip Environment;
    public AudioClip Population;
    public AudioClip Poverty;
    public AudioClip Import;
    public AudioClip Fame;
    public AudioClip Disasters;
    public AudioClip Deforestation;
    public AudioClip Culture;
    public AudioClip Gov;
    public AudioClip NGO;
    public AudioClip Species;
    public AudioSource audio;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //Create keywords for keyword recognizer
        keywords.Add("Where is Vanuatu", () =>
        {
            audio.Stop();
            audio.PlayOneShot(intro);
        });
        keywords.Add("Who lives on Vanuatu", () =>
        {
            audio.Stop();
            audio.PlayOneShot(who);
        });
        keywords.Add("What languages are spoken in Vanuatu", () =>
        {
            audio.Stop();
            audio.PlayOneShot(Languages);
        });

        keywords.Add("How is Vanuatu doing financially", () =>
        {
            audio.Stop();
            audio.PlayOneShot(Finance);
        });

        keywords.Add("What is a major environmental problem in Vanuatu", () =>
        {
            audio.Stop();
            audio.PlayOneShot(Environment);
        });

        keywords.Add("What problems did population growth bring", () =>
        {
            audio.Stop();
            audio.PlayOneShot(Population);
        });

        keywords.Add("What does planet save do to help those living in poverty", () =>
        {
            audio.Stop();
            audio.PlayOneShot(Poverty);
        });

        keywords.Add("What does Vanuatu import and export", () =>
        {
            audio.Stop();
            audio.PlayOneShot(Import);
        });

        keywords.Add("What is Vanuatu known for", () =>
        {
            audio.Stop();
            audio.PlayOneShot(Fame);
        });

        //Create keywords for keyword recognizer
        keywords.Add("What other organizations are helping vanuatu", () =>
        {
            audio.Stop();
            audio.PlayOneShot(NGO);
        });

        //Create keywords for keyword recognizer
        keywords.Add("What kind of government does vanuatu have", () =>
        {
            audio.Stop();
            audio.PlayOneShot(Gov);
        });

        //Create keywords for keyword recognizer
        keywords.Add("How does logging affect vanautu", () =>
        {
            audio.Stop();
            audio.PlayOneShot(Deforestation);
        });

        //Create keywords for keyword recognizer
        keywords.Add("What are some threatened species in vanuatu", () =>
        {
            audio.Stop();
            audio.PlayOneShot(Species);
        });

        //Create keywords for keyword recognizer
        keywords.Add("What is nee vanuatu culture like", () =>
        {
            audio.Stop();
            audio.PlayOneShot(Culture);
        });

        //Create keywords for keyword recognizer
        keywords.Add("What natural disasters threaten Vanuatu", () =>
        {
            audio.Stop();
            audio.PlayOneShot(Disasters);
        });
        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;
        // if the keyword recognized is in our dictionary, call that Action.
        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }
}
