using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

namespace RuntimeComponents.AssetBundle
{
 public class Simple_Scene : MonoBehaviour
 {
    // Start is called before the first frame update
    public static void Scene(string SceneName)
    {
        Scene newScene = SceneManager.CreateScene(SceneName);
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(SceneName));
        GameObject MainCamera = new GameObject("Main Camera", typeof(Camera), typeof(AudioListener));
        GameObject DirectionalLight = new GameObject("Directional Light", typeof(Light));
        RenderSettings.sun = DirectionalLight.GetComponent<Light>();
        DirectionalLight.GetComponent<Light>().type = LightType.Directional;
        DirectionalLight.GetComponent<Transform>().localEulerAngles = new Vector3(50,-30,0);
    }
 }
}