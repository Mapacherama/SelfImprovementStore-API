using Self_help_Webstore_GraphQL_API.src.Self_help_Webstore_GraphQL_API.Models;

namespace Self_help_Webstore_GraphQL_API.src.Self_help_Webstore_GraphQL_API
{
    public class Query
    {
        [GraphQLDescription("Gets a list of all products.")]
        public IQueryable<Product> GetProducts()
        {
            // Implement the logic to fetch and return a list of products from your data store or service
            return null;
        }

        [GraphQLDescription("Gets a single product by its ID.")]
        public Product GetProductById(int id)
        {
            // Implement the logic to fetch and return a product by its ID from your data store or service
            return null;
        }

        [GraphQLDescription("Gets a list of all users.")]
        public IQueryable<User> GetUsers()
        {
            // Implement the logic to fetch and return a list of users from your data store or service
            return null;
        }

        [GraphQLDescription("Gets a single user by their ID.")]
        public User GetUserById(int id)
        {
            // Implement the logic to fetch and return a user by their ID from your data store or service
            return null;
        }
    }
}
