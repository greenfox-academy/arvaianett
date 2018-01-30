﻿using FoxManager.Models;
using FoxManager.Repositories;
using FoxManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Services
{
    public class ClassService
    {
        private ClassRepository classRepository;
        private StudentRepository studentRepository;

        public ClassService(ClassRepository classRepository, StudentRepository studentRepository)
        {
            this.classRepository = classRepository;
            this.studentRepository = studentRepository;
        }

        public BaseViewModel GetClassView(string name)
        {
            var classViewModel = new ClassViewModel()
            {
                AllClass = classRepository.GetAllClass(),
                CurrentStudent = studentRepository.GetCurrentStudent(name),
                AllStudent = studentRepository.GetAllStudent()
            };

            return new BaseViewModel()
            {
                ClassViewModel = classViewModel,
                CurrentStudent = studentRepository.GetCurrentStudent(name)
            };
        }

        public void AddClass(string name, Class foxClass)
        {
            classRepository.AddClass(name, foxClass);
        }

        public void DeleteClass(string name, long id)
        {
            classRepository.DeleteClass(name, id);
        }

        public void UpdateClass(string name, Class foxClass)
        {
            classRepository.UpdateClass(name, foxClass);
        }
    }
}