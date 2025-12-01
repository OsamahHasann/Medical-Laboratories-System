
using Medical_Laboratories_System;
using System.Collections.Generic;
using System.Linq;

public class ResultRepository
{
    private readonly MedicalLabDBEntities _db;

    public ResultRepository()
    {
        _db = new MedicalLabDBEntities();
    }

    public List<Results> GetAll()
    {
        return _db.Results.ToList();
    }

    public Results GetById(int id)
    {
        return _db.Results.FirstOrDefault(r => r.ResultId == id);
    }

    public void Add(Results entity)
    {
        _db.Results.Add(entity);
        _db.SaveChanges();
    }

    public void Update(Results entity)
    {
        _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        _db.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = _db.Results.Find(id);
        if (entity != null)
        {
            _db.Results.Remove(entity);
            _db.SaveChanges();
        }
    }
}