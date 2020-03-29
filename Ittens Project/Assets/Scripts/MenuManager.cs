using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// MenuManager to skrypt to zarządzania buttonami i opcjami w menu głównym


public class MenuManager : MonoBehaviour
{

        public void NewGame() {
            SceneManager.LoadScene("New Game");

        }

        public void LoadGame() {
            // Testowy komentarz

        }

        public void Options() {


        }

        public void Credits() {


        }

        public void Exit() {
            Application.Quit();

        }



}
