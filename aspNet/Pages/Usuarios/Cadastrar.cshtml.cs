using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspNet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspNet.Pages.Usuarios
{
    public class CadastrarModel : PageModel
    {
        [BindProperty]
        public Usuario usuario { get; set; }
        public void OnGet(String nome, String senha)
        {
            if (usuario == null)
                usuario = new Usuario();

            usuario.Nome = nome;
            usuario.Senha = senha;
        }
    }
}