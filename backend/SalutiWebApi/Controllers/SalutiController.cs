using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SalutiWebApi.Controllers
{
    [ApiController]
    [Route("api/saluti")]
    public class SalutiController
    {
        public string getSaluti() {
            return "\"Sono la api in C#\"";
        }

        [HttpGet("{nome}")]
        public string getSaluti(string nome) =>
            string.Format("\"Saluti, {0} sono la api in C#\"", nome);
    }
}