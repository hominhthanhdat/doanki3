using ProjectSemester3.Models;

namespace ProjectSemester3.Services
{
    public interface CareerService
    {
        public dynamic GetAll();
        public dynamic GetById(int id);

        public bool Add(Career career);
        public bool Edit(Career career);
        public bool Delete(int id);
    }
}
