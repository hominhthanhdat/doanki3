using ProjectSemester3.Models;

namespace ProjectSemester3.Services
{
    public class CareerServiceImpl : CareerService
    {
        DatabaseContext db;
        public CareerServiceImpl(DatabaseContext database)
        {
            db = database;
        }


        public bool Add(Career career)
        {
            db.Careers.Add(career);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            db.Careers.Remove(db.Careers.Find(id));
            return db.SaveChanges() > 0;
        }

        public bool Edit(Career career)
        {
            db.Entry(career).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public dynamic GetAll()
        {
            return db.Careers.ToList();
        }

        public dynamic GetById(int id)
        {
            return db.Careers.Find(id);
        }
    }
}
