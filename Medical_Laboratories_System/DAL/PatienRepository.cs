using Medical_Laboratories_System;
using System.Collections.Generic;
using System.Linq;

public class PatientRepository
{
    private readonly MedicalLabDBEntities1 _db;

    public PatientRepository()
    {
        _db = new MedicalLabDBEntities1();
    }

    public List<Patients> GetAllPatients()
    {
        return _db.Patients.ToList();
    }

    public Patients GetPatientById(int id)
    {
        return _db.Patients.FirstOrDefault(p => p.PatientId == id);
    }

    public int AddPatient(Patients p)
    {
        _db.Patients.Add(p);
        _db.SaveChanges();
        return p.PatientId;
    }

    public void UpdatePatient(Patients p)
    {
        _db.Entry(p).State = System.Data.Entity.EntityState.Modified;
        _db.SaveChanges();
    }

    public void DeletePatient(int id)
    {
        var p = _db.Patients.Find(id);
        if (p != null)
        {
            _db.Patients.Remove(p);
            _db.SaveChanges();
        }
    }
}