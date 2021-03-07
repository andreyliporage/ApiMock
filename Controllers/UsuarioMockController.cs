﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMock.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioMockController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Usuario> GetUsuarios()
        {
            return new List<Usuario>
            {
                new Usuario
                {
                    NomeUsuario = "ANPINA",
                    Email = "antonio.pina@tvglobo.com.br",
                    DataInclusao = new DateTime(2019, 05, 28),
                    DataAlteracao = new DateTime(2019, 05, 30),
                    Regras = "01",
                    Status = "ATIVO"
                },
                new Usuario
                {
                    NomeUsuario = "CCHANG",
                    Email = "ciro.chang@tvglobo.com.br",
                    DataInclusao = new DateTime(2019, 05, 28),
                    DataAlteracao = new DateTime(2019, 05, 30),
                    Regras = "01",
                    Status = "ATIVO"
                },
                new Usuario
                {
                    NomeUsuario = "TMARCAL",
                    Email = "thiago.marcal@tvglobo.com.br",
                    DataInclusao = new DateTime(2019, 05, 28),
                    DataAlteracao = new DateTime(2019, 05, 30),
                    Regras = "01",
                    Status = "ATIVO"
                },
                new Usuario
                {
                    NomeUsuario = "ECGIANN",
                    Email = "ecgiannotto@tvglobo.com.br",
                    DataInclusao = new DateTime(2019, 05, 28),
                    DataAlteracao = new DateTime(2019, 05, 30),
                    Regras = "01",
                    Status = "ATIVO"
                },
                new Usuario
                {
                    NomeUsuario = "YFERNAND",
                    Email = "yuri.vasquez@tvglobo.com.br",
                    DataInclusao = new DateTime(2019, 05, 28),
                    DataAlteracao = new DateTime(2019, 05, 30),
                    Regras = "01",
                    Status = "ATIVO"
                },
                new Usuario
                {
                    NomeUsuario = "PLACERDA",
                    Email = "pedro.soares.lacerda@tvglobo.com.br",
                    DataInclusao = new DateTime(2019, 05, 28),
                    DataAlteracao = new DateTime(2019, 05, 30),
                    Regras = "01",
                    Status = "ATIVO"
                }
            };
        }
    }
}
