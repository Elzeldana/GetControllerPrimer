using Dapper;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using WebApiExample.Core.DbHelper;
using Biblioteka.Models;

namespace Biblioteka.Repo
{
    public class DatabaseRepo : IDataRepo
    {
        readonly ILog logger;

        public DatabaseRepo(ILog logger)
        {
            this.logger = logger;
        }

        public List<Recepti> GetProducts()
        {
            try
            {
                using (SqlConnection conn = DbAccess.GetOpenConnection())
                {
                    List<Recepti> result = conn.Query<Recepti>("spGetALlProducts", commandType: CommandType.StoredProcedure).ToList();

                    return result;
                }
            }
            catch (Exception e)
            {
                logger.Error("Error happened while getting the products! " + e.Message, e);
                return null;
            }
        }



    }
}