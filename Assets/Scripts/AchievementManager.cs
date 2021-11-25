using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementManager : MonoBehaviour
{
    public Text Ui;
    public string TextAchi;

    public Animator _animator;
    
    private bool _startDaGame = false;
    private bool _startDaGameThree = false;
    private bool _startDaGameTen = false;
    private int _startCount;
    private bool _pushX = false;
    private bool _pushSpace = false;
    private bool _hug = false;

    private bool _min = false;
    private bool _threemin = false;

    void Start()
    {
        Movement.StartDaGame += delegate
        {
            _startCount++;
            
            if (!_startDaGame)
            {
                TextAchi = "Un petit pas pour toi \n (Tu as démaré le jeu)";
                Ui.text = TextAchi;
                _animator.SetTrigger("Achi");
                _startDaGame = true;
            }
            
            if (_startCount >= 4 && !_startDaGameThree)
            {
                TextAchi = "Comment qu'on joue ? \n (Tes mort 3 fois mdrrr)";
                Ui.text = TextAchi;
                _animator.SetTrigger("Achi");
                _startDaGameThree = true;
            }
            if (_startCount >= 11 && !_startDaGameTen)
            {
                TextAchi = "Suicidaire \n (Tes mort 10 fois. Pourquoi ?)";
                Ui.text = TextAchi;
                _animator.SetTrigger("Achi");
                _startDaGameTen = true;
            }
        };
        
        Movement.PushX += delegate
        {
            if (!_pushX)
            {
                _pushX = true;
                TextAchi = "BOUTON \n (Appuie sur X)";
                Ui.text = TextAchi;
                _animator.SetTrigger("Achi");
            }
        };
        Movement.PushSpace += delegate
        {
            if (!_pushSpace)
            {
                _pushSpace = true;
                TextAchi = "Pas de jambe \n (Appuie sur Espace)";
                Ui.text = TextAchi;
                _animator.SetTrigger("Achi");
            }
        };
        
        Movement.Hug += delegate
        {
            if (!_hug)
            {
                _hug = true;
                TextAchi = "Tendresse <3 \n (Faite un calin a Mr.Cube)";
                Ui.text = TextAchi;
                _animator.SetTrigger("Achi");
            }
        };
        
        MrCube.KillMrCube += delegate
        {
            TextAchi = "Sparta ? \n (Tuer Mr.Cube)";
            Ui.text = TextAchi;
            _animator.SetTrigger("Achi");
        };
        
        Timer.Minute += delegate
        {
            if (!_min)
            {
                _min = true;
                TextAchi = "L'horloge tourne \n (1 minute est passé)";
                Ui.text = TextAchi;
                _animator.SetTrigger("Achi");  
            }
           
        };
        
        Timer.ThreeMinute += delegate
        {
            if (!_threemin)
            {
                _threemin = true;
                TextAchi = "Le choix de Fred \n (2 minute est passé, il est l'heure de noté)";
                Ui.text = TextAchi;
                _animator.SetTrigger("Achi");  
            }
        };
        
        Timer.ClaquetteSound += delegate
        {
            TextAchi = "Pour Tibo <3 <3 \n (Effectue une préstation de claquette)";
            Ui.text = TextAchi;
            _animator.SetTrigger("Achi"); 
        };
        
        Timer.ClubSound += delegate
        {
            TextAchi = "EVRIBODI DOU ZE BONNS \n (TU TU TU TU, TUTUTUTUTUTUTU)";
            Ui.text = TextAchi;
            _animator.SetTrigger("Achi"); 
        };
    }
    
}
