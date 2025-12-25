using Medinova.DTOs;
using Medinova.DTOs.DoctorDtos;
using Medinova.Models;
using Medinova.Repositories;
using Medinova.Repositories.DoctorRepositories;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Medinova.Controllers
{
    public class AdminDoctorController : Controller
    {
        DoctorRepository repo = new DoctorRepository();

        private async Task LoadDepartmentsDropdownAsync()
        {
            GenericRepository<Department> depRepo = new GenericRepository<Department>();

            var departments = await depRepo.GetAllAsync();

            ViewBag.Departments = departments.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.DepartmentId.ToString()
            }).ToList();
        }

        public async Task<ActionResult> Index()
        {
            var values = await repo.GetAllAsync();

            var doctorDtos = values.Select(x => new ResultDoctorDto
            {
                DoctorID = x.DoctorId,
                FullName = x.FullName,
                ImageUrl = x.ImageUrl,
                DepartmentName = x.Department != null ? x.Department.Name : ""
            }).ToList();

            return View(doctorDtos);
        }

        [HttpGet]
        public async Task<ActionResult> CreateDoctor()
        {
            await LoadDepartmentsDropdownAsync();

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateDoctor(CreateDoctorDto doctorDto)
        {
            if (!ModelState.IsValid)
            {
                return View(doctorDto);
            }

            Doctor doctor = new Doctor();
            doctor.FullName = doctorDto.FullName;
            doctor.DepartmentId = doctorDto.DepartmentId;
            doctor.ImageUrl = doctorDto.ImageUrl;
            doctor.Description = doctorDto.Description;

            await repo.CreateAsync(doctor);

            return RedirectToAction("Index");
        }

        public async Task<ActionResult> DeleteDoctor(int id)
        {
            await repo.DeleteAsync(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> UpdateDoctor(int id)
        {
            await LoadDepartmentsDropdownAsync();

            var value = await repo.GetByIdAsync(id);

            if (value == null)
            {
                return RedirectToAction("Index");
            }

            UpdateDoctorDto model = new UpdateDoctorDto
            {
                DoctorId = value.DoctorId,
                FullName = value.FullName,
                Description = value.Description,
                ImageUrl = value.ImageUrl,
                DepartmentId = value.DepartmentId != null ? (int)value.DepartmentId : 0
            };

            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateDoctor(UpdateDoctorDto doctorDto)
        {
            if (!ModelState.IsValid)
            {
                await LoadDepartmentsDropdownAsync();
                return View(doctorDto);
            }

            Doctor doctor = new Doctor();

            doctor.DoctorId = doctorDto.DoctorId;
            doctor.FullName = doctorDto.FullName;
            doctor.Description = doctorDto.Description;
            doctor.DepartmentId = doctorDto.DepartmentId;
            doctor.ImageUrl = doctorDto.ImageUrl;

            await repo.UpdateAsync(doctor);

            return RedirectToAction("Index");
        }
    }
}
