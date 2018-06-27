using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace smoothie_shack.Models
{
public class User
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set;}
    public string Password { get; set; }

    private ClaimsPrincipal _principal { get; set; }
    
    //    public List<Smoothie> MyFavs { get; set; } 
    
    public ClaimsPrincipal GetPrincipal()
    {
        return _principal;
    }

    public void SetClaims()     //assigns token for each session on login and register
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Email, Email),     //used to look people up
            new Claim(ClaimTypes.Name, Id)
        };
        var userIdentity = new ClaimsIdentity(claims, "login");
        _principal = new ClaimsPrincipal(userIdentity);

    }
}

public class UserRegistration //helper model to take in instead of full blown user object
{
    public string Name { get; set; }
    public string Email { get; set;}
    public string Password { get; set; }
}

public class UserLogin
{
    public string Email { get; set; }
    public string Password { get; set; }
}

}