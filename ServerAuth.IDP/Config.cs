using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
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
        public static List<TestUser> TestUsers()
        {
            return new List<TestUser> {
                new TestUser
                {
                    SubjectId = "25229545-7c95-499e-b78c-ffb64772b6fa",
                    Username = "Joel",
                    Password = "password",
                    Claims = new List<Claim>{
                        new Claim("given_name","Joel"),
                        new Claim("family_name","Eniqs"),
                        new Claim(JwtClaimTypes.Email,"Joel@gmail.com"),
                        new Claim(JwtClaimTypes.MiddleName,"olagoke")
                    }
                },
                 new TestUser
                 {
                    SubjectId = "d7f1daef-9875-43f5-92d2-7d295e56478d",
                    Username = "Motun",
                    Password = "password",
                    Claims = new List<Claim>{
                        new Claim("given_name","Motun"),
                        new Claim("family_name","Eniqs"),
                        new Claim(JwtClaimTypes.Email,"MotunBams@gmail.com"),
                        new Claim(JwtClaimTypes.MiddleName,"Omolade")
                    }
                }
            };
        }
        //identity-related resources(scopes)
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
               
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client> {
                new Client
                {
                    ClientName="Image Gallery",
                    ClientId="imagegalleryclient",
                    AllowedGrantTypes = GrantTypes.Hybrid,
                    RedirectUris = new List<string>{
                        "https://localhost:44375/signin-oidc"
                    },
                    AllowedScopes = {"openid","profile","email","family_name" },
                    ClientSecrets = {
                        new Secret("secret".Sha256())
                    }

                }
            };
           
        }
    }
}
