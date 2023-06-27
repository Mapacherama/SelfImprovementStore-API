using Self_help_Webstore_GraphQL_API.src.Self_help_Webstore_GraphQL_API.Models;

namespace Self_help_Webstore_GraphQL_API.src.Self_help_Webstore_GraphQL_API.Types
{
    public class ProductType : ObjectType<Product>
    {
        protected override void Configure(IObjectTypeDescriptor<Product> descriptor)
        {
            descriptor.Description("Represents a product in the webstore.");

            descriptor.Field(p => p.Id)
                .Description("The unique identifier of the product.")
                .Type<NonNullType<IntType>>();

            descriptor.Field(p => p.Name)
                .Description("The name of the product.")
                .Type<NonNullType<StringType>>();

            descriptor.Field(p => p.Price)
                .Description("The price of the product.")
                .Type<NonNullType<DecimalType>>();

            descriptor.Field(p => p.Description)
                .Description("The description of the product.")
                .Type<StringType>();

            descriptor.Field(p => p.Quantity)
                .Description("The quantity available for the product.")
                .Type<NonNullType<IntType>>();
        }
    }
}
