using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.ChainOfReponsabilities.Warranties
{
    public class Warranty : IWarranty
    {
        protected DateTime _expiresAt { get; }

        public Warranty(DateTime expiresAt)
        {
            _expiresAt = expiresAt;
        }

        public bool IsValid()
            => DateTime.Now.CompareTo(_expiresAt) < 0;

        public void Claim(Action onValidClaim)
        {
            if (IsValid())
                onValidClaim();
            return;
        }
    }
}
