using SolidApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Configuration;
using SolidApp.Entity.Base;

namespace SolidApp.DAL.Base
{
    public class MongoRepository<T> : IRepository<T> where T : IBaseEntity
    {
        private MongoClient _client;
        private IMongoDatabase _database;
        private IMongoCollection<T> _collection;
        private string CollectionName { get; set; }

        public MongoRepository(string tableName)
        {
            this.CollectionName = tableName;
        }

        public IEnumerable<T> ListAll()
        {
            return GetCollection().Find(Builders<T>.Filter.Empty).ToList();
        }

        public T FindById(string id)
        {
            return GetCollection().Find(Builders<T>.Filter.Eq(x => x.Id, id)).FirstOrDefault();
        }

        public void Save(T item)
        {
            //if (GetIdValue(item) == Guid.Empty.ToString())
            //    GetCollection().InsertOne(item);
            //else
            GetCollection().ReplaceOne(Builders<T>.Filter.Eq(x => x.Id, item.Id), item, new ReplaceOptions() { IsUpsert = true });

            //GetCollection().ReplaceOne(Builders<T>.Filter.Where(x => GetIdValue(x) == GetIdValue(x)).Eq(x => GetIdValue(x), GetIdValue(item)), item);

            //GetCollection().ReplaceOne(Builders<T>.Filter.Where(x => GetIdValue(x) == GetIdValue(item)), item);
        }

        private MongoClient GetMongoClient()
        {
            if (_client == null)
                _client = new MongoClient(ConfigurationManager.ConnectionStrings["default"].ConnectionString);
            return _client;
        }

        private IMongoDatabase GetMongoDatabase()
        {
            if (_database == null)
                _database = GetMongoClient().GetDatabase(ConfigurationManager.AppSettings["databaseName"]);
            return _database;
        }

        public IMongoCollection<T> GetCollection()
        {           
            if (_collection == null)
                _collection = GetMongoDatabase().GetCollection<T>(CollectionName);
            if (_collection == null)
                GetMongoDatabase().CreateCollection(CollectionName, new CreateCollectionOptions() {  });
            if (_collection == null)
                _collection = GetMongoDatabase().GetCollection<T>(CollectionName);
            return _collection;
        }
    }
}