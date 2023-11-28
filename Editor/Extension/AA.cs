using System;
using System.IO;

namespace YooAsset.Editor
{
    /// <summary>
    /// 文件偏移加密方式
    /// </summary>
    public class FileOffsetEncryption : IEncryptionServices
    {
        public EncryptResult Encrypt(EncryptFileInfo fileInfo)
        {
            // if (fileInfo.BundleName.Contains("_gameres_audio"))
            // {
            //     int offset = 32;
            //     byte[] fileData = File.ReadAllBytes(fileInfo.FilePath);
            //     var encryptedData = new byte[fileData.Length + offset];
            //     Buffer.BlockCopy(fileData, 0, encryptedData, offset, fileData.Length);
            //
            //     EncryptResult result = new EncryptResult();
            //     result.Encrypted = true;
            //     result.EncryptedData = encryptedData;
            //     return result;
            // }
            // else
            {
                EncryptResult result = new EncryptResult();
                result.Encrypted = false;
                return result;
            }
        }
    }
}