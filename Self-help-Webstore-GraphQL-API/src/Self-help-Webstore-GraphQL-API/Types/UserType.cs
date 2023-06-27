using Self_help_Webstore_GraphQL_API.src.Self_help_Webstore_GraphQL_API.Models;

namespace Self_help_Webstore_GraphQL_API.src.Self_help_Webstore_GraphQL_API.Types
{
    public class UserType : ObjectType<User>
    {
        protected override void Configure(IObjectTypeDescriptor<User> descriptor)
        {
            descriptor.Description("Represents a user in the webstore.");

            descriptor.Field(u => u.Id)
                .Description("The unique identifier of the user.")
                .Type<NonNullType<IntType>>();

            descriptor.Field(u => u.Username)
                .Description("The username of the user.")
                .Type<NonNullType<StringType>>();

            descriptor.Field(u => u.Email)
                .Description("The email address of the user.")
                .Type<NonNullType<StringType>>();

            descriptor.Field(u => u.Password)
                .Description("The password of the user.")
                .Type<NonNullType<StringType>>();

            // Add more fields as needed

            // Optionally, you can include additional configuration for relationships, directives, etc.
        }
    }
}
