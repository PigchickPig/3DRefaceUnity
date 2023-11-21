using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reface
{
    public class RefaceDataManager
    {
        private static RefaceDataManager _instance;
        private Texture _faceTexture;
        private Object _faceObject;


        public static RefaceDataManager Instance
        {
            get => _instance;
            set => _instance = value;
        }

        public Texture FaceTexture
        {
            get => _faceTexture;
            set => _faceTexture = value;
        }

        public Object FaceObject
        {
            get => _faceObject;
            set => _faceObject = value;
        }
    
        public const string TexturePath = "Assets/Textures";
        public const string ObjectPath = "Assets/Models";

        public void LoadTexture()
        {
            _faceTexture = RefaceDataUtility.LoadTexture(TexturePath + "/FaceTexture.png");
        }
        
    }    
}

