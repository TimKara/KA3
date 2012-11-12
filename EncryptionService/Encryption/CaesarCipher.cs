using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EncryptionService
{
    public class CaesarCipher // Fandt løsningen fra www.dotnetperls.com/caesar og har forbedret den.
    {
        // Array af de tegn som bliver krypteret
        public char[] encryptCharacters = new char[]
        {
            'A','B','C','D','E','F','G','H','I','J','K','L','M','N'
            ,'O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };

        bool encrypted;

        public string Encrypt(string message, int key)
        {
            string encryptionResult = "";
            if (key < -25 || key > 25 || key == 0)
            {
                encryptionResult = "Error: The key value must be between the minimum(-25) and maximum(25) values! Do not use 0 as a value!";
            }
            else
            {
                foreach (char character in message)
                {
                    foreach (char encrypt in encryptCharacters) 
                    {
                        encrypted = false;
                        // Her bruges Compare metoden, som har "ignore case" funktionen til.
                        if (0 == string.Compare(character.ToString(), encrypt.ToString(), true)) // Tegn som skal blive krypteret. 
                        {
                            char c = character;
                            if (Char.IsUpper(character)) // BLOKBOGSTAV kontrol!
                            {
                                c = ((character.ToString().ToLower()).ToCharArray())[0];
                            }

                            char encrypting = (char)(c + key);
                            if (encrypting < 'a')
                            {
                                encrypting = (char)(encrypting + 26);
                            }
                            else if (encrypting > 'z')
                            {
                                encrypting = (char)(encrypting - 26);
                            }

                            if (Char.IsUpper(character)) // BLOKBOGSTAV kontrol!
                            {
                                encryptionResult += encrypting.ToString().ToUpper(); 
                            }
                            else
                            {
                                encryptionResult += encrypting;
                            }
                            encrypted = true;
                            break;
                        }
                    }
                    if (!encrypted) // Tegn som ikke bliver krypteret
                    {
                            encryptionResult += character;
                    }                 
                }
            }
            return encryptionResult;
        }
    }
}