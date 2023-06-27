using HotChocolate.Execution;
using HotChocolate.Language;
using Microsoft.AspNetCore.Mvc;

namespace Self_help_Webstore_GraphQL_API.Self_help_Webstore_GraphQL_API.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraphQLController : ControllerBase
    {
        private readonly IGraphQLExecutor<GraphQLSchema> _executor;

        public GraphQLController(IGraphQLExecutor<GraphQLSchema> executor)
        {
            _executor = executor;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLRequest request)
        {
            IExecutionResult result = await _executor.ExecuteAsync(request.Query);

            if (result.Errors?.Count > 0)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}






