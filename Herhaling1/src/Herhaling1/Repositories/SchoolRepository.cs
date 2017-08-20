using Herhaling1.Entities;
using Herhaling1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herhaling1.Repositories
{
    public class SchoolRepository
    {
        private SchoolContext db;

        public SchoolRepository(SchoolContext context)
        {
            db = context;
        }

        public ICollection<StudentBasic> getAllStudenten()
        {

            return db.Studenten.Select(

                    s => new StudentBasic()
                    {
                        Studnr = s.Studnr,
                        Voornaam = s.Voornaam,
                        Familienaam = s.Familienaam
                    }).OrderBy(s => s.Studnr).ToList();
        }

        public StudentBasic getStudentById(int? id)
        {
            Studenten student = db.Studenten.FirstOrDefault(s => s.Studnr == id);
            return new StudentBasic()
            {

                Studnr = student.Studnr,
                Voornaam = student.Voornaam,
                Familienaam = student.Familienaam
            };
        }

        public void addStudent(StudentBasic student)
        {
            db.Studenten.Add(new Studenten()
            {
                Voornaam = student.Voornaam,
                Familienaam = student.Familienaam
            });

            db.SaveChanges();
        }

        internal void delete(int id)
        {
            db.Studenten.Remove(db.Studenten.Where(s => s.Studnr == id).FirstOrDefault());
            db.SaveChanges();
        }
    }
}
