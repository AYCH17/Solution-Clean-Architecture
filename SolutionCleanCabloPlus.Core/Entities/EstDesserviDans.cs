using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;

namespace SolutionCleanCabloPlus.Core
{
    public  class EstDesserviDans : BaseEntity, IAggregateRoot
    {
        public int Id { get;  set; } 
        public decimal tarif { get;  set; }
        public int territoireId { get;  set; }
        public int serviceDiffusionId { get;  set; }

        public Territoire territoire { get;  set; }

        public ServiceDiffusion serviceDiffusion { get;  set; }

        public EstDesserviDans()
        {
        }
        public EstDesserviDans( decimal tarif, Territoire territoire, ServiceDiffusion serviceDiffusion)
        {
             this.Id = Id;
            this.tarif = tarif;
            this.territoire = territoire;
            this.serviceDiffusion = serviceDiffusion;
        }



    }
}