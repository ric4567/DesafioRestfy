using System;
using System.Text;

namespace DesafioRestfy
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Hash { get; private set; }
        public string HashDescription { get; private set; }
        public string Role { get; set; }

        internal void SetHash(string hash)
        {
            Hash = hash;
            byte[] hashBytes = Convert.FromBase64String(Hash);
            HashDescription = Encoding.ASCII.GetString(hashBytes);
        }
    }
}