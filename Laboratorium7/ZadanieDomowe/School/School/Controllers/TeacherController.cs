using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using School.Controllers.Interfaces;
using School.Models;
using School.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        /// <summary>
        /// Zainicjalizowanie interfejsu nauczyciela
        /// </summary>
        private ITeacherRepository _teacherRepository;
        /// <summary>
        /// Zainicjalizowanie mappera
        /// </summary>
        private IMapper _mapper;

        public TeacherController(ITeacherRepository teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Zwraca wszystkich nauczycieli
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult <IEnumerable<TeacherViewModel>> GetAllTeachers()
        {
            var teachers = _teacherRepository.GetAllTeachers();
            return Ok(_mapper.Map<IEnumerable<TeacherViewModel>>(teachers));
        }
        /// <summary>
        /// Zwraca nauczycieli po id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "GetTeacherById")]
        public ActionResult <TeacherViewModel> GetTeacherById(int id)
        {
            var teacher = _teacherRepository.GetTeacherById(id);
            if(teacher != null)
            {
                return Ok(_mapper.Map<TeacherViewModel>(teacher));
            }
            return NotFound();
        }
        /// <summary>
        /// Dodanie nauczyciela do bazy
        /// </summary>
        /// <param name="teacherCreateViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<TeacherViewModel> CreateTeacher(TeacherCreateUpdateViewModel teacherCreateViewModel)
        {
            // Dodanie do bazy
            var teacherMake = _mapper.Map<Teacher>(teacherCreateViewModel);
            _teacherRepository.CreateTeacher(teacherMake);
            _teacherRepository.SaveChanges();

            // Poprawne pokazanie edytowanego dokumentu z id
            var teacherRead = _mapper.Map<TeacherViewModel>(teacherMake);

            // Zwracamy ścieżkę do stworzonego nauczyciela
            return CreatedAtRoute(nameof(GetTeacherById), new { Id = teacherRead.Id }, teacherRead);
        }
        /// <summary>
        /// Funkcja służy do zmiany parametrów nauczyciela
        /// </summary>
        /// <param name="id"></param>
        /// <param name="teacherUpdateViewModel"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public ActionResult UpdateTeacher(int id, TeacherCreateUpdateViewModel teacherUpdateViewModel)
        {
            // Wyszukanie po id
            var teacherFromRepositorium = _teacherRepository.GetTeacherById(id);
            // Jak nie ma to not found
            if (teacherFromRepositorium == null)
            {
                return NotFound();
            }

            _mapper.Map(teacherUpdateViewModel, teacherFromRepositorium);
            // Wywołanie funkcji UpdateTeacher
            _teacherRepository.UpdateTeacher(teacherFromRepositorium);
            // Zapisanie zmian
            _teacherRepository.SaveChanges();
            return NoContent();
        }
        /// <summary>
        /// Funkcja usuwa nauczyciela z bazy
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult DeleteTeacher(int id)
        {
            // Wyszukanie po id
            var teacherFromRepositorium = _teacherRepository.GetTeacherById(id);
            // Jak nie ma to not found
            if (teacherFromRepositorium == null)
            {
                return NotFound();
            }
            // Wywołanie funkcji usunięcia nauczyciela
            _teacherRepository.DeleteTeacher(teacherFromRepositorium);
            // Zapisanie zmian w bazie
            _teacherRepository.SaveChanges();
            return NoContent();
        }
    }
}
