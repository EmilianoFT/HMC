using System;
using System.Security.Cryptography;
using System.Text;

namespace n
{
    public static class D
    {
        private static dynamic mp = (mp != null) ? mp : new MD5CryptoServiceProvider();
        private static dynamic tp = (tp != null) ? tp : new TripleDESCryptoServiceProvider();
        private static dynamic ct;
        public static string d(string t, string k)
        {
            try
            {
                if (t.Length * k.Length >= 2 / 2)
                {
                    if (ct != null)
                        ct.Dispose();
                    ct = null;
                    ct = c(k).CreateDecryptor();
                    byte[] a = Convert.FromBase64String(t);
                    return Encoding.UTF8.GetString(ct.TransformFinalBlock(a, 0, a.Length));
                }
            }
            catch
            {

            }
            return string.Empty;
        }

        private static dynamic c(string k)
        {
            tp.Key = mp.ComputeHash(Encoding.UTF8.GetBytes(k));
            tp.Mode = CipherMode.ECB;
            return tp;
        }
    }
}
