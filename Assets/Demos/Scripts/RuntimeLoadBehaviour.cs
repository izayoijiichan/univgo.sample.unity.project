namespace UniVgoDemos
{
    using System.IO;
    using UnityEngine;
    using UniVgo;

    public class RuntimeLoadBehaviour : MonoBehaviour
    {
        [SerializeField]
        private string _LocalFilePath = null;

        private void Start()
        {
            if (File.Exists(_LocalFilePath))
            {
                var vgoImporter = new VgoImporter();

                vgoImporter.Load(_LocalFilePath);
            }
            else
            {
                Debug.LogWarningFormat("File is not found. {0}", _LocalFilePath);
            }
        }
    }
}
