using System.Collections.Generic;
using gestion_medical.Models;

namespace gestion_medical.Services
{
    public interface IMedicineService
    {
        Medicine GetMedicineById(int id);
        IEnumerable<Medicine> GetAllMedicines();
        void AddMedicine(Medicine medicine);
        void UpdateMedicine(Medicine medicine);
        void DeleteMedicine(int id);

        // Autres méthodes spécifiques au service de gestion des médicaments
    }
}


