using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea5_.Data;
using Tarea5_.Models;

namespace Tarea5_.Servicios
{
    public class UsuarioServicio
    {
        private Tarea6DbContext tareaContext;

        public UsuarioServicio(Tarea6DbContext tareaContext)
        {
            this.tareaContext = tareaContext;
        }
        //lee
        public async Task<List<Usuario>> GetUsuariosAsync()
        {
            return await tareaContext.Usuarios.ToListAsync();
        }
        //escribe
        public async Task<Usuario> AgregarUsuario(Usuario usuario)
        {
            try
            {
                tareaContext.Usuarios.Add(usuario);
                await tareaContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return usuario;
        }
    }
}
