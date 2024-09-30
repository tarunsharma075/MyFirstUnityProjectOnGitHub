using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class backbutton2 : MonoBehaviour
{

   public Button backbuttontwo;
   public string changesence;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        backbuttontwo.onClick.AddListener(onclick);
    }


    private void onclick()
    {
        SceneManager.LoadScene(changesence);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
