using IllusionPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace MovieSaber
{
    public class MoviePlugin : IPlugin
    {
        public String Name => "MovieSaber";
        public String Version => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public static MoviePlugin Instance => _instance;

        private static MoviePlugin _instance;

        public MoviePlugin()
        {
            _instance = this;
        }

        public void OnApplicationQuit()
        {

        }

        public void OnApplicationStart()
        {
            Output.Logger.Info("Starting plugin...");

            SceneManager.sceneLoaded += (scene, loadSceneMode) =>
            {
                Output.Logger.Info("Loaded scene: " + scene.name);
            };
        }

        public void OnFixedUpdate()
        {

        }

        public void OnLevelWasInitialized(int level)
        {

        }

        public void OnLevelWasLoaded(int level)
        {

        }

        public void OnUpdate()
        {

        }
    }
}
