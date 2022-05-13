using ProjectSemester3.Models;

namespace ProjectSemester3.Services
{
    public class TestimonialServiceImpl : TestimonialService
    {
        DatabaseContext db;
        public TestimonialServiceImpl(DatabaseContext database)
        {
            db = database;
        }


       
        public dynamic GetAll()
        {
            return db.Testimonials.ToList();
        }

    }
}
