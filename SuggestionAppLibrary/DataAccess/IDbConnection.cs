﻿using MongoDB.Driver;

namespace SuggestionAppLibrary.DataAccess
{
    public interface IDbConnection
    {
        IMongoCollection<CategoryModel> CategoryCollection { get; }
        string CategoryCollectionName { get; }
        MongoClient Client { get; }
        string DbName { get; }
        string StatusCollectionName { get; }
        IMongoCollection<StatusModel> StatusCollecton { get; }
        IMongoCollection<SuggestionModel> SuggestionCollection { get; }
        string SuggestionCollectionName { get; }
        IMongoCollection<UserModel> UserCollection { get; }
        string UserCollectionName { get; }
    }
}