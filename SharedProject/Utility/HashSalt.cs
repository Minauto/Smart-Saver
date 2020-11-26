using System;
using System.Security.Cryptography;

namespace SmartSaver
{
    public class HashSalt
    {
        public string Hash { get; set; }
        public string Salt { get; set; }

        public static HashSalt GenerateSaltedHash(string password, int size = 16)
        {
            var saltBytes = new byte[size];
            var provider = new RNGCryptoServiceProvider();
            provider.GetNonZeroBytes(saltBytes);
            var salt = Convert.ToBase64String(saltBytes);

            var rfc2898DerivesBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000);
            var hashPassword = Convert.ToBase64String(rfc2898DerivesBytes.GetBytes(64));

            HashSalt hashSalt = new HashSalt { Hash = hashPassword, Salt = salt };
            return hashSalt;
        }

        public static bool VerifyPassword(string password, string storedHash, string storedSalt)
        {
            var saltBytes = Convert.FromBase64String(storedSalt);
            var rfc2898DerivedBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000);
            return Convert.ToBase64String(rfc2898DerivedBytes.GetBytes(64)) == storedHash;
        }
    }
}
