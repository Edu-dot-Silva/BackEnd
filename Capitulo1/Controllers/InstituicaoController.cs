using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Capitulo1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Capitulo1.Controllers
{
    [Route("[controller]")]
    public class InstituicaoController : Controller
    // Herdando classe controller
    {
        private static IList<Instituicao> instituicoes = new List<Instituicao>()
        {
            new Instituicao(){
                InstituicaoId = 1,
                Nome = "Faculdade SENAI de Tecnologia",
                Endereco = "São Caetano do Sul"
            },
            new Instituicao(){
                InstituicaoId = 2,
                Nome = "UFABC",
                Endereco = "São Bernardo do Campo"
            },
            new Instituicao(){
                InstituicaoId = 3,
                Nome = "Universidade de São Paulo",
                Endereco = "São Paulo"
            },
            new Instituicao(){
                InstituicaoId = 4,
                Nome = "FEI - Fundação Educacional Inaciana",
                Endereco = "São Bernardo do Campo"
            },
            new Instituicao(){
                InstituicaoId = 5,
                Nome = "Instituito Mauá de Tecnologia",
                Endereco = "São Caetano do Sul"
            },
        };

        // Definicao de uma action chamada index
        public IActionResult Index()
        {
            // Esse controlador retorna a view para essa action
            return View();
        }
    }
}