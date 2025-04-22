using WorkerEntity = Dolgozó_nyilvántartó.Repository.Worker;
using WorkerDTO = Dolgozó_nyilvántartó.DTO.Worker;
using Dolgozó_nyilvántartó.Infrastructure;
namespace Dolgozó_nyilvántartó.Database.Controllers
{
    internal class WorkerController : IController
    {
        Guid IController.AddOne(WorkerDTO worker)
        {
            var guid = Guid.Empty;
            using (var context = new WorkerContext())
            {
                var currentWorkers = context.Workers;
                foreach(var forWorker in currentWorkers)
                {
                    WorkerDTO forDTO = new WorkerDTO()
                    {
                        Name = forWorker.Name,
                        Email = forWorker.Email,
                        Age = forWorker.Age,
                        Salary = forWorker.Salary
                    };
                    if(forDTO == worker)
                    {
                        throw new Exception("A dolgozó már létezik");
                    }
                }
                guid = Guid.NewGuid();
                var newWorker = new WorkerEntity()
                {
                    Id = guid,
                    Name = worker.Name,
                    Email = worker.Email,
                    Age = worker.Age,
                    Salary = worker.Salary
                };

                context.Workers.Add(newWorker);
                context.SaveChanges();
            }
            return guid;
        }

        List<WorkerDTO> IController.ListAll()
        {
            List<WorkerDTO> workers;
            using (var context = new WorkerContext())
            {
                workers = context.Workers.Select(w => new WorkerDTO()
                {
                    Name = w.Name,
                    Email = w.Email,
                    Age = w.Age,
                    Salary = w.Salary
                }).ToList();
            }
            return workers;
        }
    }
}