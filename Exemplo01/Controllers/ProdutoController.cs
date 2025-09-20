// filepath: /c:/Users/24166623/Downloads/WebBackEnd/Exemplo01/Controllers/ProdutoController.cs
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Exemplo01.Models; // Adicionado para reconhecer a classe Produto

namespace Exemplo01.Controllers
{
    [Route("[controller]")]
    public class ProdutoController : Controller
    {
        private static List<Produto> _produtoList = new List<Produto>
        {
            new Produto {Id = 1, Nome = "Correia", Preco = 150},
            new Produto {Id = 2, Nome = "Vira braquia", Preco = 200},
            new Produto {Id = 3, Nome = "Radiador", Preco = 500}
        };

        // Get: /Produtos
        public IActionResult Index()
        {
            return View(_produtoList);
        }

        // Get: /Produtos/Criar
        public IActionResult Criar()
        {
            return View();
        }

        // POST
        [HttpPost]
        public IActionResult Criar(Produto produto)
        {
            produto.Id = _produtoList.Count + 1; // Corrigido para gerar um novo Id
            _produtoList.Add(produto);
            return RedirectToAction("Index"); // Corrigido o nome do método para RedirectToAction
        }
    }
}