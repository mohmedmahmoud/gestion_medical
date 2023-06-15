using System.Collections.Generic;
using gestion_medical.Data;
using gestion_medical.Models;

namespace gestion_medical.Services
{
    public class MedicineService : IMedicineService
    {
        private readonly AppDbContext _dbContext;

        public MedicineService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Medicine GetMedicineById(int id)
        {
            return _dbContext.Medicines.Find(id);
        }

        public IEnumerable<Medicine> GetAllMedicines()
        {
            return _dbContext.Medicines;
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
            var medicine = _dbContext.Medicines.Find(id);
            if (medicine != null)
            {
                _dbContext.Medicines.Remove(medicine);
                _dbContext.SaveChanges();
            }
        }

        // Autres méthodes spécifiques au service de gestion des médicaments
    }
}


