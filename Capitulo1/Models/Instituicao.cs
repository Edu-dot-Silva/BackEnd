using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace Capitulo1.Models
{
    public class Instituicao
    {
        public long? InstituicaoId { get; set; }
        public required string Nome { get; set; }
        public required string Endereco { get; set; }
    }
}