using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using MongoDB.Bson;
using MongoDB.Driver;
using smartthingspanel.backend.Models;
using smartthingspanel.backend.Models.Documents;

namespace smartthingspanel.backend.Data
{
    public class MongoRepository<T> where T : IDocument
    {
        private readonly IMongoCollection<T> _collection;

        public MongoRepository(IMongoClient client)
        {
            var database = client.GetDatabase(Constants.MongoDbDatabaseName);
            _collection = database.GetCollection<T>(typeof(T).Name);
        }
        public MongoRepository() : this(new MongoClient(Constants.MongoDbConnectionString)) { }
        
        public void InsertOrOverwrite(T entity)
        {
            _collection.ReplaceOne(new BsonDocument("_id", entity.Id), entity, new UpdateOptions {IsUpsert = true});
        }

        public List<T> Find(Expression<Func<T, bool>> filter)
        {
            return _collection.Find(filter).ToList();
        }

    }
}