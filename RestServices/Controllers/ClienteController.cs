using RestServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestServices.Controllers
{
    public class ClienteController : ApiController
    {

        private readonly Cliente[] Clientes = new Cliente[]
        {
            new Cliente
            {
                ID = 1,
                Nome = "Eduardo Pires",
                Email = "falecom@eduardopires.net.br",
                Ativo = true

            },


            new Cliente
            {
                ID = 2,
                Nome = "Lucas Cezar",
                Email = "lmcezar@gmail.com",
                Ativo = true
            },

            new Cliente
            {
                ID = 3,
                Nome = "Jon Snow",
                Email = "jon@stark.com.br",
                Ativo = false

            }
        };

        // GET: api/Cliente
        [AcceptVerbs("GET")]
        public Cliente[] Get()
        {
            return Clientes;
        }

        // GET: api/Cliente/5
        public Cliente Get(int id)
        {
            var clientes = Clientes;
            //return clientes.SingleOrDefault(x => x.ID);
            return clientes.SingleOrDefault(x => x.ID == id);


        }

        // POST: api/Cliente
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cliente/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
        }
    }
}
