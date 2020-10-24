using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Tarea5_.Data
{
    public class Authorize : AuthenticationStateProvider
    {
        private ISessionStorageService _sessionStorage;
        public Authorize(ISessionStorageService sessionStorage)
        {
            _sessionStorage = sessionStorage;
        }
        
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            ClaimsIdentity identity;
            var cedula = await _sessionStorage.GetItemAsync<string>("cedula");
            
            if(cedula != null)
            {
               
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, cedula),
                }, "api");
            }
            else
            {
                identity = new ClaimsIdentity();
            }

             
            var user = new ClaimsPrincipal(identity);

            return await Task.FromResult(new AuthenticationState(user));
        }

        public void Logeado(string cedula)
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, cedula),
            }, "api");
            
            //var identity = new ClaimsIdentity();

            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public void Deslogueado()
        {
            _sessionStorage.RemoveItemAsync("cedula");

            var identity = new ClaimsIdentity();

            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }

    
}
