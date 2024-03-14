using ASP_MVC_SQL.CORE.DB;
using ASP_MVC_SQL.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_MVC_SQL.CORE.NG
{
    public class ClienteNG
    {
        //listar cliente
        public List<ClienteEntity> Listar()
        {
            //listar o cliente 
            // listar o cliente do DB
            // posso chama camada de DB

            var listaColecao = new ClienteDB().Listar();

            return listaColecao;

        }
    }
}
