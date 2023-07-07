﻿using UnityEngine;

namespace OxGFrame.AssetLoader.Editor
{
    [CreateAssetMenu(fileName = nameof(CryptogramSetting), menuName = "OxGFrame/Create Settings/Cryptogram Setting")]
    public class CryptogramSetting : ScriptableObject
    {
        [Header("OFFSET")]
        public int randomSeed = 1;
        public int dummySize = 1;

        [Header("XOR")]
        public byte xorKey = 1;

        [Header("HT2XOR")]
        public byte hXorKey = 1;
        public byte tXorKey = 1;
        public byte jXorKey = 1;

        [Header("AES")]
        public string aesKey = "aes_key";
        public string aesIv = "aes_iv";
    }
}