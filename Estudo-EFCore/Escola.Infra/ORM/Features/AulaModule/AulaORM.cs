using Escola.Dominio.AulaModule;
using Escola.Infra.ORM.Contexts;
using Escola.Infra.ORM.Features.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Infra.ORM.Features.AulaModule
{
    public class AulaORM : ORMBase<Aula>
    {
        public AulaORM(AulaContext contexto) : base(contexto)
        {
        }
    }
}
