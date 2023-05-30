using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Threading.Tasks;
using TT.Api.TreeImplementation.Tree;
using TT.Lib.DataAccess;
using TT.Lib.Entities;
using TT.Lib.Mvc;   

namespace TT.Api.Controllers
{
    [Route("[controller]")]
    public class BrandController : ReadWriteController<Brand, int>
    {
        private readonly IBrandService mainService;

        public BrandController(IBrandService mainService) : base(mainService)
        {
            this.mainService = mainService;
            Console.WriteLine("Constructor");
        }

        [HttpDelete]
        public new async Task<IActionResult> Delete(Brand brand) => Ok(await base.Delete(brand));

        [HttpGet]
        [Route("export")]
        public IActionResult Export()
        {
            List<Node> nodes = new List<Node>();
            string connectionString = "Server=EL-N-0047\\SQLEXPRESS;Database=zadacha;User Id=admin;Password=pmghello!;";
            string storeProcedureFullName = "zadacha.dbo.RecursiveTreeProcedure";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(storeProcedureFullName, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                connection.Open();

                using SqlDataReader oReader = command.ExecuteReader();
                while (oReader.Read())
                    nodes.Add(new Node(
                            int.Parse(oReader["RecursionId"].ToString()),
                            oReader["Name"].ToString(),
                            int.Parse(oReader["RecursionLevel"].ToString()),
                            oReader["ProductName"].ToString(),
                            oReader["ProductCode"].ToString(),
                            oReader["ProductValue"].ToString()
                        ));
                
                connection.Close();
            }

            BuildTree treeBuilder = new BuildTree();
            List<Node> tree = treeBuilder.BuildTreeMethod(nodes);

            return Ok(tree);
        }
    }
}
