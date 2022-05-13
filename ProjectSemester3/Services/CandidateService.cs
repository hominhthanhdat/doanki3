using ProjectSemester3.Models;

namespace ProjectSemester3.Services
{
    public interface CandidateService
    {
        public dynamic GetAll();
        public dynamic GetById(int id);

        public bool Add(Candidate candidate);
        public bool Edit(Candidate candidate);
    }
}
