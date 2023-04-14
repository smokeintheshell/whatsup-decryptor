using System;
using System.Collections.Generic;
using System.Text;
using Core.Cryptography;
using NmUserAuthenticator.Security;

public class WhatsUpDecrypt
{
    private static bool DecryptStringFromString(string encryptedString, byte[] passwordBytes, string serialKey, out string decryptedString)
    {
        //byte[] saltBytes = Encoding.ASCII.GetBytes("6BYSNUGFTKY6J6W");
        WugLoginCryptographyWrapper _wugLoginCryptography = new WugLoginCryptographyWrapper(new CryptoSupport(), serialKey);
        bool ret = _wugLoginCryptography.ConfigureCrypto(passwordBytes);
        // Console.WriteLine(ret);
        return _wugLoginCryptography.DecryptString(encryptedString, out decryptedString);
    }
    private static byte[] DecodeBinaryString(string binaryString)
    {
        List<byte> byteList = new List<byte>();
        string str = binaryString;
        char[] chArray = new char[1] { ',' };
        foreach (string s in str.Split(chArray))
        {
            byte result;
            if (byte.TryParse(s, out result))
                byteList.Add(result);
        }
        return byteList.ToArray();
    }
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide an encryptedPassword (comma delimited str), serialKey (str)");
            Console.WriteLine("Usage: decryptor.exe encryptedPassword serialKey");
            Console.WriteLine("Example:");
            Console.WriteLine("decryptor.exe 3,0,0,0,16,0,0,0,119,40,223,161,89,252,66,245,79,122,93,17,232,169,205,233 6BYSNUGFTKY6J6W");
            return;
        }
        // string password = "3,0,0,0,16,0,0,0,119,40,223,161,89,252,66,245,79,122,93,17,232,169,205,233";
        // string serialKey = "6BYSNUGFTKY6J6W";
        string password = args[0];
        string serialKey = args[1];
        byte[] passwordBytes = DecodeBinaryString(password);
        string decryptedString;
        bool ret2 = DecryptStringFromString(password, passwordBytes, serialKey, out decryptedString);
        //Console.WriteLine(ret2);
        if (ret2 == false)
        {
            Console.WriteLine("Something went wrong.");
            Console.WriteLine("Verify the encrypted password bytes and serial key are accurate");
        }
        else
        {
            //byte[] decryptedStringBytes = Encoding.Unicode.GetBytes(decryptedString);
            //System.IO.File.WriteAllText("password.txt", decryptedString);
            //System.IO.File.WriteAllBytes("passwordbytes.dat", decryptedStringBytes);
            Console.WriteLine(decryptedString);
        }
    }
}

