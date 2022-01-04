using System;

namespace Business.Utilities.AuthorizationConstants
{
    public static class Authorizations
    {

        public static string[] GetAuthorizations()
        {
            string[] auths = new string[]
            {
                "İhbarları görme",
                "İhbar onaylama",
                "Çalışana ihbar atama",
                "İhbar durumu değiştirme"
            };

            return auths;
        }



    }
}
