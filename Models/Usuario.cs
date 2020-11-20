using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blueLojas.Models
{
    public class Usuario
    {

        public List<UsuarioModel> listaUsuarios = new List<UsuarioModel>();

        public Usuario()
        {

            listaUsuarios.Add(new UsuarioModel
            {
                nome = "roberto Andre",
                telefone = "334246565",
                email = "jesqbol@gmail.com.br",
            });
            listaUsuarios.Add(new UsuarioModel
            {
                nome = "mauricio Andre",
                telefone = "334246565",
                email = "jesqbol@gmail.com.br",
            }); listaUsuarios.Add(new UsuarioModel
            {
                nome = "jose Andre",
                telefone = "334246565",
                email = "joseqbol@gmail.com.br",
            });
        }
        public void CriaUsuario(UsuarioModel usuarioModelo)
        {
            listaUsuarios.Add(usuarioModelo);
        }

        public void AtualizaUsuario(UsuarioModel usuarioModelo)
        {
            foreach (UsuarioModel usuario in listaUsuarios)
            {
                if (usuario.email == usuarioModelo.email)
                {
                    listaUsuarios.Remove(usuario);
                    listaUsuarios.Add(usuarioModelo);
                    break;
                }
            }
        }
        public UsuarioModel GetUsuario(string Email)
        {
            UsuarioModel _usuarioModel = null;

            foreach (UsuarioModel _usuario in listaUsuarios)
                if (_usuario.email == Email)
                    _usuarioModel = _usuario;

            return _usuarioModel;
        }

        public void DeletarUsuario(String Email)
        {
            foreach (UsuarioModel _usuario in listaUsuarios)
            {
                if (_usuario.email == Email)
                {
                    listaUsuarios.Remove(_usuario);

                    break;
                }
            }
        }
    }
}
