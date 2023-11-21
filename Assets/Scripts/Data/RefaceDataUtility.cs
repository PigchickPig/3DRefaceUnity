using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Reface
{
    public class RefaceDataUtility
    {
        /// <summary>
        /// 从Assets/Texture目录下读取材质
        /// </summary>
        public static Texture LoadTexture(string filePath)
        {
            Texture texture = AssetDatabase.LoadAssetAtPath<Texture>(filePath);
            if (texture == null)
            {
                Debug.LogError("Load Texture Fail");
                return null;
            }

            return texture;
        }
    }
}