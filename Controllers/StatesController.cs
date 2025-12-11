using IndiaGeoAPI.Models.Domain_Model;
using IndiaGeoAPI.Models.DTO;
using IndiaGeoAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IndiaGeoAPI.Controllers
{
    [ApiController]
    [Route("indiagoapi/[controller]")]
    public class StatesController:ControllerBase
    {
        private static Dictionary<int, string> States = new Dictionary<int, string>
        {
            { 1, "Andhra Pradesh" },
            { 2, "Arunachal Pradesh" },
            { 3, "Assam" },
            { 4, "Bihar" },
            { 5, "Chhattisgarh" },
            { 6, "Goa" },
            { 7, "Gujarat" },
            { 8, "Haryana" },
            { 9, "Himachal Pradesh" },
            { 10, "Jharkhand" },
            { 11, "Karnataka" },
            { 12, "Kerala" },
            { 13, "Madhya Pradesh" },
            { 14, "Maharashtra" },
            { 15, "Manipur" },
            { 16, "Meghalaya" },
            { 17, "Mizoram" },
            { 18, "Nagaland" },
            { 19, "Odisha" },
            { 20, "Punjab" },
            { 21, "Rajasthan" },
            { 22, "Sikkim" },
            { 23, "Tamil Nadu" },
            { 24, "Telangana" },
            { 25, "Tripura" },
            { 26, "Uttar Pradesh" },
            { 27, "Uttarakhand" },
            { 28, "West Bengal" }
        };

        [HttpGet]
        public List<StateDomainModel> GetAllStates()
        {
            return StateRepository.GetAllStates();
        }

        [HttpGet("{id}")]
        public StateDomainModel GetStateByID([FromRoute] Guid id)
        {
            return StateRepository.GetStateWithID(id);
        }

        [HttpPost]
        public StateDomainModel AddState([FromBody] StateInputDTO NewState)
        {
            
            var state = StateRepository.CreateState(NewState);
            return state;
        }

        [HttpDelete("{id}")]
        public string DeleteStateByID([FromRoute] int id)
        {
            var state = States.FirstOrDefault(x => x.Key==id);
            States.Remove(id);
            return $"{state} is removed";
        }

        [HttpPut("{id}/{name}")]
        public string UpdateState([FromRoute] int id, [FromRoute] string name)
        {
            States[id] = name;
            return $"Updated : {States[id]}";
        }
    }
}
