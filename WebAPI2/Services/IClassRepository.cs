using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2.Model;
using WebAPI2.Model.dto;

namespace WebAPI2.Services
{
    public interface IClassRepository
    {
        List<ClassDto> GetAll();
        ClassDto GetClassbyId(int id);
        ClassDto Create(ClassModel classModel);
        void Update(ClassDto classDto);
        void Delete(int id);

    }
}
