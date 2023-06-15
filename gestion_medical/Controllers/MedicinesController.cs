using System;
using gestion_medical.Models;
using gestion_medical.Services;
using Microsoft.AspNetCore.Mvc;

namespace gestion_medical.Controllers
{
    [ApiController]
    [Route("api/medicines")]
    public class MedicinesController : ControllerBase
    {
        private readonly MedicineService _medicineService;

        public MedicinesController(MedicineService medicineService)
        {
            _medicineService = medicineService;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Medicine), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetMedicine(int id)
        {
            var medicine = _medicineService.GetMedicineById(id);
            if (medicine == null)
                return NotFound();

            return Ok(medicine);
        }

        [HttpPost]
        public IActionResult AddMedicine(Medicine medicine)
        {
            _medicineService.AddMedicine(medicine);
            return CreatedAtAction(nameof(GetMedicine), new { id = medicine.Id }, medicine);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMedicine(int id, Medicine medicine)
        {
            if (id != medicine.Id)
                return BadRequest();

            _medicineService.UpdateMedicine(medicine);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMedicine(int id)
        {
            _medicineService.DeleteMedicine(id);
            return Ok();
        }

        // Autres méthodes d'action pour les opérations liées aux médicaments
    }

}

