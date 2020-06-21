using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void LoadLevel(string name)
    {
        print("Level loaded " + name);
        SceneManager.LoadScene("Scenes/" + name);
    }
}
