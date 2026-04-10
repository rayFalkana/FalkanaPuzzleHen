using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace PuzzleHen
{
    public class MenuController : MonoBehaviour
    {
        [SerializeField] private Button btnPlay;
        [SerializeField] private Button btnOption;
        [SerializeField] private Button btnGallery;
        [SerializeField] private Button btnCredit;

        private void LoadScene(int _order)
        {
            SceneManager.LoadScene(_order);
        }

        // Start is called before the first frame update
        void Start()
        {
            btnPlay.onClick.AddListener(() => { LoadScene(1); });
            btnOption.onClick.AddListener(() => { });
            btnCredit.onClick.AddListener(() => { });
            btnGallery.onClick.AddListener(() => { LoadScene(1); });
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
