using LiteDB;
using System.Runtime.InteropServices;

namespace Calypso.DataAccess;
abstract public class Repository<T> where T : class
{
    private readonly LiteDatabase db;

    public Repository(LiteDatabase liteDatabase)
    {
        try
        {
            db = liteDatabase;
        }
        catch (Exception ex)
        {
            throw new Exception($"Couldn't open or create database at given path: {ex.Message}");
        }
    }

    public ILiteCollection<T> List(string collection)
    {
        try
        {
            return db.GetCollection<T>(collection);
        }
        catch (Exception ex)
        {
            throw new Exception($"Couldn't retrieve entities: {ex.Message}");
        }
    }

    public BsonValue Add(string collection, T entity)
    {
        if (string.IsNullOrWhiteSpace(collection) || entity == null)
        {
            throw new ArgumentNullException($"{nameof(Add)} collection name or entity must not be null.");
        }

        BsonValue id;
        db.BeginTrans();
        try
        {
            id = db.GetCollection<T>(collection).Insert(entity);
            db.Commit();
            return id;
        }
        catch (Exception ex)
        {
            db.Rollback();
            throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
        }
    }

    public bool Update(string collection, T entity)
    {
        if (string.IsNullOrWhiteSpace(collection) || entity == null)
        {
            throw new ArgumentNullException($"{nameof(Add)} collection name or entity must not be null.");
        }

        bool isUpdated;
        db.BeginTrans();
        try
        {
            isUpdated = db.GetCollection<T>(collection).Update(entity);
            db.Commit();
            return isUpdated;
        }
        catch (Exception ex)
        {
            db.Rollback();
            throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
        }
    }

    public bool Delete(string collection, BsonValue id)
    {
        if (string.IsNullOrWhiteSpace(collection) || id == null)
        {
            throw new ArgumentNullException($"{nameof(Add)} collection name or entity must not be null.");
        }

        bool isDeleted;
        db.BeginTrans();
        try
        {
            isDeleted = db.GetCollection<T>(collection).Delete(id);
            db.Commit();
            return isDeleted;
        }
        catch (Exception ex)
        {
            db.Rollback();
            throw new Exception($"{nameof(id)} could not be deleted: {ex.Message}");
        }
    }
}