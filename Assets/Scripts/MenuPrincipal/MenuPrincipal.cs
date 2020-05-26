using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Jogar;
    public GameObject Opcoes;
        public bool OnclickOp = false;
        public GameObject Som;
        public GameObject Musica;
        public GameObject Voltar;
    public GameObject Controle;
        public bool OnclickCon = false;
    public GameObject Sair;
  
    
   

    public void menuPrincipal()
    {
        SceneManager.LoadScene(1);
    }
    public void opcoes()
    {
            LeanTween.scale(Jogar, new Vector3(0, 0, 0), 0.2f);
            
            LeanTween.scale(Controle, new Vector3(0, 0, 0), 0.2f);
            
            LeanTween.scale(Sair, new Vector3(0, 0, 0), 0.2f);

            LeanTween.moveLocal(Opcoes, new Vector3(0, -66, 0), 0.5f).setOnComplete(OpcoesClose);
     }
    void OpcoesClose()
    {
        Som.SetActive(true);
        Musica.SetActive(true);
        Voltar.SetActive(true);
        Jogar.SetActive(false);
        Controle.SetActive(false);
        Sair.SetActive(false);
    }
    public void VoltarOpcoes()
    {
            LeanTween.moveLocal(Opcoes, new Vector3(97.2f, -120.84f, 0f), 0.5f).setOnComplete(OpcoesOpen);
            Voltar.SetActive(false);
            Musica.SetActive(false);
            Som.SetActive(false);
            

    }
        void OpcoesOpen()
        {
        
        Jogar.SetActive(true);
        LeanTween.scale(Jogar, new Vector3(1, 1, 1), 0.4f);
        Controle.SetActive(true);
        LeanTween.scale(Controle, new Vector3(1, 1, 1), 0.4f);
        Sair.SetActive(true);
        LeanTween.scale(Sair, new Vector3(1, 1, 1), 0.4f);
    }
    public void controle()
    {
        if (OnclickCon ==false)
        {
            LeanTween.scale(Jogar, new Vector3(0, 0, 0), 0.2f);

            LeanTween.scale(Opcoes, new Vector3(0, 0, 0), 0.2f);

            LeanTween.scale(Sair, new Vector3(0, 0, 0), 0.2f).setOnComplete(ControleClose);

            LeanTween.moveLocal(Controle, new Vector3(0, -66, 0), 0.5f).setOnComplete(ControleClose);
        }
        else
        {
            Jogar.SetActive(true);
            LeanTween.scale(Jogar, new Vector3(1, 1, 1), 0.2f);
            Opcoes.SetActive(true);
            LeanTween.scale(Opcoes, new Vector3(1, 1, 1), 0.2f);
            Sair.SetActive(true);
            LeanTween.scale(Sair, new Vector3(1, 1, 1), 0.2f);
            LeanTween.moveLocal(Controle, new Vector3(-99.55499f, -204.3f, 0f), 0.5f).setOnComplete(ControleOpen);
        }
    }
    public void ControleClose()
    {
        Jogar.SetActive(false);
        Opcoes.SetActive(false);
        Sair.SetActive(false);
        OnclickCon = true;

    }
    public void ControleOpen()
    {
        OnclickCon = false;
    }
}
