using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea5_.Data;
using Tarea5_.Models;

namespace Tarea5_.Servicios
{
    public class SecretoServicio
    {
        private Tarea6DbContext tareaContext;

        public SecretoServicio(Tarea6DbContext tareaContext)
        {
            this.tareaContext = tareaContext;
        }
        //lee
        public async Task<List<Secreto>> GetSecretosAsync()
        {
            return await tareaContext.Secretos.ToListAsync();
        }
        //escribe
        public async Task<Secreto> AgregarSecreto(Secreto secreto)
        {
            try
            {
                tareaContext.Secretos.Add(secreto);
                await tareaContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return secreto;
        }
        //edita
        public async Task<Secreto> EditarSecreto(Secreto secreto)
        {
            try
            {
                var SecretoExistete = tareaContext.Secretos.FirstOrDefault(a => a.Id == secreto.Id);
                if (SecretoExistete != null)
                {
                    tareaContext.Update(secreto);
                    await tareaContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return secreto;
        }
        //borra
        public async Task BorrarSecreto(Secreto secreto)
        {
            try
            {
                tareaContext.Secretos.Remove(secreto);
                await tareaContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    
}
}
