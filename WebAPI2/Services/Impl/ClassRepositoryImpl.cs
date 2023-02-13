using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2.Data;
using WebAPI2.Model;
using WebAPI2.Model.dto;

namespace WebAPI2.Services.Impl
{
    public class ClassRepositoryImpl : IClassRepository
    {
        private readonly MyDbContext _context;

        public ClassRepositoryImpl(MyDbContext context)
        {
            _context = context;
        }
        public ClassDto Create(ClassModel classModel)
        {
            var _class = new Class
            {
                classname = classModel.classname
            };
            _context.Add(_class);
            _context.SaveChanges();

            return new ClassDto
            {
                classid = _class.classid,
                classname = _class.classname
            };
        }

        public void Delete(int id)
        {
            var _class = _context.classes.SingleOrDefault(c => c.classid == id);
            if (_class != null)
            {
                _context.Remove(_class);
                _context.SaveChanges();
            }
            
        }

        public List<ClassDto> GetAll()
        {
            var _class = _context.classes.Select(c => new ClassDto
            {
                classid = c.classid,
                classname = c.classname
            });
            return _class.ToList();
        }

        public ClassDto GetClassbyId(int id)
        {
            var _class = _context.classes.SingleOrDefault(c => c.classid == id);
            if(_class != null)
            {
                return new ClassDto
                {
                    classid = _class.classid,
                    classname = _class.classname
                };
                
            }
            return null;
        }

        public void Update(ClassDto classDto)
        {
            throw new NotImplementedException();
        }
    }
}
