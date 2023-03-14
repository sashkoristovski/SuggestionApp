using MongoDB.Driver.Core.Operations;
using System.Runtime.InteropServices;

namespace SuggestionAppUI;

public static class RegisterServices
{
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        builder.Services.AddMemoryCache();

        builder.Services.AddSingleton<IDbConnection, DbConnection>();   
        builder.Services.AddSingleton<ICategoryData,MongoCategoryData>();
        builder.Services.AddSingleton<IUserData, MongoUserData>();
        builder.Services.AddSingleton<IStatusData, MangoStatusData>();
        builder.Services.AddSingleton<ISuggestionData,MongoSuggestionData>();

    }
}
