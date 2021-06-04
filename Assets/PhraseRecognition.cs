using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class PhraseRecognition : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();


    public AudioSource Introduction;
    public AudioSource Lives;
    public AudioSource Languages;
    public AudioSource Finance;
    public AudioSource Environment;
    public AudioSource Population;
    public AudioSource Poverty;
    public AudioSource Import;
    public AudioSource Fame;
    public AudioSource Disasters;
    public AudioSource Deforestation;
    public AudioSource Culture;
    public AudioSource Gov;
    public AudioSource NGO;
    public AudioSource Species;

    void Start()
    {
        //Create keywords for keyword recognizer
        keywords.Add("Where is Vanuatu", () =>
        {
            // action to be performed when this keyword is spoken
            ActivateCalled();
        });

        keywords.Add("Who lives on Vanuatu", () =>
        {
            // action to be performed when this keyword is spoken
            BetaCalled();
        });

        keywords.Add("What languages are spoken in Vanuatu", () =>
        {
            // action to be performed when this keyword is spoken
            CharlieCalled();
        });

        keywords.Add("How is Vanuatu doing financially", () =>
        {
            // action to be performed when this keyword is spoken
            DeltaCalled();
        });

        keywords.Add("What is a major environmental problem in Vanuatu", () =>
        {
            // action to be performed when this keyword is spoken
            EpsilonCalled();
        });

        keywords.Add("What problems did population growth bring", () =>
        {
            // action to be performed when this keyword is spoken
            FoxtrotCalled();
        });

        keywords.Add("What does planet save do to help those living in poverty", () =>
        {
            // action to be performed when this keyword is spoken
            GammaCalled();
        });

        keywords.Add("What does Vanuatu import and export", () =>
        {
            // action to be performed when this keyword is spoken
            HeliosCalled();
        });

        keywords.Add("What is Vanuatu known for", () =>
        {
            // action to be performed when this keyword is spoken
            IsultCalled();
        });

        //Create keywords for keyword recognizer
        keywords.Add("What other organizations are helping vanuatu", () =>
        {
            // action to be performed when this keyword is spoken
            KainaCalled();
        });

        //Create keywords for keyword recognizer
        keywords.Add("What kind of government does vanuatu have", () =>
        {
            // action to be performed when this keyword is spoken
            ShizukuCalled();
        });

        //Create keywords for keyword recognizer
        keywords.Add("How does logging affect vanautu", () =>
        {
            // action to be performed when this keyword is spoken
            KagariCalled();
        });

        //Create keywords for keyword recognizer
        keywords.Add("What are some threatened species in vanuatu", () =>
        {
            // action to be performed when this keyword is spoken
            HayateCalled();
        });

        //Create keywords for keyword recognizer
        keywords.Add("What is nee vanuatu culture like", () =>
        {
            // action to be performed when this keyword is spoken
            ReiCalled();
        });

        //Create keywords for keyword recognizer
        keywords.Add("What natural disasters threaten Vanuatu", () =>
        {
            // action to be performed when this keyword is spoken
            EngageCalled();
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
    void ActivateCalled()
    {
        Lives.Stop();
        Languages.Stop();
        Finance.Stop();
        Environment.Stop();
        Population.Stop();
        Poverty.Stop();
        Import.Stop();
        Fame.Stop();
        Introduction.Play();
        Disasters.Stop();
        Deforestation.Stop();
        Culture.Stop();
        Gov.Stop();
        NGO.Stop();
        Species.Stop();

    }

    void BetaCalled()
    {
        Introduction.Stop();
        Lives.Stop();
        Languages.Stop();
        Environment.Stop();
        Population.Stop();
        Poverty.Stop();
        Import.Stop();
        Fame.Stop();
        Finance.Play();
        Disasters.Stop();
        Deforestation.Stop();
        Culture.Stop();
        Gov.Stop();
        NGO.Stop();
        Species.Stop();
    }

    void CharlieCalled()
    {
        Introduction.Stop();
        Lives.Stop();
        Languages.Stop();
        Finance.Stop();
        Environment.Stop();
        Population.Stop();
        Poverty.Play();
        Import.Stop();
        Fame.Stop();
        Disasters.Stop();
        Deforestation.Stop();
        Culture.Stop();
        Gov.Stop();
        NGO.Stop();
        Species.Stop();
    }

    void DeltaCalled()
    {
        Introduction.Stop();
        Lives.Stop();
        Languages.Stop();
        Finance.Stop();
        Environment.Stop();
        Population.Stop();
        Poverty.Stop();
        Import.Stop();
        Fame.Play();
        Disasters.Stop();
        Deforestation.Stop();
        Culture.Stop();
        Gov.Stop();
        NGO.Stop();
        Species.Stop();
    }

    void EpsilonCalled()
    {
        Introduction.Stop();
        Lives.Stop();
        Languages.Stop();
        Finance.Stop();
        Environment.Stop();
        Poverty.Stop();
        Import.Stop();
        Fame.Stop();
        Population.Play();
        Disasters.Stop();
        Deforestation.Stop();
        Culture.Stop();
        Gov.Stop();
        NGO.Stop();
        Species.Stop();
    }

    void FoxtrotCalled()
    {
        Introduction.Stop();
        Lives.Play();
        Languages.Stop();
        Finance.Stop();
        Environment.Stop();
        Population.Stop();
        Poverty.Stop();
        Import.Stop();
        Fame.Stop();
        Disasters.Stop();
        Deforestation.Stop();
        Culture.Stop();
        Gov.Stop();
        NGO.Stop();
        Species.Stop();
    }

    void GammaCalled()
    {
        Introduction.Stop();
        Lives.Stop();
        Languages.Stop();
        Finance.Stop();
        Environment.Stop();
        Population.Stop();
        Poverty.Stop();
        Import.Play();
        Fame.Stop();
        Disasters.Stop();
        Deforestation.Stop();
        Culture.Stop();
        Gov.Stop();
        NGO.Stop();
        Species.Stop();
    }

    void HeliosCalled()
    {
        Introduction.Stop();
        Lives.Stop();
        Languages.Play();
        Finance.Stop();
        Environment.Stop();
        Population.Stop();
        Poverty.Stop();
        Import.Stop();
        Fame.Stop();
        Disasters.Stop();
        Deforestation.Stop();
        Culture.Stop();
        Gov.Stop();
        NGO.Stop();
        Species.Stop();
    }

    void IsultCalled()
    {
        Introduction.Stop();
        Lives.Stop();
        Languages.Stop();
        Finance.Stop();
        Environment.Play();
        Population.Stop();
        Poverty.Stop();
        Import.Stop();
        Fame.Stop();
        Disasters.Stop();
        Deforestation.Stop();
        Culture.Stop();
        Gov.Stop();
        NGO.Stop();
        Species.Stop();
    }

    void KainaCalled()
    {
        Introduction.Stop();
        Lives.Stop();
        Languages.Stop();
        Finance.Stop();
        Environment.Stop();
        Population.Stop();
        Poverty.Stop();
        Import.Stop();
        Fame.Stop();
        Disasters.Stop();
        Deforestation.Stop();
        Culture.Stop();
        Gov.Stop();
        NGO.Play();
        Species.Stop();
    }

    void ShizukuCalled()
    {
        Introduction.Stop();
        Lives.Stop();
        Languages.Stop();
        Finance.Stop();
        Environment.Stop();
        Population.Stop();
        Poverty.Stop();
        Import.Stop();
        Fame.Stop();
        Disasters.Stop();
        Deforestation.Stop();
        Culture.Stop();
        Gov.Play();
        NGO.Stop();
        Species.Stop();
    }

    void KagariCalled()
    {
        Introduction.Stop();
        Lives.Stop();
        Languages.Stop();
        Finance.Stop();
        Environment.Stop();
        Population.Stop();
        Poverty.Stop();
        Import.Stop();
        Fame.Stop();
        Disasters.Stop();
        Deforestation.Play();
        Culture.Stop();
        Gov.Stop();
        NGO.Stop();
        Species.Stop();
    }

    void HayateCalled()
    {
        Introduction.Stop();
        Lives.Stop();
        Languages.Stop();
        Finance.Stop();
        Environment.Stop();
        Population.Stop();
        Poverty.Stop();
        Import.Stop();
        Fame.Stop();
        Disasters.Stop();
        Deforestation.Stop();
        Culture.Stop();
        Gov.Stop();
        NGO.Stop();
        Species.Play();
    }

    void ReiCalled()
    {
        Introduction.Stop();
        Lives.Stop();
        Languages.Stop();
        Finance.Stop();
        Environment.Stop();
        Population.Stop();
        Poverty.Stop();
        Import.Stop();
        Fame.Stop();
        Disasters.Stop();
        Deforestation.Stop();
        Culture.Play();
        Gov.Stop();
        NGO.Stop();
        Species.Stop();
    }

    void EngageCalled()
    {
        Introduction.Stop();
        Lives.Stop();
        Languages.Stop();
        Finance.Stop();
        Environment.Stop();
        Population.Stop();
        Poverty.Stop();
        Import.Stop();
        Fame.Stop();
        Disasters.Play();
        Deforestation.Stop();
        Culture.Stop();
        Gov.Stop();
        NGO.Stop();
        Species.Stop();
    }
}