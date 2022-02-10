using Escola.Dominio.ProfessorModule;
using Escola.Infra.ORM.Contexts;
using Escola.Infra.ORM.Features.Shared;

namespace Escola.Infra.ORM.Features.ProfessorModule
{
    public class ProfessorORM : ORMBase<Professor>
    {
        public ProfessorORM(AulaContext contexto) : base(contexto)
        {
        }
    }
}
