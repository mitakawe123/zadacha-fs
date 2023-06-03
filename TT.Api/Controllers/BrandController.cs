using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using TT.Api.TreeImplementation;
using TT.Api.TreeImplementation.Tree;
using TT.Lib.DataAccess;
using TT.Lib.Entities;
using TT.Lib.Mvc;
using TT.Api.TreeImplementation.Tree;

namespace TT.Api.Controllers
{
    [Route("[controller]")]
    public class BrandController : ReadWriteController<Brand, int>
    {
        private readonly IBrandService mainService;

        public BrandController(IBrandService mainService) : base(mainService)
        {
            this.mainService = mainService;
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
                {
                    int brandId, parentId;

                    int.TryParse(oReader["BrandId"].ToString(), out brandId);

                    string parentIdString = oReader["ParentId"].ToString();
                    if (!string.IsNullOrEmpty(parentIdString))
                        int.TryParse(parentIdString, out parentId);
                    else
                        parentId = int.Parse(oReader["RecursionLevel"].ToString());

                    nodes.Add(new Node(
                        oReader["BrandName"].ToString(),    
                        oReader["ProductCode"].ToString(),
                        brandId,
                        int.Parse(oReader["RecursionId"].ToString()),
                        parentId,
                        oReader["PropertyName"].ToString(),
                        oReader["ProductName"].ToString(),
                        oReader["ProductValue"].ToString(),
                        int.Parse(oReader["RecursionLevel"].ToString())
                    ));
                }

                connection.Close();
            }

            BuildTree treeBuilder = new BuildTree();
            Node tree = treeBuilder.BuildTreeMethod(nodes);

            AssignParent parent = new AssignParent();
            parent.AssignParentToChildren(tree, null);

            BuildProducts buildProducts = new BuildProducts(tree);
            Node travers = buildProducts.TraverseAndPush();

            return Ok(travers);
        }
    }
}
