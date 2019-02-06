using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ServerAuth.IDP
{
    public static class Config
    {
        public static IList<TestUser> TestUsers()
        {
            return new List<TestUser> {
                new TestUser
                {
                    SubjectId = "25229545-7c95-499e-b78c-ffb64772b6fa",
                    Username = "Joel",
                    Password = "password",
                    Claims = new List<Claim>{
                        new Claim("given_name","Joel"),
                        new Claim("family_name","Eniqs")
                    }
                },
                 new TestUser
                 {
                    SubjectId = "d7f1daef-9875-43f5-92d2-7d295e56478d",
                    Username = "Motun",
                    Password = "password",
                    Claims = new List<Claim>{
                        new Claim("given_name","Motun"),
                        new Claim("family_name","Eniqs")
                    }
                }
            };
        }
    }
}
