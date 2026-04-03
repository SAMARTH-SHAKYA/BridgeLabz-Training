
using System;
using System.Text;

class EncryptCSV
{
    static string Encrypt(string t)=>Convert.ToBase64String(Encoding.UTF8.GetBytes(t));
    static string Decrypt(string t)=>Encoding.UTF8.GetString(Convert.FromBase64String(t));
}
