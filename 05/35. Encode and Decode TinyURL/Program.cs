using System;
using System.Collections.Generic;

namespace _35._Encode_and_Decode_TinyURL
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Codec
    {
        private static Dictionary<string, string> dic = new Dictionary<string, string>();
        private string characters = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        
        /// <summary>
        /// Encodes a URL to a shortened URL
        /// </summary>
        /// <param name="longUrl">Orignal URL</param>
        /// <returns></returns>
        public string encode(string longUrl)
        {
            char[] cs = new char[6];
            for (int i = 0; i < 6; i++)
                cs[i] = characters[new Random().Next(0, 62)];
            string shortUrl = "http://tinyurl.com/" + new string(cs);
            dic[shortUrl] = longUrl;
            return shortUrl;
        }

        /// <summary>
        /// Decodes a shortened URL to its original URL.
        /// </summary>
        /// <param name="shortUrl">Encoded URL</param>
        /// <returns></returns>
        public string decode(string shortUrl)
        {
            return dic[shortUrl];
        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec codec = new Codec();
    // codec.decode(codec.encode(url));
}
