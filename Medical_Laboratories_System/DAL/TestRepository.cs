using Medical_Laboratories_System;
using System.Collections.Generic;
using System.Linq;

public class TestRepository
{
    private readonly MedicalLabDBEntities _db;

    public TestRepository()
    {
        _db = new MedicalLabDBEntities();
    }

    public List<Tests> GetAll()
    {
        return _db.Tests.ToList();
    }

    public Tests GetById(int id)
    {
        return _db.Tests.FirstOrDefault(t => t.TestId == id);
    }

    public void Add(Tests entity)
    {
        _db.Tests.Add(entity);
        _db.SaveChanges();
    }

    public void Update(Tests entity)
    {
        _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        _db.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = _db.Tests.Find(id);
        if (entity != null)
        {
            _db.Tests.Remove(entity);
            _db.SaveChanges();
        }
    }
}


