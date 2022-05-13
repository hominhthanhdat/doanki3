using ProjectSemester3.Models;

namespace ProjectSemester3.Services
{
    public class CandidateServiceImpl : CandidateService
    {
        DatabaseContext db;
        public CandidateServiceImpl(DatabaseContext database)
        {
            db = database;
        }


        public bool Add(Candidate candidate)
        {
            db.Candidates.Add(candidate);
            return db.SaveChanges() > 0;
        }


        public bool Edit(Candidate candidate)
        {
            db.Entry(candidate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public dynamic GetAll()
        {
            return db.Candidates.ToList();
        }

        public dynamic GetById(int id)
        {
            return db.Candidates.Find(id);
        }
    }
}
