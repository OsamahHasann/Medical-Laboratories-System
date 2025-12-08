using Medical_Laboratories_System;
using System.Collections.Generic;
using System.Linq;

public class BookingRepository
{
    private readonly MedicalLabDBEntities1 _db;

    public BookingRepository()
    {
        _db = new MedicalLabDBEntities1();
    }

    public List<Bookings> GetAll()
    {
        return _db.Bookings.ToList();
    }

    public Bookings GetById(int id)
    {
        return _db.Bookings.FirstOrDefault(r => r.BookingId == id);
    }

    public void Add(Bookings entity)
    {
        _db.Bookings.Add(entity);
        _db.SaveChanges();
    }

    public void Update(Bookings entity)
    {
        _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        _db.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = _db.Bookings.Find(id);
        if (entity != null)
        {
            _db.Bookings.Remove(entity);
            _db.SaveChanges();
        }
    }
}
