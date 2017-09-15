using System.Security.Cryptography;
using System.Text;

namespace Ystervark.Manager.Helpers
{
    public static class Md5Helper
    {
        /// <summary>
        /// Gets the m d5 hash.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static string GetMd5Hash(string value)
        {
            var md5Hasher = MD5.Create();
            var data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(value));
            var sBuilder = new StringBuilder();
            foreach (var t in data)
            {
                sBuilder.Append(t.ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}