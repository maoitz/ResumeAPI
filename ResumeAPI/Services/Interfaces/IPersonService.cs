using ResumeAPI.DTOs;
using ResumeAPI.Models;

namespace ResumeAPI.Services.Interfaces;

public interface IPersonService
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> GetAllAsync();
        Task<Person?> GetByIdAsync(int id);
        Task<Person> CreateAsync(PersonDto personDto);
        Task<Person?> UpdateAsync(int id, PersonDto personDto);
        Task<bool> DeleteAsync(int id);
    }
}