using gestion_medical.Data;
using gestion_medical.Models;
using System.Collections.Generic;
using System.Linq;

namespace gestion_medical.Repositories
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly AppDbContext _dbContext;

        public MedicineRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Medicine GetMedicineById(int id)
        {
            return _dbContext.Medicines.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Medicine> GetAllMedicines()
        {
            return _dbContext.Medicines.ToList();
        }

        public void AddMedicine(Medicine medicine)
        {
            _dbContext.Medicines.Add(medicine);
            _dbContext.SaveChanges();
        }

        public void UpdateMedicine(Medicine medicine)
        {
            _dbContext.Medicines.Update(medicine);
            _dbContext.SaveChanges();
        }

        public void DeleteMedicine(int id)
        {
            var medicine = _dbContext.Medicines.FirstOrDefault(m => m.Id == id);
            if (medicine != null)
            {
                _dbContext.Medicines.Remove(medicine);
                _dbContext.SaveChanges();
            }
        }

        // Autres méthodes spécifiques au repository des médicaments
    }
}
