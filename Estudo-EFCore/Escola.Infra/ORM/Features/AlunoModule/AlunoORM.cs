using Escola.Dominio.AlunoModule;
using Escola.Infra.ORM.Contexts;
using Escola.Infra.ORM.Features.Shared;

namespace Escola.Infra.ORM.Features.AlunoModule
{
    public class AlunoORM : ORMBase<Aluno>
    {
        public AlunoORM(AulaContext contexto) : base(contexto)
        {

        }
    }
}
