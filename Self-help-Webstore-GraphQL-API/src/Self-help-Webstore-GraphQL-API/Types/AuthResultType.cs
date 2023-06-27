using Self_help_Webstore_GraphQL_API.src.Self_help_Webstore_GraphQL_API.Models;

namespace Self_help_Webstore_GraphQL_API.src.Self_help_Webstore_GraphQL_API.Types
{
    public class AuthResultType : ObjectType<AuthResult>
    {
        protected override void Configure(IObjectTypeDescriptor<AuthResult> descriptor)
        {
            descriptor.Description("Represents the authentication result.");

            descriptor.Field(ar => ar.Token)
                .Description("The authentication token.")
                .Type<NonNullType<StringType>>();

            descriptor.Field(ar => ar.User)
                .Description("The authenticated user.")
                .Type<UserType>();

            descriptor.Field(ar => ar.Message)
                .Description("The authentication result message.")
                .Type<StringType>();

            // Add more fields as needed

            // Optionally, you can include additional configuration for directives, etc.
        }
    }
}
