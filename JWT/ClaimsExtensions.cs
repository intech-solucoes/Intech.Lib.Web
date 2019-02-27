using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace System
{
    public static class ClaimsExtensions
    {
        public static string GetValue(this IEnumerable<Claim> claims, string type)
            => claims.ToList().SingleOrDefault(x => x.Type == type).Value;
    }
}
