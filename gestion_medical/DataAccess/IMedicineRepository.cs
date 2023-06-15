using gestion_medical.Models;
using System.Collections.Generic;

namespace gestion_medical.Repositories
{
    public interface IMedicineRepository
    {
        Medicine GetMedicineById(int id);
        IEnumerable<Medicine> GetAllMedicines();
        void AddMedicine(Medicine medicine);
        void UpdateMedicine(Medicine medicine);
        void DeleteMedicine(int id);

        // Autres méthodes spécifiques au repository des médicaments
    }
}

