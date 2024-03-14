using ASP_MVC_SQL.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_MVC_SQL.CORE.DB
{
    internal class ClienteDB : BaseDB
    {
        internal List<ClienteEntity> Listar()
        {
            List<ClienteEntity> retorno = new List<ClienteEntity>();
            string query = @"
				SELECT
					Id,
					Nome
				FROM
					TB_CLIENTE
				ORDER BY
					Id
			";
            var dataTable = Reads(query);
            if (dataTable != null && dataTable.Rows != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    retorno.Add(new ClienteEntity()
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Nome = Convert.ToString(row["Nome"]),
                    });
                }
            }
            return retorno;
        }
    }
}
