using Medical_Laboratories_System;
using System.Collections.Generic;
using System.Linq;

public class PatientRepository
{
    private readonly MedicalLabDBEntities _db;

    public PatientRepository()
    {
        _db = new MedicalLabDBEntities();
    }

    public List<Patients> GetAllPatients()
    {
        return _db.Patients.ToList();
    }

    public Patients GetPatientById(int id)
    {
        return _db.Patients.FirstOrDefault(p => p.PatientId == id);
    }

    public void AddPatient(Patients p)
    {
        _db.Patients.Add(p);
        _db.SaveChanges();
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