using PortalAPI.Models;
using PortalAPI.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PostAPI.Repository.Residence
{
    public class Units_Repository : Units_Interface
    {
        private readonly ResidenceContext ResidenceContext;

        public Units_Repository(ResidenceContext context)
        {
            ResidenceContext = context;
        }

        public async Task<VM_Resault> Create(Units unit, string hrCode)
        {
            // Check if the building exists
            if (!ResidenceContext.Buildings.Any(b => b.Id == unit.BuildingsId))
            {
                return new VM_Resault
                {
                    message = "Building not found",
                    code = 404,
                    error = true
                };
            }

            unit.InDate = DateTime.Now;
            unit.InUser = hrCode;

            var newEntity = (await ResidenceContext.Units.AddAsync(unit)).Entity;
            await ResidenceContext.SaveChangesAsync();

            return new VM_Resault
            {
                message = "Unit created successfully",
                code = 201,
                error = false,
                data = new List<object> { newEntity }
            };
        }

        public async Task<VM_Resault> Delete(List<int> ids)
        {
            var units = await ResidenceContext.Units
                .Where(u => ids.Contains(u.Id))
                .ToListAsync();

            ResidenceContext.Units.RemoveRange(units);
            await ResidenceContext.SaveChangesAsync();

            return new VM_Resault
            {
                message = "Units deleted successfully",
                code = 204,
                error = false
            };
        }

        public async Task<VM_Resault> GetAll()
        {
            var units = await ResidenceContext.Units.ToListAsync();

            return new VM_Resault
            {
                message = "Success",
                code = 200,
                error = false,
                data = units.Cast<object>().ToList()
            };
        }

        public async Task<VM_Resault> Update(int id, Units unitUpdate, string hrCode)
        {
            var unit = await ResidenceContext.Units.FirstOrDefaultAsync(u => u.Id == id);
            if (unit == null)
            {
                return new VM_Resault
                {
                    message = "Unit not found",
                    code = 404,
                    error = true
                };
            }

            // Check if the building exists (allow reassignment)
            if (!ResidenceContext.Buildings.Any(b => b.Id == unitUpdate.BuildingsId))
            {
                return new VM_Resault
                {
                    message = "Building not found",
                    code = 404,
                    error = true
                };
            }

            unit.No = unitUpdate.No;
            unit.Type = unitUpdate.Type;
            unit.Area = unitUpdate.Area;
            unit.Price = unitUpdate.Price;
            unit.BuildingsId = unitUpdate.BuildingsId;
            unit.UpDate = DateTime.Now;
            unit.UpUser = hrCode;

            ResidenceContext.Units.Update(unit);
            await ResidenceContext.SaveChangesAsync();

            return new VM_Resault
            {
                message = "Unit updated successfully",
                code = 200,
                error = false,
                data = new List<object> { unit }
            };
        }

        public async Task<VM_Resault> GetByBuilding(int buildingId)
        {
            var units = await ResidenceContext.Units
                .Where(u => u.BuildingsId == buildingId)
                .ToListAsync();

            return new VM_Resault
            {
                message = "Success",
                code = 200,
                error = false,
                data = units.Cast<object>().ToList()
            };
        }
    }
}
