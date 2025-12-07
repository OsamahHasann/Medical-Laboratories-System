using Medical_Laboratories_System;
using System.Collections.Generic;
using System.Linq;

public class TestRepository
{
    private readonly MedicalLabDBEntities1 _db;

    public TestRepository()
    {
        _db = new MedicalLabDBEntities1();
    }

    public List<Medical_Tests> GetAll()
    {
        return _db.Medical_Tests.ToList();
    }

    public Medical_Tests GetById(int id)
    {
        return _db.Medical_Tests.FirstOrDefault(t => t.TestId == id);
    }

    public void Add(Medical_Tests entity)
    {
        _db.Medical_Tests.Add(entity);
        _db.SaveChanges();
    }

    public void Update(Medical_Tests entity)
    {
        _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        _db.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = _db.Medical_Tests.Find(id);
        if (entity != null)
        {
            _db.Medical_Tests.Remove(entity);
            _db.SaveChanges();
        }
    }
}


