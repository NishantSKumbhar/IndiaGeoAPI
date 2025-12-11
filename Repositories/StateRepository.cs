using IndiaGeoAPI.Models.Domain_Model;
using IndiaGeoAPI.Models.DTO;

namespace IndiaGeoAPI.Repositories
{
    public class StateRepository
    {
        private static List<StateDomainModel> States = new List<StateDomainModel>{
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Andhra Pradesh", StateCode = "AP", StateCensusCode = "28", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Arunachal Pradesh", StateCode = "AR", StateCensusCode = "12", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Assam", StateCode = "AS", StateCensusCode = "18", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Bihar", StateCode = "BR", StateCensusCode = "10", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Chhattisgarh", StateCode = "CG", StateCensusCode = "22", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Goa", StateCode = "GA", StateCensusCode = "30", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Gujarat", StateCode = "GJ", StateCensusCode = "24", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Haryana", StateCode = "HR", StateCensusCode = "06", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Himachal Pradesh", StateCode = "HP", StateCensusCode = "02", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Jharkhand", StateCode = "JH", StateCensusCode = "20", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Karnataka", StateCode = "KA", StateCensusCode = "29", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Kerala", StateCode = "KL", StateCensusCode = "32", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Madhya Pradesh", StateCode = "MP", StateCensusCode = "23", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Maharashtra", StateCode = "MH", StateCensusCode = "27", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Manipur", StateCode = "MN", StateCensusCode = "14", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Meghalaya", StateCode = "ML", StateCensusCode = "17", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Mizoram", StateCode = "MZ", StateCensusCode = "15", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Nagaland", StateCode = "NL", StateCensusCode = "13", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Odisha", StateCode = "OD", StateCensusCode = "21", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Punjab", StateCode = "PB", StateCensusCode = "03", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Rajasthan", StateCode = "RJ", StateCensusCode = "08", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Sikkim", StateCode = "SK", StateCensusCode = "11", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Tamil Nadu", StateCode = "TN", StateCensusCode = "33", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Telangana", StateCode = "TS", StateCensusCode = "36", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Tripura", StateCode = "TR", StateCensusCode = "16", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Uttar Pradesh", StateCode = "UP", StateCensusCode = "09", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "Uttarakhand", StateCode = "UK", StateCensusCode = "05", StateCreatedAt = DateTime.Now },
            new StateDomainModel { StateID = Guid.NewGuid(), StateName = "West Bengal", StateCode = "WB", StateCensusCode = "19", StateCreatedAt = DateTime.Now }
        };

        public static List<StateDomainModel> GetAllStates()
        {
            return States;
        }

        public static StateDomainModel GetStateWithID(Guid id)
        {
            
            return States.FirstOrDefault(x => x.StateID == id);
        }

        public static StateDomainModel CreateState(StateInputDTO NewState)
        {
            var state = new StateDomainModel()
            {
                StateID = Guid.NewGuid(),
                StateName = NewState.StateName,
                StateCensusCode = NewState.StateCensusCode,
                StateCode = NewState.StateCode,
                StateCreatedAt = DateTime.UtcNow
            };
            States.Add(state);

            return state;
        }

    }
}
