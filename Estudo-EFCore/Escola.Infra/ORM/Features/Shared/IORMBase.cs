using Escola.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Infra.ORM.Features.Shared
{
    public interface IORMBase<T> where T: EntidadeBase
    {
        T GetById(int id);
        IList<T> GetAll();
        void Inserir(T registro);
        void Editar(T registro);
        void Excluir(T registro);
    }
}
